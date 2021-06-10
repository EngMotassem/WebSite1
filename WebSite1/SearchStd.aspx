<%@ Page Language="C#"  MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeFile="SearchStd.aspx.cs" Inherits="SearchStd" %>


<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">

    <div class="row">
        <div class="col-sm-4">
            <form id="form1" runat="server">

                <asp:Button ID="Button1" runat="server" Text="Button" OnClick="Button1_Click" />
                <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
                <p>

                    <asp:Label ID="Label2" runat="server" Text="Label"></asp:Label>

                </p>
                <p>

                    <asp:Label ID="Label3" runat="server" Text="Label"></asp:Label>

                </p>
                <p>

                    <asp:Label ID="Label4" runat="server" Text="Label"></asp:Label>

                </p>
                <p>

                    <asp:Label ID="Label5" runat="server" Text="Label"></asp:Label>

                </p>
            </form>
            </div>
          <div class="col-sm-8">.col-sm-8</div>

        </div>



</asp:Content>
