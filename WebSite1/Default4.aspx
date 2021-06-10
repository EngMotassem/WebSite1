<%@ Page Title="" Language="C#" MasterPageFile="~/Site.master" AutoEventWireup="true" CodeFile="Default4.aspx.cs" Inherits="Default4" %>

<%@ Register Assembly="DevExpress.XtraReports.v17.2.Web, Version=17.2.4.0, Culture=neutral, PublicKeyToken=b88d1754d700e49a" Namespace="DevExpress.XtraReports.Web" TagPrefix="dx" %>

<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" Runat="Server">
    <dx:ASPxDocumentViewer ID="ASPxDocumentViewer1" runat="server" Height="1100px" ReportTypeName="XtraReport1" Theme="iOS" Width="100%">

    </dx:ASPxDocumentViewer>

</asp:Content>

