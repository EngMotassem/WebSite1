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

    }

    protected void Button1_Click(object sender, EventArgs e)
    {
        if (TextBox1.Text != "")
        {

            getdata();

            getExam();

            //Session["full_name"] = Label2.Text;
            //Session["schoolDesc"] = Label3.Text;
            // Response.Redirect("Default4.aspx");
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
        string sql = "select * from Student,School,Ljna,city,St_Type where Student.School = School.SchoolCode and Student.LjnaNum = Ljna.LjnaNum and Ljna.CityId = City.CityId and Student.StType = St_Type.St_TypeId and Seat = @seatno";
        com = new SqlCommand(sql, con);
        com.Parameters.AddWithValue("@seatno", Convert.ToInt32(TextBox1.Text));
        // open connection 
        con.Open();
        dataReader = com.ExecuteReader();
        while (dataReader.Read())
        {
            Label2.Text = dataReader.GetValue(dataReader.GetOrdinal("full_name")) + "";

            Label3.Text = dataReader.GetValue(dataReader.GetOrdinal("schoolDesc")) + "";

            Label4.Text = dataReader.GetValue(dataReader.GetOrdinal("ljnaDesc")) + "";
            Label16.Text = dataReader.GetValue(dataReader.GetOrdinal("cityDesc")) + "";
            Label5.Text = dataReader.GetValue(dataReader.GetOrdinal("Div")) + "";

        }

        con.Close();
        

        //string sql = "select * from Student,School,Ljna,city,St_Type where Student.School = School.SchoolCode and Student.LjnaNum = Ljna.LjnaNum and Ljna.CityId = City.CityId and Student.StType = St_Type.St_TypeId and Seat = @seatno";





    }
    private void getExam()
    {
        connection();
        string sql = "select examDate,subjectDesc,ExamId,exam.SubjectId  from (Exam inner join Subject on Exam.SubjectId = Subject.SubjectId) where div=@div and ExamDate=@exdate";
        com = new SqlCommand(sql, con);
        com.Parameters.AddWithValue("@div",Convert.ToInt32(Label5.Text));
        com.Parameters.AddWithValue("@exdate", Calendar1.SelectedDate.ToString());
        // open connection 
        con.Open();
        dataReader = com.ExecuteReader();
        while (dataReader.Read())
        {
            Label10.Text = dataReader.GetValue(dataReader.GetOrdinal("subjectDesc")) + "";
            Label12.Text = dataReader.GetValue(dataReader.GetOrdinal("examDate")) + "";
            DateTime oDate = Convert.ToDateTime(Label12.Text);
             //day 
            Label14.Text = oDate.ToString("dddd", new System.Globalization.CultureInfo("ar-AE"));

            Label19.Text = dataReader.GetValue(dataReader.GetOrdinal("SubjectId")) + "";

            Label21.Text = dataReader.GetValue(dataReader.GetOrdinal("ExamId")) + "";



        }
        con.Close();
    }

    private void ClearData()
    {
        Label2.Text = Label3.Text = Label4.Text = Label5.Text = TextBox1.Text= Label10.Text=Label16.Text=Label10.Text= "";
        Label12.Text = Label19.Text = Label14.Text = Label21.Text = "";
        repotDescTxt.Text = "";
        autoNU();


       
    }

    private void autoNU()
    {

        int i = 0;
        if (TextBox2.Text != "")
        {
            i = Convert.ToInt32(TextBox2.Text);
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

        if (AddHerman())
        {

            Session["seatno"] = Convert.ToInt32(TextBox1.Text);

            Session["examId"] = Convert.ToInt32(Label21.Text);
            Session["year"] = GetYear();
            Session["day"] = GetToday();
            Response.Redirect("hermanoneshow.aspx");
        }
        ClearData();

        


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


    private bool AddHerman()
    {

        connection();
        con.Open();
        string query = "dbo.Herman_Insert";         //Stored Procedure name   
        SqlCommand com = new SqlCommand(query, con)
        {
            CommandType = CommandType.StoredProcedure  //here we declaring command type as stored Procedure  
        };  //creating  SqlCommand  object  

        
        com.Parameters.AddWithValue("@seatNO", Convert.ToInt32(TextBox1.Text));        //first Name  
        com.Parameters.AddWithValue("@examId ", Convert.ToInt32(Label21.Text));     //middle Name  
        com.Parameters.AddWithValue("@reportDeatils ", repotDescTxt.Text);       //Last Name  
        com.Parameters.AddWithValue("@fromDesc ", DropDownList1.Text);       //Last Name 
        com.Parameters.AddWithValue("@SubjectId ", Convert.ToInt32(TextBox1.Text));       //Last Name 
        com.Parameters.AddWithValue("@hermanType ", DropDownList1.SelectedValue);       //Last Name 
        com.Parameters.AddWithValue("@reportnumber ", "1");       //Last Name 
        int i=com.ExecuteNonQuery();
        /*
         @seatNO,
@examId,
@reportDeatils,
@fromDesc,
@SubjectId,
@hermanType,
@reportnumber
*/
        if (i > 0)
        {
            con.Close();
            return true;

        }
        else
        {
            con.Close();
            return false;
        }
           
       
    }



    private bool UpdateHerman()
    {

        connection();
        con.Open();
        string query = "dbo.Herman_U";         //Stored Procedure name   
        SqlCommand com = new SqlCommand(query, con)
        {
            CommandType = CommandType.StoredProcedure  //here we declaring command type as stored Procedure  
        };  //creating  SqlCommand  object  


        com.Parameters.AddWithValue("@seatNO", Convert.ToInt32(TextBox1.Text));        //first Name  
        com.Parameters.AddWithValue("@examId ", Convert.ToInt32(Label21.Text));     //middle Name  
        com.Parameters.AddWithValue("@reportDeatils ", repotDescTxt.Text);       //Last Name  
        com.Parameters.AddWithValue("@fromDesc ", DropDownList1.Text);       //Last Name 
        //com.Parameters.AddWithValue("@SubjectId ", Convert.ToInt32(TextBox1.Text));       //Last Name 
        com.Parameters.AddWithValue("@hermanType ", DropDownList1.SelectedValue);       //Last Name 
        com.Parameters.AddWithValue("@reportnumber ", "1");       //Last Name 
        int i = com.ExecuteNonQuery();
        /*
         @seatNO,
@examId,
@reportDeatils,
@fromDesc,
@SubjectId,
@hermanType,
@reportnumber
*/
        if (i > 0)
        {
            con.Close();
            return true;

        }
        else
        {
            con.Close();
            return false;
        }


    }



}
 