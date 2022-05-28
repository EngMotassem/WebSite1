<%@ Page Title="" Language="C#" MasterPageFile="~/Site.master" AutoEventWireup="true" CodeFile="Default2.aspx.cs" Inherits="Default2" %>

<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" Runat="Server">
        <div class="row " dir="rtl" style="font-family:DroidKufi">
          <div class="col-sm-6">.col-sm-8</div>

                    <div class="col-sm-6 ">
                        <br />
                      <asp:Label ID="Label24" runat="server" ForeColor="#339933"></asp:Label> 


                        <br />

                        <asp:Calendar ID="Calendar1" runat="server" BackColor="White" BorderColor="Black" BorderStyle="Solid" CellSpacing="1" Font-Names="Verdana" Font-Size="9pt" ForeColor="Black" Height="250px" NextPrevFormat="ShortMonth" Width="330px">
                            <DayHeaderStyle Font-Bold="True" Font-Size="8pt" ForeColor="#333333" Height="8pt" />
                            <DayStyle BackColor="#CCCCCC" />
                            <NextPrevStyle Font-Bold="True" Font-Size="8pt" ForeColor="White" />
                            <OtherMonthDayStyle ForeColor="#999999" />
                            <SelectedDayStyle BackColor="#333399" ForeColor="White" />
                            <TitleStyle BackColor="#333399" BorderStyle="Solid" Font-Bold="True" Font-Size="12pt" ForeColor="White" Height="12pt" />
                            <TodayDayStyle BackColor="#999999" ForeColor="White" />
                        </asp:Calendar>
                <asp:TextBox ID="TextBox1" runat="server" Height="29px" Width="128px"></asp:TextBox>
&nbsp;<asp:Button ID="Button1" runat="server" Text="عرض " OnClick="Button1_Click" Font-Size="Small"  />

                        <p >

                    <asp:Label ID="Label1" runat="server" Text="اسم الطالب:  "></asp:Label>
                      <asp:Label ID="Label2" runat="server" Text=""></asp:Label> 


                </p>

                <p  >
                                        <asp:Label ID="Label6" runat="server" Text="مدرسة الطالب:  "></asp:Label>


                    <asp:Label ID="Label3" runat="server" Text=""></asp:Label>

                </p>
                <p >
                 <asp:Label ID="Label7" runat="server" Text="لجنة السير:  "></asp:Label>

                    <asp:Label ID="Label4" runat="server" Text=""></asp:Label>

                </p>
                        <p >
                         <asp:Label ID="Label15" runat="server" Text="المنطقة التعليمية:  "></asp:Label>

                    <asp:Label ID="Label16" runat="server" Text=""></asp:Label>

                </p>
                <p >
                         <asp:Label ID="Label8" runat="server" Text="القسم:  "></asp:Label>

                    <asp:Label ID="Label5" runat="server" Text=""></asp:Label>

                </p>
            <p >

                 <asp:Label ID="Label9" runat="server" Text="اختبار اليوم:  "></asp:Label>

                    <asp:Label ID="Label10" runat="server" Text=""></asp:Label>

                <asp:Label ID="Label18" runat="server" Text="كود المادة:  "></asp:Label>

                    <asp:Label ID="Label19" runat="server" Text=""></asp:Label>
                <asp:Label ID="Label20" runat="server" Text="كود الاختبار:  "></asp:Label>

                    <asp:Label ID="Label21" runat="server" Text=""></asp:Label>
                <p >

                 <asp:Label ID="Label11" runat="server" Text="تاريخ الاختبار:  "></asp:Label>

                    <asp:Label ID="Label12" runat="server" Text=""></asp:Label>
            
                <p >

                 <asp:Label ID="Label13" runat="server" Text="يوم الاختبار:  "></asp:Label>

                    <asp:Label ID="Label14" runat="server" Text=""></asp:Label>
                        
                        <p>
                             <asp:Label ID="Label22" runat="server" Text="رقم المحضر:  "></asp:Label>
                            <asp:TextBox ID="TextBox2" runat="server" Height="16px" Width="307px" ToolTip="رقم المحضر"></asp:TextBox>
                        </p>
                        <p >
                              <asp:Label ID="Label17" runat="server" Text="النموذج:  "></asp:Label>
                            <asp:DropDownList ID="DropDownList1" runat="server" Width="560px">
                                <asp:ListItem Value="2">نموذج رقم 2 يعمل به في الفترة الدراسية الثانية</asp:ListItem>
                                <asp:ListItem Value="1">نموذج رقم 4 يعمل به في الفترة الدراسية الثانية</asp:ListItem>
                                <asp:ListItem Value="3">نموذج رقم 6 يعمل به في الفترة الدراسية الثانية</asp:ListItem>
                                <asp:ListItem Value="4">نموذج 7 يعمل به في الفترة  الدراسية الأولى والثانية </asp:ListItem>
                            </asp:DropDownList>
                        <p >
                      <asp:Label ID="Label23" runat="server" Text=""></asp:Label> 


                        <p >
                            &nbsp;<p >

                            <asp:TextBox ID="repotDescTxt" runat="server" Height="174px" Width="482px" Rows="10" TextMode="MultiLine"></asp:TextBox>
            <p>

         <asp:Button ID="takenBt" runat="server" Text="ورقة مسحوبة" OnClick="TakenBt_Click" CommandName="TakenBt_Click" Font-Size="Small"  />
                &nbsp;<asp:Button ID="PrintBt" runat="server" Text="طباعة قرار حرمان " OnClick="PrintRep_Click" Font-Size="Small"  />
         <asp:Button ID="clearBt" runat="server" Text="مسح" OnClick="Clear_Click" Font-Size="Small"  />

                </p>
            <p>

                    &nbsp;</p>
            </div>


        </div>

</asp:Content>

