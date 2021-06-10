using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using DevExpress.XtraReports.UI;

/// <summary>
/// Summary description for XtraReport2
/// </summary>
public class XtraReport2 : DevExpress.XtraReports.UI.XtraReport
{
    private DevExpress.XtraReports.UI.DetailBand Detail;
    private DevExpress.XtraReports.UI.TopMarginBand TopMargin;
    private DevExpress.XtraReports.UI.BottomMarginBand BottomMargin;
    private DevExpress.DataAccess.Sql.SqlDataSource sqlDataSource1;
    private DevExpress.DataAccess.Sql.SqlDataSource sqlDataSource2;
    private DevExpress.DataAccess.Sql.SqlDataSource sqlDataSource3;
    private DevExpress.XtraReports.Parameters.Parameter seatno;
    private DevExpress.XtraReports.Parameters.Parameter examId;
    private DevExpress.DataAccess.Sql.SqlDataSource sqlDataSource4;
    private XRLabel xrLabel2;
    private XRLabel xrLabel6;
    private XRLabel xrLabel5;
    private XRLabel xrLabel4;
    private XRLabel xrLabel9;
    private XRLabel xrLabel7;
    private XRLabel xrLabel10;
    private XRLabel xrLabel13;
    private XRLabel xrLabel12;
    private XRLabel xrLabel18;
    private XRLabel xrLabel17;
    private XRLabel xrLabel16;
    private XRPictureBox xrPictureBox1;
    private XRLabel xrLabel14;
    private XRPictureBox xrPictureBox2;
    private XRLabel xrLabel15;
    private DevExpress.DataAccess.Sql.SqlDataSource sqlDataSource5;
    private XRLabel xrLabel20;
    private XRLabel xrLabel22;
    private XRLabel xrLabel24;
    private XRLabel xrLabel26;
    private XRLabel xrLabel25;
    private XRLabel xrLabel19;
    private XRLabel xrLabel28;
    private XRLabel xrLabel21;
    private XRLabel xrLabel31;
    private XRLabel xrLabel29;
    private XRLabel xrLabel33;
    private XRLabel xrLabel32;
    private XRLabel xrLabel1;
    private XRLabel xrLabel11;
    private XRLabel xrLabel8;
    private XRLabel xrLabel35;
    private XRLabel xrLabel23;
    private DevExpress.DataAccess.Sql.SqlDataSource sqlDataSource6;
    private DevExpress.DataAccess.Sql.SqlDataSource sqlDataSource7;
    private XRLabel xrLabel27;
    private XRLabel xrLabel37;
    private XRLabel xrLabel36;
    private DevExpress.XtraReports.Parameters.Parameter year;
    private DevExpress.XtraReports.Parameters.Parameter day;
    private XRLabel xrLabel34;
    private XRLabel xrLabel30;

    /// <summary>
    /// Required designer variable.
    /// </summary>
    private System.ComponentModel.IContainer components = null;

    public XtraReport2()
    {
        InitializeComponent();
        //
        // TODO: Add constructor logic here
        //
    }

    /// <summary> 
    /// Clean up any resources being used.
    /// </summary>
    /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
    protected override void Dispose(bool disposing)
    {
        if (disposing && (components != null))
        {
            components.Dispose();
        }
        base.Dispose(disposing);
    }

    #region Designer generated code

    /// <summary>
    /// Required method for Designer support - do not modify
    /// the contents of this method with the code editor.
    /// </summary>
    private void InitializeComponent()
    {
            string resourceFileName = "herm1.resx";
            System.Resources.ResourceManager resources = global::Resources.herm1.ResourceManager;
            this.components = new System.ComponentModel.Container();
            DevExpress.DataAccess.Sql.SelectQuery selectQuery1 = new DevExpress.DataAccess.Sql.SelectQuery();
            DevExpress.DataAccess.Sql.Column column1 = new DevExpress.DataAccess.Sql.Column();
            DevExpress.DataAccess.Sql.ColumnExpression columnExpression1 = new DevExpress.DataAccess.Sql.ColumnExpression();
            DevExpress.DataAccess.Sql.Table table1 = new DevExpress.DataAccess.Sql.Table();
            DevExpress.DataAccess.Sql.Column column2 = new DevExpress.DataAccess.Sql.Column();
            DevExpress.DataAccess.Sql.ColumnExpression columnExpression2 = new DevExpress.DataAccess.Sql.ColumnExpression();
            DevExpress.DataAccess.Sql.Column column3 = new DevExpress.DataAccess.Sql.Column();
            DevExpress.DataAccess.Sql.ColumnExpression columnExpression3 = new DevExpress.DataAccess.Sql.ColumnExpression();
            DevExpress.DataAccess.Sql.Column column4 = new DevExpress.DataAccess.Sql.Column();
            DevExpress.DataAccess.Sql.ColumnExpression columnExpression4 = new DevExpress.DataAccess.Sql.ColumnExpression();
            DevExpress.DataAccess.Sql.Column column5 = new DevExpress.DataAccess.Sql.Column();
            DevExpress.DataAccess.Sql.ColumnExpression columnExpression5 = new DevExpress.DataAccess.Sql.ColumnExpression();
            DevExpress.DataAccess.Sql.Column column6 = new DevExpress.DataAccess.Sql.Column();
            DevExpress.DataAccess.Sql.ColumnExpression columnExpression6 = new DevExpress.DataAccess.Sql.ColumnExpression();
            DevExpress.DataAccess.Sql.Column column7 = new DevExpress.DataAccess.Sql.Column();
            DevExpress.DataAccess.Sql.ColumnExpression columnExpression7 = new DevExpress.DataAccess.Sql.ColumnExpression();
            DevExpress.DataAccess.Sql.SelectQuery selectQuery2 = new DevExpress.DataAccess.Sql.SelectQuery();
            DevExpress.DataAccess.Sql.Column column8 = new DevExpress.DataAccess.Sql.Column();
            DevExpress.DataAccess.Sql.ColumnExpression columnExpression8 = new DevExpress.DataAccess.Sql.ColumnExpression();
            DevExpress.DataAccess.Sql.Table table2 = new DevExpress.DataAccess.Sql.Table();
            DevExpress.DataAccess.Sql.Column column9 = new DevExpress.DataAccess.Sql.Column();
            DevExpress.DataAccess.Sql.ColumnExpression columnExpression9 = new DevExpress.DataAccess.Sql.ColumnExpression();
            DevExpress.DataAccess.Sql.Column column10 = new DevExpress.DataAccess.Sql.Column();
            DevExpress.DataAccess.Sql.ColumnExpression columnExpression10 = new DevExpress.DataAccess.Sql.ColumnExpression();
            DevExpress.DataAccess.Sql.Column column11 = new DevExpress.DataAccess.Sql.Column();
            DevExpress.DataAccess.Sql.ColumnExpression columnExpression11 = new DevExpress.DataAccess.Sql.ColumnExpression();
            DevExpress.DataAccess.Sql.Column column12 = new DevExpress.DataAccess.Sql.Column();
            DevExpress.DataAccess.Sql.ColumnExpression columnExpression12 = new DevExpress.DataAccess.Sql.ColumnExpression();
            DevExpress.DataAccess.Sql.Column column13 = new DevExpress.DataAccess.Sql.Column();
            DevExpress.DataAccess.Sql.ColumnExpression columnExpression13 = new DevExpress.DataAccess.Sql.ColumnExpression();
            DevExpress.DataAccess.Sql.Column column14 = new DevExpress.DataAccess.Sql.Column();
            DevExpress.DataAccess.Sql.ColumnExpression columnExpression14 = new DevExpress.DataAccess.Sql.ColumnExpression();
            DevExpress.DataAccess.Sql.Column column15 = new DevExpress.DataAccess.Sql.Column();
            DevExpress.DataAccess.Sql.ColumnExpression columnExpression15 = new DevExpress.DataAccess.Sql.ColumnExpression();
            DevExpress.DataAccess.Sql.SelectQuery selectQuery3 = new DevExpress.DataAccess.Sql.SelectQuery();
            DevExpress.DataAccess.Sql.Column column16 = new DevExpress.DataAccess.Sql.Column();
            DevExpress.DataAccess.Sql.ColumnExpression columnExpression16 = new DevExpress.DataAccess.Sql.ColumnExpression();
            DevExpress.DataAccess.Sql.Table table3 = new DevExpress.DataAccess.Sql.Table();
            DevExpress.DataAccess.Sql.Column column17 = new DevExpress.DataAccess.Sql.Column();
            DevExpress.DataAccess.Sql.ColumnExpression columnExpression17 = new DevExpress.DataAccess.Sql.ColumnExpression();
            DevExpress.DataAccess.Sql.Column column18 = new DevExpress.DataAccess.Sql.Column();
            DevExpress.DataAccess.Sql.ColumnExpression columnExpression18 = new DevExpress.DataAccess.Sql.ColumnExpression();
            DevExpress.DataAccess.Sql.Column column19 = new DevExpress.DataAccess.Sql.Column();
            DevExpress.DataAccess.Sql.ColumnExpression columnExpression19 = new DevExpress.DataAccess.Sql.ColumnExpression();
            DevExpress.DataAccess.Sql.SelectQuery selectQuery4 = new DevExpress.DataAccess.Sql.SelectQuery();
            DevExpress.DataAccess.Sql.Column column20 = new DevExpress.DataAccess.Sql.Column();
            DevExpress.DataAccess.Sql.ColumnExpression columnExpression20 = new DevExpress.DataAccess.Sql.ColumnExpression();
            DevExpress.DataAccess.Sql.Table table4 = new DevExpress.DataAccess.Sql.Table();
            DevExpress.DataAccess.Sql.Column column21 = new DevExpress.DataAccess.Sql.Column();
            DevExpress.DataAccess.Sql.ColumnExpression columnExpression21 = new DevExpress.DataAccess.Sql.ColumnExpression();
            DevExpress.DataAccess.Sql.Column column22 = new DevExpress.DataAccess.Sql.Column();
            DevExpress.DataAccess.Sql.ColumnExpression columnExpression22 = new DevExpress.DataAccess.Sql.ColumnExpression();
            DevExpress.DataAccess.Sql.Column column23 = new DevExpress.DataAccess.Sql.Column();
            DevExpress.DataAccess.Sql.ColumnExpression columnExpression23 = new DevExpress.DataAccess.Sql.ColumnExpression();
            DevExpress.DataAccess.Sql.Column column24 = new DevExpress.DataAccess.Sql.Column();
            DevExpress.DataAccess.Sql.ColumnExpression columnExpression24 = new DevExpress.DataAccess.Sql.ColumnExpression();
            DevExpress.DataAccess.Sql.Column column25 = new DevExpress.DataAccess.Sql.Column();
            DevExpress.DataAccess.Sql.ColumnExpression columnExpression25 = new DevExpress.DataAccess.Sql.ColumnExpression();
            DevExpress.DataAccess.Sql.Column column26 = new DevExpress.DataAccess.Sql.Column();
            DevExpress.DataAccess.Sql.ColumnExpression columnExpression26 = new DevExpress.DataAccess.Sql.ColumnExpression();
            DevExpress.DataAccess.Sql.SelectQuery selectQuery5 = new DevExpress.DataAccess.Sql.SelectQuery();
            DevExpress.DataAccess.Sql.Column column27 = new DevExpress.DataAccess.Sql.Column();
            DevExpress.DataAccess.Sql.ColumnExpression columnExpression27 = new DevExpress.DataAccess.Sql.ColumnExpression();
            DevExpress.DataAccess.Sql.Table table5 = new DevExpress.DataAccess.Sql.Table();
            DevExpress.DataAccess.Sql.Column column28 = new DevExpress.DataAccess.Sql.Column();
            DevExpress.DataAccess.Sql.ColumnExpression columnExpression28 = new DevExpress.DataAccess.Sql.ColumnExpression();
            DevExpress.DataAccess.Sql.SelectQuery selectQuery6 = new DevExpress.DataAccess.Sql.SelectQuery();
            DevExpress.DataAccess.Sql.Column column29 = new DevExpress.DataAccess.Sql.Column();
            DevExpress.DataAccess.Sql.ColumnExpression columnExpression29 = new DevExpress.DataAccess.Sql.ColumnExpression();
            DevExpress.DataAccess.Sql.Table table6 = new DevExpress.DataAccess.Sql.Table();
            DevExpress.DataAccess.Sql.Column column30 = new DevExpress.DataAccess.Sql.Column();
            DevExpress.DataAccess.Sql.ColumnExpression columnExpression30 = new DevExpress.DataAccess.Sql.ColumnExpression();
            DevExpress.DataAccess.Sql.Column column31 = new DevExpress.DataAccess.Sql.Column();
            DevExpress.DataAccess.Sql.ColumnExpression columnExpression31 = new DevExpress.DataAccess.Sql.ColumnExpression();
            DevExpress.DataAccess.Sql.Column column32 = new DevExpress.DataAccess.Sql.Column();
            DevExpress.DataAccess.Sql.ColumnExpression columnExpression32 = new DevExpress.DataAccess.Sql.ColumnExpression();
            DevExpress.DataAccess.Sql.Column column33 = new DevExpress.DataAccess.Sql.Column();
            DevExpress.DataAccess.Sql.ColumnExpression columnExpression33 = new DevExpress.DataAccess.Sql.ColumnExpression();
            DevExpress.DataAccess.Sql.SelectQuery selectQuery7 = new DevExpress.DataAccess.Sql.SelectQuery();
            DevExpress.DataAccess.Sql.Column column34 = new DevExpress.DataAccess.Sql.Column();
            DevExpress.DataAccess.Sql.ColumnExpression columnExpression34 = new DevExpress.DataAccess.Sql.ColumnExpression();
            DevExpress.DataAccess.Sql.Table table7 = new DevExpress.DataAccess.Sql.Table();
            DevExpress.DataAccess.Sql.Column column35 = new DevExpress.DataAccess.Sql.Column();
            DevExpress.DataAccess.Sql.ColumnExpression columnExpression35 = new DevExpress.DataAccess.Sql.ColumnExpression();
            DevExpress.DataAccess.Sql.Column column36 = new DevExpress.DataAccess.Sql.Column();
            DevExpress.DataAccess.Sql.ColumnExpression columnExpression36 = new DevExpress.DataAccess.Sql.ColumnExpression();
            DevExpress.DataAccess.Sql.Column column37 = new DevExpress.DataAccess.Sql.Column();
            DevExpress.DataAccess.Sql.ColumnExpression columnExpression37 = new DevExpress.DataAccess.Sql.ColumnExpression();
            DevExpress.DataAccess.Sql.Column column38 = new DevExpress.DataAccess.Sql.Column();
            DevExpress.DataAccess.Sql.ColumnExpression columnExpression38 = new DevExpress.DataAccess.Sql.ColumnExpression();
            DevExpress.DataAccess.Sql.Column column39 = new DevExpress.DataAccess.Sql.Column();
            DevExpress.DataAccess.Sql.ColumnExpression columnExpression39 = new DevExpress.DataAccess.Sql.ColumnExpression();
            DevExpress.DataAccess.Sql.Column column40 = new DevExpress.DataAccess.Sql.Column();
            DevExpress.DataAccess.Sql.ColumnExpression columnExpression40 = new DevExpress.DataAccess.Sql.ColumnExpression();
            DevExpress.DataAccess.Sql.Column column41 = new DevExpress.DataAccess.Sql.Column();
            DevExpress.DataAccess.Sql.ColumnExpression columnExpression41 = new DevExpress.DataAccess.Sql.ColumnExpression();
            DevExpress.DataAccess.Sql.Column column42 = new DevExpress.DataAccess.Sql.Column();
            DevExpress.DataAccess.Sql.ColumnExpression columnExpression42 = new DevExpress.DataAccess.Sql.ColumnExpression();
            DevExpress.DataAccess.Sql.Column column43 = new DevExpress.DataAccess.Sql.Column();
            DevExpress.DataAccess.Sql.ColumnExpression columnExpression43 = new DevExpress.DataAccess.Sql.ColumnExpression();
            DevExpress.DataAccess.Sql.SelectQuery selectQuery8 = new DevExpress.DataAccess.Sql.SelectQuery();
            DevExpress.DataAccess.Sql.Column column44 = new DevExpress.DataAccess.Sql.Column();
            DevExpress.DataAccess.Sql.ColumnExpression columnExpression44 = new DevExpress.DataAccess.Sql.ColumnExpression();
            DevExpress.DataAccess.Sql.Table table8 = new DevExpress.DataAccess.Sql.Table();
            DevExpress.DataAccess.Sql.Column column45 = new DevExpress.DataAccess.Sql.Column();
            DevExpress.DataAccess.Sql.ColumnExpression columnExpression45 = new DevExpress.DataAccess.Sql.ColumnExpression();
            DevExpress.DataAccess.Sql.Column column46 = new DevExpress.DataAccess.Sql.Column();
            DevExpress.DataAccess.Sql.ColumnExpression columnExpression46 = new DevExpress.DataAccess.Sql.ColumnExpression();
            DevExpress.DataAccess.Sql.Column column47 = new DevExpress.DataAccess.Sql.Column();
            DevExpress.DataAccess.Sql.ColumnExpression columnExpression47 = new DevExpress.DataAccess.Sql.ColumnExpression();
            DevExpress.DataAccess.Sql.MasterDetailInfo masterDetailInfo1 = new DevExpress.DataAccess.Sql.MasterDetailInfo();
            DevExpress.DataAccess.Sql.RelationColumnInfo relationColumnInfo1 = new DevExpress.DataAccess.Sql.RelationColumnInfo();
            DevExpress.DataAccess.Sql.MasterDetailInfo masterDetailInfo2 = new DevExpress.DataAccess.Sql.MasterDetailInfo();
            DevExpress.DataAccess.Sql.RelationColumnInfo relationColumnInfo2 = new DevExpress.DataAccess.Sql.RelationColumnInfo();
            DevExpress.DataAccess.Sql.MasterDetailInfo masterDetailInfo3 = new DevExpress.DataAccess.Sql.MasterDetailInfo();
            DevExpress.DataAccess.Sql.RelationColumnInfo relationColumnInfo3 = new DevExpress.DataAccess.Sql.RelationColumnInfo();
            DevExpress.DataAccess.Sql.MasterDetailInfo masterDetailInfo4 = new DevExpress.DataAccess.Sql.MasterDetailInfo();
            DevExpress.DataAccess.Sql.RelationColumnInfo relationColumnInfo4 = new DevExpress.DataAccess.Sql.RelationColumnInfo();
            DevExpress.DataAccess.Sql.MasterDetailInfo masterDetailInfo5 = new DevExpress.DataAccess.Sql.MasterDetailInfo();
            DevExpress.DataAccess.Sql.RelationColumnInfo relationColumnInfo5 = new DevExpress.DataAccess.Sql.RelationColumnInfo();
            DevExpress.DataAccess.Sql.MasterDetailInfo masterDetailInfo6 = new DevExpress.DataAccess.Sql.MasterDetailInfo();
            DevExpress.DataAccess.Sql.RelationColumnInfo relationColumnInfo6 = new DevExpress.DataAccess.Sql.RelationColumnInfo();
            DevExpress.DataAccess.Sql.SelectQuery selectQuery9 = new DevExpress.DataAccess.Sql.SelectQuery();
            DevExpress.DataAccess.Sql.Column column48 = new DevExpress.DataAccess.Sql.Column();
            DevExpress.DataAccess.Sql.ColumnExpression columnExpression48 = new DevExpress.DataAccess.Sql.ColumnExpression();
            DevExpress.DataAccess.Sql.Table table9 = new DevExpress.DataAccess.Sql.Table();
            DevExpress.DataAccess.Sql.Column column49 = new DevExpress.DataAccess.Sql.Column();
            DevExpress.DataAccess.Sql.ColumnExpression columnExpression49 = new DevExpress.DataAccess.Sql.ColumnExpression();
            DevExpress.DataAccess.Sql.Column column50 = new DevExpress.DataAccess.Sql.Column();
            DevExpress.DataAccess.Sql.ColumnExpression columnExpression50 = new DevExpress.DataAccess.Sql.ColumnExpression();
            DevExpress.DataAccess.Sql.Column column51 = new DevExpress.DataAccess.Sql.Column();
            DevExpress.DataAccess.Sql.ColumnExpression columnExpression51 = new DevExpress.DataAccess.Sql.ColumnExpression();
            DevExpress.DataAccess.Sql.Column column52 = new DevExpress.DataAccess.Sql.Column();
            DevExpress.DataAccess.Sql.ColumnExpression columnExpression52 = new DevExpress.DataAccess.Sql.ColumnExpression();
            DevExpress.DataAccess.Sql.Column column53 = new DevExpress.DataAccess.Sql.Column();
            DevExpress.DataAccess.Sql.ColumnExpression columnExpression53 = new DevExpress.DataAccess.Sql.ColumnExpression();
            DevExpress.DataAccess.Sql.Column column54 = new DevExpress.DataAccess.Sql.Column();
            DevExpress.DataAccess.Sql.ColumnExpression columnExpression54 = new DevExpress.DataAccess.Sql.ColumnExpression();
            DevExpress.DataAccess.Sql.Column column55 = new DevExpress.DataAccess.Sql.Column();
            DevExpress.DataAccess.Sql.ColumnExpression columnExpression55 = new DevExpress.DataAccess.Sql.ColumnExpression();
            DevExpress.DataAccess.Sql.Column column56 = new DevExpress.DataAccess.Sql.Column();
            DevExpress.DataAccess.Sql.ColumnExpression columnExpression56 = new DevExpress.DataAccess.Sql.ColumnExpression();
            DevExpress.DataAccess.Sql.Column column57 = new DevExpress.DataAccess.Sql.Column();
            DevExpress.DataAccess.Sql.ColumnExpression columnExpression57 = new DevExpress.DataAccess.Sql.ColumnExpression();
            DevExpress.DataAccess.Sql.Column column58 = new DevExpress.DataAccess.Sql.Column();
            DevExpress.DataAccess.Sql.ColumnExpression columnExpression58 = new DevExpress.DataAccess.Sql.ColumnExpression();
            DevExpress.DataAccess.Sql.Column column59 = new DevExpress.DataAccess.Sql.Column();
            DevExpress.DataAccess.Sql.ColumnExpression columnExpression59 = new DevExpress.DataAccess.Sql.ColumnExpression();
            DevExpress.DataAccess.Sql.Column column60 = new DevExpress.DataAccess.Sql.Column();
            DevExpress.DataAccess.Sql.ColumnExpression columnExpression60 = new DevExpress.DataAccess.Sql.ColumnExpression();
            DevExpress.DataAccess.Sql.Column column61 = new DevExpress.DataAccess.Sql.Column();
            DevExpress.DataAccess.Sql.ColumnExpression columnExpression61 = new DevExpress.DataAccess.Sql.ColumnExpression();
            DevExpress.DataAccess.Sql.Column column62 = new DevExpress.DataAccess.Sql.Column();
            DevExpress.DataAccess.Sql.ColumnExpression columnExpression62 = new DevExpress.DataAccess.Sql.ColumnExpression();
            DevExpress.DataAccess.Sql.Column column63 = new DevExpress.DataAccess.Sql.Column();
            DevExpress.DataAccess.Sql.ColumnExpression columnExpression63 = new DevExpress.DataAccess.Sql.ColumnExpression();
            DevExpress.DataAccess.Sql.Column column64 = new DevExpress.DataAccess.Sql.Column();
            DevExpress.DataAccess.Sql.ColumnExpression columnExpression64 = new DevExpress.DataAccess.Sql.ColumnExpression();
            DevExpress.DataAccess.Sql.Column column65 = new DevExpress.DataAccess.Sql.Column();
            DevExpress.DataAccess.Sql.ColumnExpression columnExpression65 = new DevExpress.DataAccess.Sql.ColumnExpression();
            DevExpress.DataAccess.Sql.Column column66 = new DevExpress.DataAccess.Sql.Column();
            DevExpress.DataAccess.Sql.ColumnExpression columnExpression66 = new DevExpress.DataAccess.Sql.ColumnExpression();
            DevExpress.DataAccess.Sql.Column column67 = new DevExpress.DataAccess.Sql.Column();
            DevExpress.DataAccess.Sql.ColumnExpression columnExpression67 = new DevExpress.DataAccess.Sql.ColumnExpression();
            DevExpress.DataAccess.Sql.Column column68 = new DevExpress.DataAccess.Sql.Column();
            DevExpress.DataAccess.Sql.ColumnExpression columnExpression68 = new DevExpress.DataAccess.Sql.ColumnExpression();
            DevExpress.DataAccess.Sql.Column column69 = new DevExpress.DataAccess.Sql.Column();
            DevExpress.DataAccess.Sql.ColumnExpression columnExpression69 = new DevExpress.DataAccess.Sql.ColumnExpression();
            DevExpress.DataAccess.Sql.Column column70 = new DevExpress.DataAccess.Sql.Column();
            DevExpress.DataAccess.Sql.ColumnExpression columnExpression70 = new DevExpress.DataAccess.Sql.ColumnExpression();
            DevExpress.DataAccess.Sql.Column column71 = new DevExpress.DataAccess.Sql.Column();
            DevExpress.DataAccess.Sql.ColumnExpression columnExpression71 = new DevExpress.DataAccess.Sql.ColumnExpression();
            DevExpress.DataAccess.Sql.Column column72 = new DevExpress.DataAccess.Sql.Column();
            DevExpress.DataAccess.Sql.ColumnExpression columnExpression72 = new DevExpress.DataAccess.Sql.ColumnExpression();
            DevExpress.DataAccess.Sql.Column column73 = new DevExpress.DataAccess.Sql.Column();
            DevExpress.DataAccess.Sql.ColumnExpression columnExpression73 = new DevExpress.DataAccess.Sql.ColumnExpression();
            DevExpress.DataAccess.Sql.SelectQuery selectQuery10 = new DevExpress.DataAccess.Sql.SelectQuery();
            DevExpress.DataAccess.Sql.Column column74 = new DevExpress.DataAccess.Sql.Column();
            DevExpress.DataAccess.Sql.ColumnExpression columnExpression74 = new DevExpress.DataAccess.Sql.ColumnExpression();
            DevExpress.DataAccess.Sql.Table table10 = new DevExpress.DataAccess.Sql.Table();
            DevExpress.DataAccess.Sql.Column column75 = new DevExpress.DataAccess.Sql.Column();
            DevExpress.DataAccess.Sql.ColumnExpression columnExpression75 = new DevExpress.DataAccess.Sql.ColumnExpression();
            DevExpress.DataAccess.Sql.Column column76 = new DevExpress.DataAccess.Sql.Column();
            DevExpress.DataAccess.Sql.ColumnExpression columnExpression76 = new DevExpress.DataAccess.Sql.ColumnExpression();
            DevExpress.DataAccess.Sql.Column column77 = new DevExpress.DataAccess.Sql.Column();
            DevExpress.DataAccess.Sql.ColumnExpression columnExpression77 = new DevExpress.DataAccess.Sql.ColumnExpression();
            DevExpress.DataAccess.Sql.Column column78 = new DevExpress.DataAccess.Sql.Column();
            DevExpress.DataAccess.Sql.ColumnExpression columnExpression78 = new DevExpress.DataAccess.Sql.ColumnExpression();
            DevExpress.DataAccess.Sql.Column column79 = new DevExpress.DataAccess.Sql.Column();
            DevExpress.DataAccess.Sql.ColumnExpression columnExpression79 = new DevExpress.DataAccess.Sql.ColumnExpression();
            DevExpress.DataAccess.Sql.SelectQuery selectQuery11 = new DevExpress.DataAccess.Sql.SelectQuery();
            DevExpress.DataAccess.Sql.Column column80 = new DevExpress.DataAccess.Sql.Column();
            DevExpress.DataAccess.Sql.ColumnExpression columnExpression80 = new DevExpress.DataAccess.Sql.ColumnExpression();
            DevExpress.DataAccess.Sql.Table table11 = new DevExpress.DataAccess.Sql.Table();
            DevExpress.DataAccess.Sql.Column column81 = new DevExpress.DataAccess.Sql.Column();
            DevExpress.DataAccess.Sql.ColumnExpression columnExpression81 = new DevExpress.DataAccess.Sql.ColumnExpression();
            DevExpress.DataAccess.Sql.Column column82 = new DevExpress.DataAccess.Sql.Column();
            DevExpress.DataAccess.Sql.ColumnExpression columnExpression82 = new DevExpress.DataAccess.Sql.ColumnExpression();
            DevExpress.DataAccess.Sql.Column column83 = new DevExpress.DataAccess.Sql.Column();
            DevExpress.DataAccess.Sql.ColumnExpression columnExpression83 = new DevExpress.DataAccess.Sql.ColumnExpression();
            DevExpress.DataAccess.Sql.Column column84 = new DevExpress.DataAccess.Sql.Column();
            DevExpress.DataAccess.Sql.ColumnExpression columnExpression84 = new DevExpress.DataAccess.Sql.ColumnExpression();
            DevExpress.DataAccess.Sql.Column column85 = new DevExpress.DataAccess.Sql.Column();
            DevExpress.DataAccess.Sql.ColumnExpression columnExpression85 = new DevExpress.DataAccess.Sql.ColumnExpression();
            DevExpress.DataAccess.Sql.Column column86 = new DevExpress.DataAccess.Sql.Column();
            DevExpress.DataAccess.Sql.ColumnExpression columnExpression86 = new DevExpress.DataAccess.Sql.ColumnExpression();
            DevExpress.DataAccess.Sql.MasterDetailInfo masterDetailInfo7 = new DevExpress.DataAccess.Sql.MasterDetailInfo();
            DevExpress.DataAccess.Sql.RelationColumnInfo relationColumnInfo7 = new DevExpress.DataAccess.Sql.RelationColumnInfo();
            DevExpress.DataAccess.Sql.MasterDetailInfo masterDetailInfo8 = new DevExpress.DataAccess.Sql.MasterDetailInfo();
            DevExpress.DataAccess.Sql.RelationColumnInfo relationColumnInfo8 = new DevExpress.DataAccess.Sql.RelationColumnInfo();
            DevExpress.DataAccess.Sql.StoredProcQuery storedProcQuery1 = new DevExpress.DataAccess.Sql.StoredProcQuery();
            DevExpress.DataAccess.Sql.QueryParameter queryParameter1 = new DevExpress.DataAccess.Sql.QueryParameter();
            DevExpress.DataAccess.Sql.QueryParameter queryParameter2 = new DevExpress.DataAccess.Sql.QueryParameter();
            DevExpress.DataAccess.Sql.StoredProcQuery storedProcQuery2 = new DevExpress.DataAccess.Sql.StoredProcQuery();
            DevExpress.DataAccess.Sql.QueryParameter queryParameter3 = new DevExpress.DataAccess.Sql.QueryParameter();
            DevExpress.DataAccess.Sql.QueryParameter queryParameter4 = new DevExpress.DataAccess.Sql.QueryParameter();
            DevExpress.DataAccess.Sql.StoredProcQuery storedProcQuery3 = new DevExpress.DataAccess.Sql.StoredProcQuery();
            DevExpress.DataAccess.Sql.QueryParameter queryParameter5 = new DevExpress.DataAccess.Sql.QueryParameter();
            DevExpress.DataAccess.Sql.QueryParameter queryParameter6 = new DevExpress.DataAccess.Sql.QueryParameter();
            DevExpress.DataAccess.Sql.StoredProcQuery storedProcQuery4 = new DevExpress.DataAccess.Sql.StoredProcQuery();
            DevExpress.DataAccess.Sql.QueryParameter queryParameter7 = new DevExpress.DataAccess.Sql.QueryParameter();
            DevExpress.DataAccess.Sql.QueryParameter queryParameter8 = new DevExpress.DataAccess.Sql.QueryParameter();
            DevExpress.DataAccess.Sql.StoredProcQuery storedProcQuery5 = new DevExpress.DataAccess.Sql.StoredProcQuery();
            DevExpress.DataAccess.Sql.QueryParameter queryParameter9 = new DevExpress.DataAccess.Sql.QueryParameter();
            DevExpress.DataAccess.Sql.QueryParameter queryParameter10 = new DevExpress.DataAccess.Sql.QueryParameter();
            this.Detail = new DevExpress.XtraReports.UI.DetailBand();
            this.xrLabel34 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLabel30 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLabel37 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLabel36 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLabel27 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLabel35 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLabel23 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLabel11 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLabel8 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLabel1 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLabel33 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLabel32 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLabel31 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLabel29 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLabel28 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLabel21 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLabel19 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLabel18 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLabel17 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLabel16 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLabel26 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLabel25 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLabel13 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLabel24 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLabel22 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLabel20 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLabel12 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLabel10 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLabel9 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLabel7 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLabel6 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLabel5 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLabel4 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLabel2 = new DevExpress.XtraReports.UI.XRLabel();
            this.TopMargin = new DevExpress.XtraReports.UI.TopMarginBand();
            this.xrPictureBox1 = new DevExpress.XtraReports.UI.XRPictureBox();
            this.xrLabel14 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrPictureBox2 = new DevExpress.XtraReports.UI.XRPictureBox();
            this.xrLabel15 = new DevExpress.XtraReports.UI.XRLabel();
            this.BottomMargin = new DevExpress.XtraReports.UI.BottomMarginBand();
            this.sqlDataSource1 = new DevExpress.DataAccess.Sql.SqlDataSource(this.components);
            this.sqlDataSource2 = new DevExpress.DataAccess.Sql.SqlDataSource(this.components);
            this.sqlDataSource3 = new DevExpress.DataAccess.Sql.SqlDataSource(this.components);
            this.seatno = new DevExpress.XtraReports.Parameters.Parameter();
            this.examId = new DevExpress.XtraReports.Parameters.Parameter();
            this.sqlDataSource4 = new DevExpress.DataAccess.Sql.SqlDataSource(this.components);
            this.sqlDataSource5 = new DevExpress.DataAccess.Sql.SqlDataSource(this.components);
            this.sqlDataSource6 = new DevExpress.DataAccess.Sql.SqlDataSource(this.components);
            this.sqlDataSource7 = new DevExpress.DataAccess.Sql.SqlDataSource(this.components);
            this.year = new DevExpress.XtraReports.Parameters.Parameter();
            this.day = new DevExpress.XtraReports.Parameters.Parameter();
            ((System.ComponentModel.ISupportInitialize)(this)).BeginInit();
            // 
            // Detail
            // 
            this.Detail.Controls.AddRange(new DevExpress.XtraReports.UI.XRControl[] {
            this.xrLabel34,
            this.xrLabel30,
            this.xrLabel37,
            this.xrLabel36,
            this.xrLabel27,
            this.xrLabel35,
            this.xrLabel23,
            this.xrLabel11,
            this.xrLabel8,
            this.xrLabel1,
            this.xrLabel33,
            this.xrLabel32,
            this.xrLabel31,
            this.xrLabel29,
            this.xrLabel28,
            this.xrLabel21,
            this.xrLabel19,
            this.xrLabel18,
            this.xrLabel17,
            this.xrLabel16,
            this.xrLabel26,
            this.xrLabel25,
            this.xrLabel13,
            this.xrLabel24,
            this.xrLabel22,
            this.xrLabel20,
            this.xrLabel12,
            this.xrLabel10,
            this.xrLabel9,
            this.xrLabel7,
            this.xrLabel6,
            this.xrLabel5,
            this.xrLabel4,
            this.xrLabel2});
            this.Detail.HeightF = 887.8333F;
            this.Detail.Name = "Detail";
            this.Detail.Padding = new DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100F);
            this.Detail.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft;
            // 
            // xrLabel34
            // 
            this.xrLabel34.ExpressionBindings.AddRange(new DevExpress.XtraReports.UI.ExpressionBinding[] {
            new DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "[ExamDate]")});
            this.xrLabel34.Font = new System.Drawing.Font("Times New Roman", 13.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.xrLabel34.LocationFloat = new DevExpress.Utils.PointFloat(433.1606F, 235.9138F);
            this.xrLabel34.Name = "xrLabel34";
            this.xrLabel34.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabel34.SizeF = new System.Drawing.SizeF(91.83913F, 22.99997F);
            this.xrLabel34.StylePriority.UseFont = false;
            this.xrLabel34.Text = "xrLabel8";
            this.xrLabel34.TextFormatString = "{0:yyyy/MM/dd}";
            // 
            // xrLabel30
            // 
            this.xrLabel30.ExpressionBindings.AddRange(new DevExpress.XtraReports.UI.ExpressionBinding[] {
            new DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "[ExamDate]")});
            this.xrLabel30.Font = new System.Drawing.Font("Times New Roman", 13.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.xrLabel30.LocationFloat = new DevExpress.Utils.PointFloat(433.1607F, 197.1208F);
            this.xrLabel30.Name = "xrLabel30";
            this.xrLabel30.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabel30.SizeF = new System.Drawing.SizeF(91.83913F, 23F);
            this.xrLabel30.StylePriority.UseFont = false;
            this.xrLabel30.Text = "xrLabel8";
            this.xrLabel30.TextFormatString = "{0:yyyy/MM/dd}";
            // 
            // xrLabel37
            // 
            this.xrLabel37.ExpressionBindings.AddRange(new DevExpress.XtraReports.UI.ExpressionBinding[] {
            new DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "[Parameters].[day]")});
            this.xrLabel37.Font = new System.Drawing.Font("Times New Roman", 13.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.xrLabel37.LocationFloat = new DevExpress.Utils.PointFloat(288.207F, 157.1407F);
            this.xrLabel37.Name = "xrLabel37";
            this.xrLabel37.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabel37.SizeF = new System.Drawing.SizeF(77.04016F, 22.99998F);
            this.xrLabel37.StylePriority.UseFont = false;
            // 
            // xrLabel36
            // 
            this.xrLabel36.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Bold);
            this.xrLabel36.LocationFloat = new DevExpress.Utils.PointFloat(210.57F, 33.86206F);
            this.xrLabel36.Multiline = true;
            this.xrLabel36.Name = "xrLabel36";
            this.xrLabel36.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabel36.SizeF = new System.Drawing.SizeF(25.5392F, 33.86207F);
            this.xrLabel36.StylePriority.UseFont = false;
            this.xrLabel36.StylePriority.UseTextAlignment = false;
            this.xrLabel36.Text = " م";
            this.xrLabel36.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopCenter;
            // 
            // xrLabel27
            // 
            this.xrLabel27.Font = new System.Drawing.Font("Times New Roman", 13.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.xrLabel27.LocationFloat = new DevExpress.Utils.PointFloat(213.0278F, 157.1407F);
            this.xrLabel27.Name = "xrLabel27";
            this.xrLabel27.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabel27.SizeF = new System.Drawing.SizeF(57.26445F, 22.99998F);
            this.xrLabel27.StylePriority.UseFont = false;
            this.xrLabel27.Text = "الموافق";
            // 
            // xrLabel35
            // 
            this.xrLabel35.ExpressionBindings.AddRange(new DevExpress.XtraReports.UI.ExpressionBinding[] {
            new DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "[Parameters].[year]")});
            this.xrLabel35.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Bold);
            this.xrLabel35.LocationFloat = new DevExpress.Utils.PointFloat(236.1092F, 33.86208F);
            this.xrLabel35.Multiline = true;
            this.xrLabel35.Name = "xrLabel35";
            this.xrLabel35.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabel35.SizeF = new System.Drawing.SizeF(146.1321F, 33.86207F);
            this.xrLabel35.StylePriority.UseFont = false;
            this.xrLabel35.StylePriority.UseTextAlignment = false;
            this.xrLabel35.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopCenter;
            // 
            // xrLabel23
            // 
            this.xrLabel23.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Bold);
            this.xrLabel23.LocationFloat = new DevExpress.Utils.PointFloat(382.2415F, 33.86207F);
            this.xrLabel23.Multiline = true;
            this.xrLabel23.Name = "xrLabel23";
            this.xrLabel23.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabel23.SizeF = new System.Drawing.SizeF(149.4023F, 33.86207F);
            this.xrLabel23.StylePriority.UseFont = false;
            this.xrLabel23.StylePriority.UseTextAlignment = false;
            this.xrLabel23.Text = "للعام الدراسي";
            this.xrLabel23.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopCenter;
            // 
            // xrLabel11
            // 
            this.xrLabel11.ExpressionBindings.AddRange(new DevExpress.XtraReports.UI.ExpressionBinding[] {
            new DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "[reportnumber]")});
            this.xrLabel11.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Bold);
            this.xrLabel11.LocationFloat = new DevExpress.Utils.PointFloat(531.6438F, 33.86207F);
            this.xrLabel11.Multiline = true;
            this.xrLabel11.Name = "xrLabel11";
            this.xrLabel11.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabel11.SizeF = new System.Drawing.SizeF(90.78165F, 33.86207F);
            this.xrLabel11.StylePriority.UseFont = false;
            this.xrLabel11.StylePriority.UseTextAlignment = false;
            this.xrLabel11.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopCenter;
            // 
            // xrLabel8
            // 
            this.xrLabel8.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Bold);
            this.xrLabel8.LocationFloat = new DevExpress.Utils.PointFloat(622.4254F, 33.86207F);
            this.xrLabel8.Multiline = true;
            this.xrLabel8.Name = "xrLabel8";
            this.xrLabel8.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabel8.SizeF = new System.Drawing.SizeF(90.78165F, 33.86207F);
            this.xrLabel8.StylePriority.UseFont = false;
            this.xrLabel8.StylePriority.UseTextAlignment = false;
            this.xrLabel8.Text = "رقم ";
            this.xrLabel8.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopCenter;
            // 
            // xrLabel1
            // 
            this.xrLabel1.BackColor = System.Drawing.Color.Silver;
            this.xrLabel1.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Bold);
            this.xrLabel1.LocationFloat = new DevExpress.Utils.PointFloat(200.2759F, 0F);
            this.xrLabel1.Multiline = true;
            this.xrLabel1.Name = "xrLabel1";
            this.xrLabel1.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabel1.SizeF = new System.Drawing.SizeF(512.9311F, 33.86207F);
            this.xrLabel1.StylePriority.UseBackColor = false;
            this.xrLabel1.StylePriority.UseFont = false;
            this.xrLabel1.StylePriority.UseTextAlignment = false;
            this.xrLabel1.Text = "قرار حرمان من درجـة المجال الدراسي\r\n";
            this.xrLabel1.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopCenter;
            // 
            // xrLabel33
            // 
            this.xrLabel33.Font = new System.Drawing.Font("Times New Roman", 13.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.xrLabel33.LocationFloat = new DevExpress.Utils.PointFloat(404.7126F, 235.9138F);
            this.xrLabel33.Name = "xrLabel33";
            this.xrLabel33.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabel33.SizeF = new System.Drawing.SizeF(28.44827F, 22.99999F);
            this.xrLabel33.StylePriority.UseFont = false;
            this.xrLabel33.Text = "م";
            // 
            // xrLabel32
            // 
            this.xrLabel32.Font = new System.Drawing.Font("Times New Roman", 13.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.xrLabel32.LocationFloat = new DevExpress.Utils.PointFloat(524.9999F, 235.9138F);
            this.xrLabel32.Name = "xrLabel32";
            this.xrLabel32.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabel32.SizeF = new System.Drawing.SizeF(271.4027F, 23F);
            this.xrLabel32.StylePriority.UseFont = false;
            this.xrLabel32.Text = "- وبناء  على محضر سماع الأقوال  المؤرخ: ";
            // 
            // xrLabel31
            // 
            this.xrLabel31.Font = new System.Drawing.Font("Times New Roman", 13.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.xrLabel31.LocationFloat = new DevExpress.Utils.PointFloat(404.7126F, 197.1208F);
            this.xrLabel31.Name = "xrLabel31";
            this.xrLabel31.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabel31.SizeF = new System.Drawing.SizeF(28.44827F, 22.99999F);
            this.xrLabel31.StylePriority.UseFont = false;
            this.xrLabel31.Text = "م";
            // 
            // xrLabel29
            // 
            this.xrLabel29.Font = new System.Drawing.Font("Times New Roman", 13.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.xrLabel29.LocationFloat = new DevExpress.Utils.PointFloat(524.9999F, 197.1207F);
            this.xrLabel29.Name = "xrLabel29";
            this.xrLabel29.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabel29.SizeF = new System.Drawing.SizeF(271.4027F, 23.00002F);
            this.xrLabel29.StylePriority.UseFont = false;
            this.xrLabel29.Text = "- استنادا ً إلى محضر إثبات المخالفة المؤرخ :";
            // 
            // xrLabel28
            // 
            this.xrLabel28.Font = new System.Drawing.Font("Times New Roman", 13.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.xrLabel28.LocationFloat = new DevExpress.Utils.PointFloat(92.74039F, 157.1407F);
            this.xrLabel28.Name = "xrLabel28";
            this.xrLabel28.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabel28.SizeF = new System.Drawing.SizeF(28.44828F, 22.99999F);
            this.xrLabel28.StylePriority.UseFont = false;
            this.xrLabel28.Text = "م";
            // 
            // xrLabel21
            // 
            this.xrLabel21.Font = new System.Drawing.Font("Times New Roman", 13.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.xrLabel21.LocationFloat = new DevExpress.Utils.PointFloat(365.2472F, 157.1407F);
            this.xrLabel21.Name = "xrLabel21";
            this.xrLabel21.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabel21.SizeF = new System.Drawing.SizeF(93.09778F, 22.99998F);
            this.xrLabel21.StylePriority.UseFont = false;
            this.xrLabel21.Text = " الذي عقد يوم: ";
            // 
            // xrLabel19
            // 
            this.xrLabel19.Font = new System.Drawing.Font("Times New Roman", 13.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.xrLabel19.LocationFloat = new DevExpress.Utils.PointFloat(735.5692F, 157.1407F);
            this.xrLabel19.Name = "xrLabel19";
            this.xrLabel19.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabel19.SizeF = new System.Drawing.SizeF(60.83337F, 22.99998F);
            this.xrLabel19.StylePriority.UseFont = false;
            this.xrLabel19.Text = "- في مادة ";
            // 
            // xrLabel18
            // 
            this.xrLabel18.ExpressionBindings.AddRange(new DevExpress.XtraReports.UI.ExpressionBinding[] {
            new DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "[SubjectDesc]")});
            this.xrLabel18.Font = new System.Drawing.Font("Times New Roman", 13.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.xrLabel18.LocationFloat = new DevExpress.Utils.PointFloat(469.6784F, 157.1407F);
            this.xrLabel18.Name = "xrLabel18";
            this.xrLabel18.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabel18.SizeF = new System.Drawing.SizeF(265.8909F, 22.99998F);
            this.xrLabel18.StylePriority.UseFont = false;
            this.xrLabel18.Text = "xrLabel8";
            // 
            // xrLabel17
            // 
            this.xrLabel17.ExpressionBindings.AddRange(new DevExpress.XtraReports.UI.ExpressionBinding[] {
            new DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "[CityDesc]")});
            this.xrLabel17.Font = new System.Drawing.Font("Times New Roman", 13.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.xrLabel17.LocationFloat = new DevExpress.Utils.PointFloat(10F, 123.7959F);
            this.xrLabel17.Name = "xrLabel17";
            this.xrLabel17.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabel17.SizeF = new System.Drawing.SizeF(274.16F, 22.99998F);
            this.xrLabel17.StylePriority.UseFont = false;
            this.xrLabel17.Text = "xrLabel8";
            // 
            // xrLabel16
            // 
            this.xrLabel16.ExpressionBindings.AddRange(new DevExpress.XtraReports.UI.ExpressionBinding[] {
            new DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "[LjnaDesc]")});
            this.xrLabel16.Font = new System.Drawing.Font("Times New Roman", 13.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.xrLabel16.LocationFloat = new DevExpress.Utils.PointFloat(341.3102F, 123.7959F);
            this.xrLabel16.Name = "xrLabel16";
            this.xrLabel16.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabel16.SizeF = new System.Drawing.SizeF(230.0345F, 22.99999F);
            this.xrLabel16.StylePriority.UseFont = false;
            this.xrLabel16.Text = "xrLabel8";
            // 
            // xrLabel26
            // 
            this.xrLabel26.Font = new System.Drawing.Font("Times New Roman", 13.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.xrLabel26.LocationFloat = new DevExpress.Utils.PointFloat(571.3447F, 123.7959F);
            this.xrLabel26.Name = "xrLabel26";
            this.xrLabel26.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabel26.SizeF = new System.Drawing.SizeF(227.7013F, 22.99995F);
            this.xrLabel26.StylePriority.UseFont = false;
            this.xrLabel26.Text = "- والذي يمتحن في لجنة سير امتحان : ";
            // 
            // xrLabel25
            // 
            this.xrLabel25.Font = new System.Drawing.Font("Times New Roman", 13.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.xrLabel25.LocationFloat = new DevExpress.Utils.PointFloat(72.95307F, 89.03448F);
            this.xrLabel25.Name = "xrLabel25";
            this.xrLabel25.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabel25.SizeF = new System.Drawing.SizeF(196.8735F, 22.99999F);
            this.xrLabel25.StylePriority.UseFont = false;
            this.xrLabel25.Text = " الصف : الثاني عشر";
            // 
            // xrLabel13
            // 
            this.xrLabel13.ExpressionBindings.AddRange(new DevExpress.XtraReports.UI.ExpressionBinding[] {
            new DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "[SchoolDesc]")});
            this.xrLabel13.Font = new System.Drawing.Font("Times New Roman", 13.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.xrLabel13.LocationFloat = new DevExpress.Utils.PointFloat(344.0573F, 89.03448F);
            this.xrLabel13.Name = "xrLabel13";
            this.xrLabel13.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabel13.SizeF = new System.Drawing.SizeF(327.5863F, 22.99999F);
            this.xrLabel13.StylePriority.UseFont = false;
            this.xrLabel13.Text = " xrLabel8";
            // 
            // xrLabel24
            // 
            this.xrLabel24.Font = new System.Drawing.Font("Times New Roman", 13.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.xrLabel24.LocationFloat = new DevExpress.Utils.PointFloat(671.6437F, 89.03448F);
            this.xrLabel24.Name = "xrLabel24";
            this.xrLabel24.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabel24.SizeF = new System.Drawing.SizeF(126.3563F, 22.99999F);
            this.xrLabel24.StylePriority.UseFont = false;
            this.xrLabel24.Text = "- بمدرسة / مركــــز: ";
            // 
            // xrLabel22
            // 
            this.xrLabel22.Font = new System.Drawing.Font("Times New Roman", 13.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.xrLabel22.LocationFloat = new DevExpress.Utils.PointFloat(288.207F, 123.7959F);
            this.xrLabel22.Multiline = true;
            this.xrLabel22.Name = "xrLabel22";
            this.xrLabel22.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabel22.SizeF = new System.Drawing.SizeF(41.43665F, 22.99999F);
            this.xrLabel22.StylePriority.UseFont = false;
            this.xrLabel22.Text = "منطقة";
            // 
            // xrLabel20
            // 
            this.xrLabel20.ExpressionBindings.AddRange(new DevExpress.XtraReports.UI.ExpressionBinding[] {
            new DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "[ExamDate]")});
            this.xrLabel20.Font = new System.Drawing.Font("Times New Roman", 13.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.xrLabel20.LocationFloat = new DevExpress.Utils.PointFloat(121.1887F, 157.1407F);
            this.xrLabel20.Name = "xrLabel20";
            this.xrLabel20.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabel20.SizeF = new System.Drawing.SizeF(91.83911F, 22.99999F);
            this.xrLabel20.StylePriority.UseFont = false;
            this.xrLabel20.Text = "xrLabel8";
            this.xrLabel20.TextFormatString = "{0:yyyy/MM/dd}";
            // 
            // xrLabel12
            // 
            this.xrLabel12.Borders = ((DevExpress.XtraPrinting.BorderSide)((((DevExpress.XtraPrinting.BorderSide.Left | DevExpress.XtraPrinting.BorderSide.Top) 
            | DevExpress.XtraPrinting.BorderSide.Right) 
            | DevExpress.XtraPrinting.BorderSide.Bottom)));
            this.xrLabel12.ExpressionBindings.AddRange(new DevExpress.XtraReports.UI.ExpressionBinding[] {
            new DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "[reportDeatils]")});
            this.xrLabel12.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold);
            this.xrLabel12.LocationFloat = new DevExpress.Utils.PointFloat(34.40705F, 309.4943F);
            this.xrLabel12.Name = "xrLabel12";
            this.xrLabel12.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabel12.SizeF = new System.Drawing.SizeF(749.9091F, 120.6667F);
            this.xrLabel12.StylePriority.UseBorders = false;
            this.xrLabel12.StylePriority.UseFont = false;
            this.xrLabel12.Text = "xrLabel8";
            // 
            // xrLabel10
            // 
            this.xrLabel10.Font = new System.Drawing.Font("Times New Roman", 14F, System.Drawing.FontStyle.Bold);
            this.xrLabel10.LocationFloat = new DevExpress.Utils.PointFloat(50.83329F, 774.3331F);
            this.xrLabel10.Multiline = true;
            this.xrLabel10.Name = "xrLabel10";
            this.xrLabel10.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabel10.SizeF = new System.Drawing.SizeF(201.6667F, 18.49994F);
            this.xrLabel10.StylePriority.UseFont = false;
            this.xrLabel10.Text = "نائب رئيس عام الامتحان";
            // 
            // xrLabel9
            // 
            this.xrLabel9.Font = new System.Drawing.Font("Times New Roman", 14F, System.Drawing.FontStyle.Bold);
            this.xrLabel9.LocationFloat = new DevExpress.Utils.PointFloat(50.83333F, 743.3331F);
            this.xrLabel9.Multiline = true;
            this.xrLabel9.Name = "xrLabel9";
            this.xrLabel9.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabel9.SizeF = new System.Drawing.SizeF(201.6667F, 18.49994F);
            this.xrLabel9.StylePriority.UseFont = false;
            this.xrLabel9.Text = "يعتمد ،،،";
            // 
            // xrLabel7
            // 
            this.xrLabel7.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold);
            this.xrLabel7.LocationFloat = new DevExpress.Utils.PointFloat(581.6666F, 743.3331F);
            this.xrLabel7.Multiline = true;
            this.xrLabel7.Name = "xrLabel7";
            this.xrLabel7.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabel7.SizeF = new System.Drawing.SizeF(201.6667F, 121.8333F);
            this.xrLabel7.StylePriority.UseFont = false;
            this.xrLabel7.Text = " نسخة لكل من :\r\n رئيس عام الإمتحان .\r\n لجنة النظام والمراقبة .\r\n قسم الإمتحانات ب" +
    "إدارة التنسيق .\r\n الطالب.\r\n رئيس لجنة سير الإمتحان .\r\n الملف .";
            // 
            // xrLabel6
            // 
            this.xrLabel6.Font = new System.Drawing.Font("Times New Roman", 14F, System.Drawing.FontStyle.Bold);
            this.xrLabel6.LocationFloat = new DevExpress.Utils.PointFloat(9.999999F, 545.3332F);
            this.xrLabel6.Multiline = true;
            this.xrLabel6.Name = "xrLabel6";
            this.xrLabel6.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabel6.SizeF = new System.Drawing.SizeF(773.3333F, 182.9999F);
            this.xrLabel6.StylePriority.UseFont = false;
            this.xrLabel6.Text = resources.GetString("xrLabel6.Text");
            // 
            // xrLabel5
            // 
            this.xrLabel5.Font = new System.Drawing.Font("Times New Roman", 14F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))));
            this.xrLabel5.LocationFloat = new DevExpress.Utils.PointFloat(50.83329F, 522.3333F);
            this.xrLabel5.Multiline = true;
            this.xrLabel5.Name = "xrLabel5";
            this.xrLabel5.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabel5.SizeF = new System.Drawing.SizeF(732.5F, 22.99994F);
            this.xrLabel5.StylePriority.UseFont = false;
            this.xrLabel5.StylePriority.UseTextAlignment = false;
            this.xrLabel5.Text = " فقـــــــــــــــد تقـــــــــــــــــرر\r\n";
            this.xrLabel5.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopCenter;
            // 
            // xrLabel4
            // 
            this.xrLabel4.Font = new System.Drawing.Font("Times New Roman", 14F, System.Drawing.FontStyle.Bold);
            this.xrLabel4.LocationFloat = new DevExpress.Utils.PointFloat(9.999999F, 443.5F);
            this.xrLabel4.Multiline = true;
            this.xrLabel4.Name = "xrLabel4";
            this.xrLabel4.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabel4.SizeF = new System.Drawing.SizeF(773.3333F, 78.83322F);
            this.xrLabel4.StylePriority.UseFont = false;
            this.xrLabel4.Text = resources.GetString("xrLabel4.Text");
            // 
            // xrLabel2
            // 
            this.xrLabel2.Font = new System.Drawing.Font("Times New Roman", 13F, System.Drawing.FontStyle.Bold);
            this.xrLabel2.LocationFloat = new DevExpress.Utils.PointFloat(524.9999F, 284.8276F);
            this.xrLabel2.Multiline = true;
            this.xrLabel2.Name = "xrLabel2";
            this.xrLabel2.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabel2.SizeF = new System.Drawing.SizeF(258.3333F, 24.66666F);
            this.xrLabel2.StylePriority.UseFont = false;
            this.xrLabel2.Text = "والثابت بها الآتي :-  ";
            // 
            // TopMargin
            // 
            this.TopMargin.Controls.AddRange(new DevExpress.XtraReports.UI.XRControl[] {
            this.xrPictureBox1,
            this.xrLabel14,
            this.xrPictureBox2,
            this.xrLabel15});
            this.TopMargin.HeightF = 151.0124F;
            this.TopMargin.Name = "TopMargin";
            this.TopMargin.Padding = new DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100F);
            this.TopMargin.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft;
            // 
            // xrPictureBox1
            // 
            this.xrPictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("xrPictureBox1.Image")));
            this.xrPictureBox1.LocationFloat = new DevExpress.Utils.PointFloat(639.9722F, 2.987656F);
            this.xrPictureBox1.Name = "xrPictureBox1";
            this.xrPictureBox1.SizeF = new System.Drawing.SizeF(111.6667F, 80F);
            this.xrPictureBox1.Sizing = DevExpress.XtraPrinting.ImageSizeMode.StretchImage;
            // 
            // xrLabel14
            // 
            this.xrLabel14.Font = new System.Drawing.Font("Times New Roman", 11F, System.Drawing.FontStyle.Bold);
            this.xrLabel14.LocationFloat = new DevExpress.Utils.PointFloat(601.6389F, 91.01235F);
            this.xrLabel14.Multiline = true;
            this.xrLabel14.Name = "xrLabel14";
            this.xrLabel14.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabel14.SizeF = new System.Drawing.SizeF(150F, 60F);
            this.xrLabel14.StylePriority.UseFont = false;
            this.xrLabel14.StylePriority.UseTextAlignment = false;
            this.xrLabel14.Text = "وزارة التربية\r\nلجنة النظام والمراقبة \r\nكنترول الصف الثاني عشر ";
            this.xrLabel14.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopCenter;
            // 
            // xrPictureBox2
            // 
            this.xrPictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("xrPictureBox2.Image")));
            this.xrPictureBox2.LocationFloat = new DevExpress.Utils.PointFloat(80.52771F, 2.987656F);
            this.xrPictureBox2.Name = "xrPictureBox2";
            this.xrPictureBox2.SizeF = new System.Drawing.SizeF(111.6667F, 80F);
            this.xrPictureBox2.Sizing = DevExpress.XtraPrinting.ImageSizeMode.StretchImage;
            // 
            // xrLabel15
            // 
            this.xrLabel15.Font = new System.Drawing.Font("Times New Roman", 11F, System.Drawing.FontStyle.Bold);
            this.xrLabel15.LocationFloat = new DevExpress.Utils.PointFloat(56.36105F, 91.01235F);
            this.xrLabel15.Multiline = true;
            this.xrLabel15.Name = "xrLabel15";
            this.xrLabel15.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabel15.SizeF = new System.Drawing.SizeF(156.6667F, 50.00001F);
            this.xrLabel15.StylePriority.UseFont = false;
            this.xrLabel15.StylePriority.UseTextAlignment = false;
            this.xrLabel15.Text = "القسم الأدبي والمعهد الديني\r\nالفترة الدراسية الثانية ";
            this.xrLabel15.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopCenter;
            // 
            // BottomMargin
            // 
            this.BottomMargin.HeightF = 5F;
            this.BottomMargin.Name = "BottomMargin";
            this.BottomMargin.Padding = new DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100F);
            this.BottomMargin.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft;
            // 
            // sqlDataSource1
            // 
            this.sqlDataSource1.ConnectionName = "DefaultConnection";
            this.sqlDataSource1.Name = "sqlDataSource1";
            columnExpression1.ColumnName = "ID";
            table1.Name = "Herman";
            columnExpression1.Table = table1;
            column1.Expression = columnExpression1;
            columnExpression2.ColumnName = "seatNO";
            columnExpression2.Table = table1;
            column2.Expression = columnExpression2;
            columnExpression3.ColumnName = "examId";
            columnExpression3.Table = table1;
            column3.Expression = columnExpression3;
            columnExpression4.ColumnName = "reportDeatils";
            columnExpression4.Table = table1;
            column4.Expression = columnExpression4;
            columnExpression5.ColumnName = "fromDesc";
            columnExpression5.Table = table1;
            column5.Expression = columnExpression5;
            columnExpression6.ColumnName = "SubjectId";
            columnExpression6.Table = table1;
            column6.Expression = columnExpression6;
            columnExpression7.ColumnName = "hermanType";
            columnExpression7.Table = table1;
            column7.Expression = columnExpression7;
            selectQuery1.Columns.Add(column1);
            selectQuery1.Columns.Add(column2);
            selectQuery1.Columns.Add(column3);
            selectQuery1.Columns.Add(column4);
            selectQuery1.Columns.Add(column5);
            selectQuery1.Columns.Add(column6);
            selectQuery1.Columns.Add(column7);
            selectQuery1.MetaSerializable = "<Meta X=\"20\" Y=\"20\" Width=\"100\" Height=\"208\" />";
            selectQuery1.Name = "Herman";
            selectQuery1.Tables.Add(table1);
            columnExpression8.ColumnName = "full_name";
            table2.Name = "Student";
            columnExpression8.Table = table2;
            column8.Expression = columnExpression8;
            columnExpression9.ColumnName = "Seat";
            columnExpression9.Table = table2;
            column9.Expression = columnExpression9;
            columnExpression10.ColumnName = "Div";
            columnExpression10.Table = table2;
            column10.Expression = columnExpression10;
            columnExpression11.ColumnName = "cid";
            columnExpression11.Table = table2;
            column11.Expression = columnExpression11;
            columnExpression12.ColumnName = "School";
            columnExpression12.Table = table2;
            column12.Expression = columnExpression12;
            columnExpression13.ColumnName = "StType";
            columnExpression13.Table = table2;
            column13.Expression = columnExpression13;
            columnExpression14.ColumnName = "LjnaNum";
            columnExpression14.Table = table2;
            column14.Expression = columnExpression14;
            columnExpression15.ColumnName = "Sex";
            columnExpression15.Table = table2;
            column15.Expression = columnExpression15;
            selectQuery2.Columns.Add(column8);
            selectQuery2.Columns.Add(column9);
            selectQuery2.Columns.Add(column10);
            selectQuery2.Columns.Add(column11);
            selectQuery2.Columns.Add(column12);
            selectQuery2.Columns.Add(column13);
            selectQuery2.Columns.Add(column14);
            selectQuery2.Columns.Add(column15);
            selectQuery2.MetaSerializable = "<Meta X=\"140\" Y=\"20\" Width=\"100\" Height=\"231\" />";
            selectQuery2.Name = "Student";
            selectQuery2.Tables.Add(table2);
            columnExpression16.ColumnName = "SubjectId";
            table3.Name = "Subject";
            columnExpression16.Table = table3;
            column16.Expression = columnExpression16;
            columnExpression17.ColumnName = "SubjectDesc";
            columnExpression17.Table = table3;
            column17.Expression = columnExpression17;
            columnExpression18.ColumnName = "SubjectDescShort";
            columnExpression18.Table = table3;
            column18.Expression = columnExpression18;
            columnExpression19.ColumnName = "SubjectCode";
            columnExpression19.Table = table3;
            column19.Expression = columnExpression19;
            selectQuery3.Columns.Add(column16);
            selectQuery3.Columns.Add(column17);
            selectQuery3.Columns.Add(column18);
            selectQuery3.Columns.Add(column19);
            selectQuery3.MetaSerializable = "<Meta X=\"260\" Y=\"20\" Width=\"100\" Height=\"139\" />";
            selectQuery3.Name = "Subject";
            selectQuery3.Tables.Add(table3);
            columnExpression20.ColumnName = "ExamId";
            table4.Name = "Exam";
            columnExpression20.Table = table4;
            column20.Expression = columnExpression20;
            columnExpression21.ColumnName = "SubjectId";
            columnExpression21.Table = table4;
            column21.Expression = columnExpression21;
            columnExpression22.ColumnName = "Div";
            columnExpression22.Table = table4;
            column22.Expression = columnExpression22;
            columnExpression23.ColumnName = "ExamTypeId";
            columnExpression23.Table = table4;
            column23.Expression = columnExpression23;
            columnExpression24.ColumnName = "ExamDate";
            columnExpression24.Table = table4;
            column24.Expression = columnExpression24;
            columnExpression25.ColumnName = "StartTime";
            columnExpression25.Table = table4;
            column25.Expression = columnExpression25;
            columnExpression26.ColumnName = "EndTime";
            columnExpression26.Table = table4;
            column26.Expression = columnExpression26;
            selectQuery4.Columns.Add(column20);
            selectQuery4.Columns.Add(column21);
            selectQuery4.Columns.Add(column22);
            selectQuery4.Columns.Add(column23);
            selectQuery4.Columns.Add(column24);
            selectQuery4.Columns.Add(column25);
            selectQuery4.Columns.Add(column26);
            selectQuery4.MetaSerializable = "<Meta X=\"380\" Y=\"20\" Width=\"100\" Height=\"208\" />";
            selectQuery4.Name = "Exam";
            selectQuery4.Tables.Add(table4);
            columnExpression27.ColumnName = "DivisionId";
            table5.Name = "Division";
            columnExpression27.Table = table5;
            column27.Expression = columnExpression27;
            columnExpression28.ColumnName = "DivisionDesc";
            columnExpression28.Table = table5;
            column28.Expression = columnExpression28;
            selectQuery5.Columns.Add(column27);
            selectQuery5.Columns.Add(column28);
            selectQuery5.MetaSerializable = "<Meta X=\"500\" Y=\"20\" Width=\"100\" Height=\"93\" />";
            selectQuery5.Name = "Division";
            selectQuery5.Tables.Add(table5);
            columnExpression29.ColumnName = "SchoolDesc";
            table6.Name = "School";
            columnExpression29.Table = table6;
            column29.Expression = columnExpression29;
            columnExpression30.ColumnName = "CityID";
            columnExpression30.Table = table6;
            column30.Expression = columnExpression30;
            columnExpression31.ColumnName = "SchoolCode";
            columnExpression31.Table = table6;
            column31.Expression = columnExpression31;
            columnExpression32.ColumnName = "SexId";
            columnExpression32.Table = table6;
            column32.Expression = columnExpression32;
            columnExpression33.ColumnName = "StType";
            columnExpression33.Table = table6;
            column33.Expression = columnExpression33;
            selectQuery6.Columns.Add(column29);
            selectQuery6.Columns.Add(column30);
            selectQuery6.Columns.Add(column31);
            selectQuery6.Columns.Add(column32);
            selectQuery6.Columns.Add(column33);
            selectQuery6.MetaSerializable = "<Meta X=\"620\" Y=\"20\" Width=\"100\" Height=\"162\" />";
            selectQuery6.Name = "School";
            selectQuery6.Tables.Add(table6);
            columnExpression34.ColumnName = "LjnaNum";
            table7.Name = "Ljna";
            columnExpression34.Table = table7;
            column34.Expression = columnExpression34;
            columnExpression35.ColumnName = "LjnaDesc";
            columnExpression35.Table = table7;
            column35.Expression = columnExpression35;
            columnExpression36.ColumnName = "CityId";
            columnExpression36.Table = table7;
            column36.Expression = columnExpression36;
            columnExpression37.ColumnName = "LjnaCode";
            columnExpression37.Table = table7;
            column37.Expression = columnExpression37;
            columnExpression38.ColumnName = "Filled";
            columnExpression38.Table = table7;
            column38.Expression = columnExpression38;
            columnExpression39.ColumnName = "ManagerName";
            columnExpression39.Table = table7;
            column39.Expression = columnExpression39;
            columnExpression40.ColumnName = "ManagerHome";
            columnExpression40.Table = table7;
            column40.Expression = columnExpression40;
            columnExpression41.ColumnName = "ManagerMobile";
            columnExpression41.Table = table7;
            column41.Expression = columnExpression41;
            columnExpression42.ColumnName = "ManagerSchool";
            columnExpression42.Table = table7;
            column42.Expression = columnExpression42;
            columnExpression43.ColumnName = "ManagerWorkPhone";
            columnExpression43.Table = table7;
            column43.Expression = columnExpression43;
            selectQuery7.Columns.Add(column34);
            selectQuery7.Columns.Add(column35);
            selectQuery7.Columns.Add(column36);
            selectQuery7.Columns.Add(column37);
            selectQuery7.Columns.Add(column38);
            selectQuery7.Columns.Add(column39);
            selectQuery7.Columns.Add(column40);
            selectQuery7.Columns.Add(column41);
            selectQuery7.Columns.Add(column42);
            selectQuery7.Columns.Add(column43);
            selectQuery7.MetaSerializable = "<Meta X=\"740\" Y=\"20\" Width=\"100\" Height=\"277\" />";
            selectQuery7.Name = "Ljna";
            selectQuery7.Tables.Add(table7);
            columnExpression44.ColumnName = "CityId";
            table8.Name = "City";
            columnExpression44.Table = table8;
            column44.Expression = columnExpression44;
            columnExpression45.ColumnName = "CityDesc";
            columnExpression45.Table = table8;
            column45.Expression = columnExpression45;
            columnExpression46.ColumnName = "CityShortDesc";
            columnExpression46.Table = table8;
            column46.Expression = columnExpression46;
            columnExpression47.ColumnName = "CityCode";
            columnExpression47.Table = table8;
            column47.Expression = columnExpression47;
            selectQuery8.Columns.Add(column44);
            selectQuery8.Columns.Add(column45);
            selectQuery8.Columns.Add(column46);
            selectQuery8.Columns.Add(column47);
            selectQuery8.MetaSerializable = "<Meta X=\"860\" Y=\"20\" Width=\"100\" Height=\"139\" />";
            selectQuery8.Name = "City";
            selectQuery8.Tables.Add(table8);
            this.sqlDataSource1.Queries.AddRange(new DevExpress.DataAccess.Sql.SqlQuery[] {
            selectQuery1,
            selectQuery2,
            selectQuery3,
            selectQuery4,
            selectQuery5,
            selectQuery6,
            selectQuery7,
            selectQuery8});
            masterDetailInfo1.DetailQueryName = "Student";
            relationColumnInfo1.NestedKeyColumn = "Seat";
            relationColumnInfo1.ParentKeyColumn = "seatNO";
            masterDetailInfo1.KeyColumns.Add(relationColumnInfo1);
            masterDetailInfo1.MasterQueryName = "Herman";
            masterDetailInfo2.DetailQueryName = "Subject";
            relationColumnInfo2.NestedKeyColumn = "SubjectId";
            relationColumnInfo2.ParentKeyColumn = "SubjectId";
            masterDetailInfo2.KeyColumns.Add(relationColumnInfo2);
            masterDetailInfo2.MasterQueryName = "Herman";
            masterDetailInfo3.DetailQueryName = "Exam";
            relationColumnInfo3.NestedKeyColumn = "ExamId";
            relationColumnInfo3.ParentKeyColumn = "examId";
            masterDetailInfo3.KeyColumns.Add(relationColumnInfo3);
            masterDetailInfo3.MasterQueryName = "Herman";
            masterDetailInfo4.DetailQueryName = "Division";
            relationColumnInfo4.NestedKeyColumn = "DivisionId";
            relationColumnInfo4.ParentKeyColumn = "Div";
            masterDetailInfo4.KeyColumns.Add(relationColumnInfo4);
            masterDetailInfo4.MasterQueryName = "Student";
            masterDetailInfo5.DetailQueryName = "City";
            relationColumnInfo5.NestedKeyColumn = "CityId";
            relationColumnInfo5.ParentKeyColumn = "CityID";
            masterDetailInfo5.KeyColumns.Add(relationColumnInfo5);
            masterDetailInfo5.MasterQueryName = "School";
            masterDetailInfo6.DetailQueryName = "School";
            relationColumnInfo6.NestedKeyColumn = "SchoolCode";
            relationColumnInfo6.ParentKeyColumn = "School";
            masterDetailInfo6.KeyColumns.Add(relationColumnInfo6);
            masterDetailInfo6.MasterQueryName = "Student";
            this.sqlDataSource1.Relations.AddRange(new DevExpress.DataAccess.Sql.MasterDetailInfo[] {
            masterDetailInfo1,
            masterDetailInfo2,
            masterDetailInfo3,
            masterDetailInfo4,
            masterDetailInfo5,
            masterDetailInfo6});
            this.sqlDataSource1.ResultSchemaSerializable = resources.GetString("sqlDataSource1.ResultSchemaSerializable");
            // 
            // sqlDataSource2
            // 
            this.sqlDataSource2.ConnectionName = "DefaultConnection";
            this.sqlDataSource2.Name = "sqlDataSource2";
            columnExpression48.ColumnName = "CityDesc";
            table9.Name = "ViewStudentDetail";
            columnExpression48.Table = table9;
            column48.Expression = columnExpression48;
            columnExpression49.ColumnName = "CityShortDesc";
            columnExpression49.Table = table9;
            column49.Expression = columnExpression49;
            columnExpression50.ColumnName = "CityCode";
            columnExpression50.Table = table9;
            column50.Expression = columnExpression50;
            columnExpression51.ColumnName = "LjnaNum";
            columnExpression51.Table = table9;
            column51.Expression = columnExpression51;
            columnExpression52.ColumnName = "LjnaDesc";
            columnExpression52.Table = table9;
            column52.Expression = columnExpression52;
            columnExpression53.ColumnName = "CityId";
            columnExpression53.Table = table9;
            column53.Expression = columnExpression53;
            columnExpression54.ColumnName = "LjnaCode";
            columnExpression54.Table = table9;
            column54.Expression = columnExpression54;
            columnExpression55.ColumnName = "Filled";
            columnExpression55.Table = table9;
            column55.Expression = columnExpression55;
            columnExpression56.ColumnName = "ManagerName";
            columnExpression56.Table = table9;
            column56.Expression = columnExpression56;
            columnExpression57.ColumnName = "ManagerHome";
            columnExpression57.Table = table9;
            column57.Expression = columnExpression57;
            columnExpression58.ColumnName = "ManagerMobile";
            columnExpression58.Table = table9;
            column58.Expression = columnExpression58;
            columnExpression59.ColumnName = "ManagerSchool";
            columnExpression59.Table = table9;
            column59.Expression = columnExpression59;
            columnExpression60.ColumnName = "ManagerWorkPhone";
            columnExpression60.Table = table9;
            column60.Expression = columnExpression60;
            columnExpression61.ColumnName = "full_name";
            columnExpression61.Table = table9;
            column61.Expression = columnExpression61;
            columnExpression62.ColumnName = "Seat";
            columnExpression62.Table = table9;
            column62.Expression = columnExpression62;
            columnExpression63.ColumnName = "Div";
            columnExpression63.Table = table9;
            column63.Expression = columnExpression63;
            columnExpression64.ColumnName = "cid";
            columnExpression64.Table = table9;
            column64.Expression = columnExpression64;
            columnExpression65.ColumnName = "School";
            columnExpression65.Table = table9;
            column65.Expression = columnExpression65;
            columnExpression66.ColumnName = "Sex";
            columnExpression66.Table = table9;
            column66.Expression = columnExpression66;
            columnExpression67.ColumnName = "SexDesc";
            columnExpression67.Table = table9;
            column67.Expression = columnExpression67;
            columnExpression68.ColumnName = "St_TypeDesc";
            columnExpression68.Table = table9;
            column68.Expression = columnExpression68;
            columnExpression69.ColumnName = "St_TypeId";
            columnExpression69.Table = table9;
            column69.Expression = columnExpression69;
            columnExpression70.ColumnName = "StType";
            columnExpression70.Table = table9;
            column70.Expression = columnExpression70;
            columnExpression71.ColumnName = "SchoolDesc";
            columnExpression71.Table = table9;
            column71.Expression = columnExpression71;
            columnExpression72.ColumnName = "SchoolCityShort";
            columnExpression72.Table = table9;
            column72.Expression = columnExpression72;
            columnExpression73.ColumnName = "SchoolCity";
            columnExpression73.Table = table9;
            column73.Expression = columnExpression73;
            selectQuery9.Columns.Add(column48);
            selectQuery9.Columns.Add(column49);
            selectQuery9.Columns.Add(column50);
            selectQuery9.Columns.Add(column51);
            selectQuery9.Columns.Add(column52);
            selectQuery9.Columns.Add(column53);
            selectQuery9.Columns.Add(column54);
            selectQuery9.Columns.Add(column55);
            selectQuery9.Columns.Add(column56);
            selectQuery9.Columns.Add(column57);
            selectQuery9.Columns.Add(column58);
            selectQuery9.Columns.Add(column59);
            selectQuery9.Columns.Add(column60);
            selectQuery9.Columns.Add(column61);
            selectQuery9.Columns.Add(column62);
            selectQuery9.Columns.Add(column63);
            selectQuery9.Columns.Add(column64);
            selectQuery9.Columns.Add(column65);
            selectQuery9.Columns.Add(column66);
            selectQuery9.Columns.Add(column67);
            selectQuery9.Columns.Add(column68);
            selectQuery9.Columns.Add(column69);
            selectQuery9.Columns.Add(column70);
            selectQuery9.Columns.Add(column71);
            selectQuery9.Columns.Add(column72);
            selectQuery9.Columns.Add(column73);
            selectQuery9.MetaSerializable = "<Meta X=\"20\" Y=\"20\" Width=\"100\" Height=\"645\" />";
            selectQuery9.Name = "ViewStudentDetail";
            selectQuery9.Tables.Add(table9);
            columnExpression74.ColumnName = "DivisionDesc";
            table10.Name = "ViewExamDetail";
            columnExpression74.Table = table10;
            column74.Expression = columnExpression74;
            columnExpression75.ColumnName = "SubjectDesc";
            columnExpression75.Table = table10;
            column75.Expression = columnExpression75;
            columnExpression76.ColumnName = "SubjectDescShort";
            columnExpression76.Table = table10;
            column76.Expression = columnExpression76;
            columnExpression77.ColumnName = "Div";
            columnExpression77.Table = table10;
            column77.Expression = columnExpression77;
            columnExpression78.ColumnName = "ExamId";
            columnExpression78.Table = table10;
            column78.Expression = columnExpression78;
            columnExpression79.ColumnName = "ExamDate";
            columnExpression79.Table = table10;
            column79.Expression = columnExpression79;
            selectQuery10.Columns.Add(column74);
            selectQuery10.Columns.Add(column75);
            selectQuery10.Columns.Add(column76);
            selectQuery10.Columns.Add(column77);
            selectQuery10.Columns.Add(column78);
            selectQuery10.Columns.Add(column79);
            selectQuery10.MetaSerializable = "<Meta X=\"140\" Y=\"20\" Width=\"100\" Height=\"185\" />";
            selectQuery10.Name = "ViewExamDetail";
            selectQuery10.Tables.Add(table10);
            columnExpression80.ColumnName = "ID";
            table11.Name = "Herman";
            columnExpression80.Table = table11;
            column80.Expression = columnExpression80;
            columnExpression81.ColumnName = "seatNO";
            columnExpression81.Table = table11;
            column81.Expression = columnExpression81;
            columnExpression82.ColumnName = "examId";
            columnExpression82.Table = table11;
            column82.Expression = columnExpression82;
            columnExpression83.ColumnName = "reportDeatils";
            columnExpression83.Table = table11;
            column83.Expression = columnExpression83;
            columnExpression84.ColumnName = "fromDesc";
            columnExpression84.Table = table11;
            column84.Expression = columnExpression84;
            columnExpression85.ColumnName = "SubjectId";
            columnExpression85.Table = table11;
            column85.Expression = columnExpression85;
            columnExpression86.ColumnName = "hermanType";
            columnExpression86.Table = table11;
            column86.Expression = columnExpression86;
            selectQuery11.Columns.Add(column80);
            selectQuery11.Columns.Add(column81);
            selectQuery11.Columns.Add(column82);
            selectQuery11.Columns.Add(column83);
            selectQuery11.Columns.Add(column84);
            selectQuery11.Columns.Add(column85);
            selectQuery11.Columns.Add(column86);
            selectQuery11.MetaSerializable = "<Meta X=\"260\" Y=\"20\" Width=\"100\" Height=\"208\" />";
            selectQuery11.Name = "Herman";
            selectQuery11.Tables.Add(table11);
            this.sqlDataSource2.Queries.AddRange(new DevExpress.DataAccess.Sql.SqlQuery[] {
            selectQuery9,
            selectQuery10,
            selectQuery11});
            masterDetailInfo7.DetailQueryName = "ViewStudentDetail";
            relationColumnInfo7.NestedKeyColumn = "Seat";
            relationColumnInfo7.ParentKeyColumn = "seatNO";
            masterDetailInfo7.KeyColumns.Add(relationColumnInfo7);
            masterDetailInfo7.MasterQueryName = "Herman";
            masterDetailInfo8.DetailQueryName = "ViewExamDetail";
            relationColumnInfo8.NestedKeyColumn = "ExamId";
            relationColumnInfo8.ParentKeyColumn = "examId";
            masterDetailInfo8.KeyColumns.Add(relationColumnInfo8);
            masterDetailInfo8.MasterQueryName = "Herman";
            this.sqlDataSource2.Relations.AddRange(new DevExpress.DataAccess.Sql.MasterDetailInfo[] {
            masterDetailInfo7,
            masterDetailInfo8});
            this.sqlDataSource2.ResultSchemaSerializable = resources.GetString("sqlDataSource2.ResultSchemaSerializable");
            // 
            // sqlDataSource3
            // 
            this.sqlDataSource3.ConnectionName = "DefaultConnection";
            this.sqlDataSource3.Name = "sqlDataSource3";
            storedProcQuery1.Name = "Mot";
            queryParameter1.Name = "@ExamId";
            queryParameter1.Type = typeof(int);
            queryParameter1.ValueInfo = "1";
            queryParameter2.Name = "@St";
            queryParameter2.Type = typeof(int);
            queryParameter2.ValueInfo = "32275";
            storedProcQuery1.Parameters.Add(queryParameter1);
            storedProcQuery1.Parameters.Add(queryParameter2);
            storedProcQuery1.StoredProcName = "Mot";
            this.sqlDataSource3.Queries.AddRange(new DevExpress.DataAccess.Sql.SqlQuery[] {
            storedProcQuery1});
            this.sqlDataSource3.ResultSchemaSerializable = resources.GetString("sqlDataSource3.ResultSchemaSerializable");
            // 
            // seatno
            // 
            this.seatno.Name = "seatno";
            this.seatno.Type = typeof(int);
            this.seatno.ValueInfo = "0";
            this.seatno.Visible = false;
            // 
            // examId
            // 
            this.examId.Name = "examId";
            this.examId.Type = typeof(int);
            this.examId.ValueInfo = "0";
            this.examId.Visible = false;
            // 
            // sqlDataSource4
            // 
            this.sqlDataSource4.ConnectionName = "DefaultConnection";
            this.sqlDataSource4.Name = "sqlDataSource4";
            storedProcQuery2.Name = "Mot";
            queryParameter3.Name = "@ExamId";
            queryParameter3.Type = typeof(DevExpress.DataAccess.Expression);
            queryParameter3.Value = new DevExpress.DataAccess.Expression("[Parameters.examId]", typeof(string));
            queryParameter4.Name = "@St";
            queryParameter4.Type = typeof(DevExpress.DataAccess.Expression);
            queryParameter4.Value = new DevExpress.DataAccess.Expression("[Parameters.seatno]", typeof(string));
            storedProcQuery2.Parameters.Add(queryParameter3);
            storedProcQuery2.Parameters.Add(queryParameter4);
            storedProcQuery2.StoredProcName = "Mot";
            this.sqlDataSource4.Queries.AddRange(new DevExpress.DataAccess.Sql.SqlQuery[] {
            storedProcQuery2});
            this.sqlDataSource4.ResultSchemaSerializable = resources.GetString("sqlDataSource4.ResultSchemaSerializable");
            // 
            // sqlDataSource5
            // 
            this.sqlDataSource5.ConnectionName = "DefaultConnection";
            this.sqlDataSource5.Name = "sqlDataSource5";
            storedProcQuery3.Name = "Mot";
            queryParameter5.Name = "@ExamId";
            queryParameter5.Type = typeof(DevExpress.DataAccess.Expression);
            queryParameter5.Value = new DevExpress.DataAccess.Expression("[Parameters.examId]", typeof(string));
            queryParameter6.Name = "@St";
            queryParameter6.Type = typeof(DevExpress.DataAccess.Expression);
            queryParameter6.Value = new DevExpress.DataAccess.Expression("[Parameters.seatno]", typeof(string));
            storedProcQuery3.Parameters.Add(queryParameter5);
            storedProcQuery3.Parameters.Add(queryParameter6);
            storedProcQuery3.StoredProcName = "Mot";
            this.sqlDataSource5.Queries.AddRange(new DevExpress.DataAccess.Sql.SqlQuery[] {
            storedProcQuery3});
            this.sqlDataSource5.ResultSchemaSerializable = resources.GetString("sqlDataSource5.ResultSchemaSerializable");
            // 
            // sqlDataSource6
            // 
            this.sqlDataSource6.ConnectionName = "DefaultConnection";
            this.sqlDataSource6.Name = "sqlDataSource6";
            storedProcQuery4.Name = "Mot";
            queryParameter7.Name = "@ExamId";
            queryParameter7.Type = typeof(int);
            queryParameter7.ValueInfo = "0";
            queryParameter8.Name = "@St";
            queryParameter8.Type = typeof(int);
            queryParameter8.ValueInfo = "0";
            storedProcQuery4.Parameters.Add(queryParameter7);
            storedProcQuery4.Parameters.Add(queryParameter8);
            storedProcQuery4.StoredProcName = "Mot";
            this.sqlDataSource6.Queries.AddRange(new DevExpress.DataAccess.Sql.SqlQuery[] {
            storedProcQuery4});
            this.sqlDataSource6.ResultSchemaSerializable = resources.GetString("sqlDataSource6.ResultSchemaSerializable");
            // 
            // sqlDataSource7
            // 
            this.sqlDataSource7.ConnectionName = "DefaultConnection";
            this.sqlDataSource7.Name = "sqlDataSource7";
            storedProcQuery5.Name = "Mot";
            queryParameter9.Name = "@ExamId";
            queryParameter9.Type = typeof(DevExpress.DataAccess.Expression);
            queryParameter9.Value = new DevExpress.DataAccess.Expression("[Parameters.examId]", typeof(int));
            queryParameter10.Name = "@St";
            queryParameter10.Type = typeof(DevExpress.DataAccess.Expression);
            queryParameter10.Value = new DevExpress.DataAccess.Expression("[Parameters.seatno]", typeof(int));
            storedProcQuery5.Parameters.Add(queryParameter9);
            storedProcQuery5.Parameters.Add(queryParameter10);
            storedProcQuery5.StoredProcName = "Mot";
            this.sqlDataSource7.Queries.AddRange(new DevExpress.DataAccess.Sql.SqlQuery[] {
            storedProcQuery5});
            this.sqlDataSource7.ResultSchemaSerializable = resources.GetString("sqlDataSource7.ResultSchemaSerializable");
            // 
            // year
            // 
            this.year.Name = "year";
            this.year.Visible = false;
            // 
            // day
            // 
            this.day.Name = "day";
            this.day.Visible = false;
            // 
            // XtraReport2
            // 
            this.Bands.AddRange(new DevExpress.XtraReports.UI.Band[] {
            this.Detail,
            this.TopMargin,
            this.BottomMargin});
            this.ComponentStorage.AddRange(new System.ComponentModel.IComponent[] {
            this.sqlDataSource1,
            this.sqlDataSource2,
            this.sqlDataSource3,
            this.sqlDataSource4,
            this.sqlDataSource5,
            this.sqlDataSource6,
            this.sqlDataSource7});
            this.DataMember = "Mot";
            this.DataSource = this.sqlDataSource7;
            this.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margins = new System.Drawing.Printing.Margins(20, 14, 151, 5);
            this.Parameters.AddRange(new DevExpress.XtraReports.Parameters.Parameter[] {
            this.seatno,
            this.examId,
            this.year,
            this.day});
            this.RightToLeft = DevExpress.XtraReports.UI.RightToLeft.Yes;
            this.Version = "17.2";
            ((System.ComponentModel.ISupportInitialize)(this)).EndInit();

    }

    #endregion
}
