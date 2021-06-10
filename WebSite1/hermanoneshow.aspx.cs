using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class hermanoneshow : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        XtraReport2 report = new XtraReport2();

        report.Parameters["seatno"].Value = Session["seatno"];

        report.Parameters["examId"].Value = Session["examId"];
        report.Parameters["year"].Value = Session["year"];
        report.Parameters["day"].Value = Session["day"];

       
        report.RequestParameters = false;


          ASPxDocumentViewer1.Report = report;


    }
}