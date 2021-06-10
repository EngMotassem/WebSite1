<%@ Page Title="" Language="C#" MasterPageFile="~/Site.master" AutoEventWireup="true" CodeFile="hermanoneshow.aspx.cs" Inherits="hermanoneshow" %>

<%@ Register assembly="DevExpress.XtraReports.v17.2.Web, Version=17.2.4.0, Culture=neutral, PublicKeyToken=b88d1754d700e49a" namespace="DevExpress.XtraReports.Web" tagprefix="dx" %>

<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" Runat="Server">
    <dx:ASPxDocumentViewer ID="ASPxDocumentViewer1" runat="server" Height="1100px" ReportTypeName="Herman1" Width="100%">
    </dx:ASPxDocumentViewer>
</asp:Content>

