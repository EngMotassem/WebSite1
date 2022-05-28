using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Default2 : System.Web.UI.Page
{
    private SqlConnection con;
    private SqlCommand com;
    private SqlDataReader dataReader;

    private void connection()
    {
        string constr = ConfigurationManager.ConnectionStrings["DefaultConnection"].ToString();
        con = new SqlConnection(constr);
    }

    protected void Page_Load(object sender, EventArgs e)
    {
    //  Calendar1.SelectedDate = DateTime.Today;

    }

    protected void Button1_Click(object sender, EventArgs e)
    {
        if (TextBox1.Text != "")
        {

            getdata();
           // Label24.Text = "";

           
        }
        else
        {
            ScriptManager.RegisterClientScriptBlock(Page, typeof(Page), "ClientScript", "alert('ادخل رقم الجلوس')", true);
            ClearData();


        }

    }
    private void getdata()
    {
        connection();
        con.Open();
        string query = "dbo.MotDate";         //Stored Procedure name   
        SqlCommand com = new SqlCommand(query, con)
        {
            CommandType = CommandType.StoredProcedure  //here we declaring command type as stored Procedure  
        };  //creating  SqlCommand  object  

        //DateTime selectedDate = Calendar1.SelectedDate.Date;
        
       
        com.Parameters.AddWithValue("@St", Convert.ToInt32(TextBox1.Text));
        if(Calendar1.SelectedDate.Date == DateTime.MinValue)
            com.Parameters.AddWithValue("@ExamDate ", null);
        else
            com.Parameters.AddWithValue("@ExamDate ", Calendar1.SelectedDate.Date);
        
        com.Parameters.Add("@Message", SqlDbType.Int);
        com.Parameters["@Message"].Direction = ParameterDirection.Output;
        //com.Parameters.AddWithValue("@seatno", Convert.ToInt32(TextBox1.Text));
        // open connection 


        SqlDataReader dataReader = com.ExecuteReader(CommandBehavior.CloseConnection);


        int m = Convert.ToInt32(com.Parameters["@Message"].Value);

        //int i = Convert.ToInt32(Label24.Text);
        if (m == 0)
        {
            Label24.Text = "غير موجود";
            Label24.Style.Add("color", "red");
            ClearData();
        }
      
        while (dataReader.Read())
        {

            Label24.Text = " موجود";
            Label24.Style.Add("color", "green");

            Label2.Text = dataReader["full_name"].ToString();

            Label3.Text = dataReader["schoolDesc"].ToString();

            Label4.Text = dataReader["ljnaDesc"].ToString();
            Label16.Text = dataReader["cityDesc"].ToString();
            Label5.Text =  dataReader["Div"].ToString() =="1"?"الأدبي" : "المعهد الديني";

            Label10.Text = dataReader["subjectDesc"].ToString();
            Label12.Text = dataReader["examDate"].ToString();
            DateTime oDate = Convert.ToDateTime(Label12.Text);
            //day 
            Label14.Text = oDate.ToString("dddd", new System.Globalization.CultureInfo("ar-AE"));

           // Label19.Text = dataReader["SubjectId"].ToString();

            Label21.Text = dataReader["ExamId"].ToString();

            /*
            Label2.Text = dataReader.GetValue(dataReader.GetOrdinal("full_name")) + "";

            Label3.Text = dataReader.GetValue(dataReader.GetOrdinal("schoolDesc")) + "";

            Label4.Text = dataReader.GetValue(dataReader.GetOrdinal("ljnaDesc")) + "";
            Label16.Text = dataReader.GetValue(dataReader.GetOrdinal("cityDesc")) + "";
            Label5.Text = dataReader.GetValue(dataReader.GetOrdinal("Div")) + "";
            */

        }

        con.Close();
        

        //string sql = "select * from Student,School,Ljna,city,St_Type where Student.School = School.SchoolCode and Student.LjnaNum = Ljna.LjnaNum and Ljna.CityId = City.CityId and Student.StType = St_Type.St_TypeId and Seat = @seatno";





    }
  

    private void ClearData()
    {
        Label2.Text = Label3.Text = Label4.Text = Label5.Text =  Label10.Text=Label16.Text=Label10.Text= "";
        Label12.Text = Label19.Text = Label14.Text = Label21.Text = "";
        repotDescTxt.Text = "";
        autoNU();


       
    }

    private void autoNU()
    {

        int i = 0;
        if (TextBox2.Text != "")
        {
            //var str = number.ToString("00000"); // At least five digits with leading zeroes if required.

            i = Convert.ToInt32(TextBox2.Text);
         /*  if(TextBox2.Text=="09")
            {
                TextBox2.Text = (i + 1).ToString("000");
            } */

            if (TextBox2.Text.StartsWith("0"))
            {
                TextBox2.Text = '0'+(i + 1).ToString();
            }
            
            else
            TextBox2.Text = (i + 1).ToString();
        }

       // return 1;
    }
   

    protected void TakenBt_Click(object sender, EventArgs e)
    {
        string dep = "";

            if(Label5.Text=="1")
        {
            dep = "الأدبي";
        }
            else  if (Label5.Text == "3")
        {
            dep = "المعهد الديني";
        }
        Session["full_name"] = Label2.Text;
        Session["school"] = Label3.Text;
        Session["seer"] = Label4.Text;
        Session["area"] = Label16.Text;
        Session["seat"] = TextBox1.Text;
        Session["subject"] = Label10.Text;
        Session["divName"] = dep;

        DateTime oDate = Convert.ToDateTime(Label12.Text);
        Session["examDate"] = oDate.Date.ToShortDateString();



        //Session["schoolDesc"] = Label3.Text;
        Response.Redirect("Default4.aspx");
            //ClearData();


        

    }

    protected void PrintRep_Click(object sender, EventArgs e)
    {
        if(AddHerman() )

        {
            Session["seatno"] = Convert.ToInt32(TextBox1.Text);

            Session["examId"] = Convert.ToInt32(Label21.Text);
            Session["year"] = GetYear();
            Session["day"] = GetToday();

             string url = "hermanoneshow.aspx";
             string s = "window.open('" + url + "', 'popup_window', 'width=1200,height=800,left=50,top=50,resizable=yes');";
            ClientScript.RegisterStartupScript(this.GetType(), "script", s, true);
          //  Response.Redirect(url);
            ClearData();
        }


 

        }


    


    protected void Clear_Click(object sender, EventArgs e)
    {

        
        ClearData();



 
    }

    public string GetYear()
    {
        return ConfigurationManager.AppSettings["year"];

    }

    public string GetPeriod()
    {
        return ConfigurationManager.AppSettings["period"];

    }

    public string GetToday()
    {

        DateTime localDate = DateTime.Now;
       // DateTime oDate = Convert.ToDateTime(Label12.Text);
        //day 
        string cDay = localDate.ToString("dddd", new System.Globalization.CultureInfo("ar-AE"));
        return cDay;

    }
  // TODO 
    private bool SamenNmberExist()
    {
        connection();
        con.Open();

        string query = "dbo.Herman_rep";         //Stored Procedure name   
        SqlCommand com = new SqlCommand(query, con)
        {
            CommandType = CommandType.StoredProcedure  //here we declaring command type as stored Procedure  
        };  //creating  SqlCommand  object  


    
        com.Parameters.AddWithValue("@reportnumber ", TextBox2.Text);
        int i = com.ExecuteNonQuery();

        if (i > 0)
        {
           // con.Close();
            return true;

        }
        else
        {
            //con.Close();
            return false;
        }

       
    }

    private bool SameStudentSubject()
    {
        return false;
    }

     //TODO
    private bool HasFinalHerman()
    {

        return false;
    }
    private bool AddHerman()
    {

        connection();
        con.Open();
        
        string query = "dbo.Herman_Insert";         //Stored Procedure name   
        SqlCommand com = new SqlCommand(query, con)
        {
            CommandType = CommandType.StoredProcedure  //here we declaring command type as stored Procedure  
        };  //creating  SqlCommand  object  

        
        com.Parameters.AddWithValue("@seatNO", Convert.ToInt32(TextBox1.Text));         
        com.Parameters.AddWithValue("@examId ", Convert.ToInt32(Label21.Text));       
        com.Parameters.AddWithValue("@reportDeatils ", repotDescTxt.Text);       
        com.Parameters.AddWithValue("@fromDesc ", DropDownList1.Text);       
        com.Parameters.AddWithValue("@SubjectId ", Convert.ToInt32(TextBox1.Text));       
        com.Parameters.AddWithValue("@hermanType ", DropDownList1.SelectedValue);       
        com.Parameters.AddWithValue("@reportnumber ", TextBox2.Text);
        com.Parameters.Add("@NewId", SqlDbType.Int);
        com.Parameters["@NewId"].Direction = ParameterDirection.Output;
        com.Parameters.Add("@Message", SqlDbType.NVarChar,500);
        com.Parameters["@Message"].Direction = ParameterDirection.Output;
      

        int i =com.ExecuteNonQuery();

        if (com.Parameters["@Message"].Value.ToString() == "لا يمكن اضافة حرمان لهذا الطالب")
        {
            Label24.Style.Add("color", "red");
        }
        else
        {
            Label24.Style.Add("color", "Green");
        }
        Label24.Text = com.Parameters["@Message"].Value.ToString();
       

        if (Label24.Text== "لا يمكن اضافة حرمان لهذا الطالب")
        {
            con.Close();
            return false;

        }
        else
        {
            con.Close();
            return true;
        }
           
       
    }



  



}
 