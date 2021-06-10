using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class SearchStd : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
       // getdata();

    }


    private SqlConnection con;
    private SqlCommand com;
    private SqlDataReader dataReader;

    private void connection()
    {
        string constr = ConfigurationManager.ConnectionStrings["DefaultConnection"].ToString();
        con = new SqlConnection(constr);
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
            Label2.Text = dataReader.GetValue(dataReader.GetOrdinal("full_name")) + "" ;
        
            Label3.Text = dataReader.GetValue(dataReader.GetOrdinal("schoolDesc")) + "";

            Label4.Text = dataReader.GetValue(dataReader.GetOrdinal("ljnaDesc")) + "";
            Label5.Text = dataReader.GetValue(dataReader.GetOrdinal("cityDesc")) + "";
            // reportdesc = dataReader.GetValue(4).ToString();
            // reptype = Convert.ToInt32(dataReader.GetValue(3));

        }


    }

    protected void Button1_Click(object sender, EventArgs e)
    {
        getdata();

        Session["full_name"] = Label2.Text;
        Session["schoolDesc"] = Label3.Text;
        Response.Redirect("Default4.aspx");

    }
}