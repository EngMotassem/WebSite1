using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using DevExpress.XtraPrinting;
using DevExpress.XtraReports.UI;
using System.Drawing.Printing;


public partial class Default4 : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        //  NavigationMenu.Attributes["style"] = "display:none";

        Control myControlMenu = Page.Master.FindControl("main-menu");
        if (myControlMenu != null)
        {
            myControlMenu.Visible = false;
        }
        XtraReport1 report = new XtraReport1();

        report.Parameters["full_name"].Value = Session["full_name"];

        report.Parameters["school"].Value = Session["school"];
        report.Parameters["seer"].Value = Session["seer"];
        report.Parameters["area"].Value = Session["area"];

        report.Parameters["seat"].Value = Session["seat"];
        report.Parameters["subject"].Value = Session["subject"];
        report.Parameters["divName"].Value = Session["divName"];

        report.Parameters["examDate"].Value = Session["examDate"];
        /*Session["seat"] = TextBox1.Text;
        Session["subject"] = Label10.Text;
        Session["devName"] = Label5.Text;
        Session["examDate"] = Label12.Text;
          */
        report.RequestParameters = false;

       
       
        ASPxDocumentViewer1.Report = report;

        //AutoShowParametersPanel.

      //  report.CreateDocument();
        //PrintToolBase tool = new PrintToolBase(report.PrintingSystem);
        //tool.Print();

    }
}