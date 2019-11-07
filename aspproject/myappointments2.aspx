<%@ Page Title="" Language="C#" MasterPageFile="~/Master2.Master" AutoEventWireup="true" CodeBehind="myappointments2.aspx.cs" Inherits="aspproject.myappointments2" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">

</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder" runat="server"> 
<%--        <meta charset="utf-8"/>
  <meta name="viewport" content="width=device-width, initial-scale=1"/>
  <link rel="stylesheet" href="//code.jquery.com/ui/1.12.1/themes/base/jquery-ui.css"/>
  <link rel="stylesheet" href="/resources/demos/style.css"/>
  --%>
     <section id="banner2">
            </section>
      <br />
        <div class="inner">
            <div class="row">
                <div class="6u 12u$(small)">
                    <header class="align-center">
                        <h2>Today</h2>

                    </header>

                    <asp:ScriptManager ID="ScriptManager1" runat="server"></asp:ScriptManager>

                    <asp:UpdatePanel ID="UpdatePanel1" runat="server">
                        <ContentTemplate>
                            &nbsp&nbsp&nbsp&nbsp&nbsp&nbsp 
     <asp:GridView ID="GridViewtoday" runat="server" AutoGenerateColumns="False" Width="375px">
          
         <Columns>
             <asp:BoundField DataField="StartTime" HeaderText="Start" />
             <asp:BoundField DataField="EndTime" HeaderText="End" />
             <asp:BoundField DataField="name" HeaderText="Patient" />
         </Columns>
     </asp:GridView>
                            &nbsp&nbsp&nbsp&nbsp&nbsp&nbsp
                        </ContentTemplate>
                    </asp:UpdatePanel>
                   

                    </div>
                <div class="6u 12u$(small)">
                    <div>
                        <asp:Calendar ID="Calendar1" runat="server" Height="50px"
                             OnDayRender="Calendar1_DayRender"
                              OnSelectionChanged="Selection_Change" BackColor="White" BorderColor="#3366CC" BorderWidth="1px" CellPadding="0"
                             DayNameFormat="Shortest" Font-Names="Verdana" Font-Size="8pt" ForeColor="#003399" Width="376px">
                            <DayHeaderStyle BackColor="#99CCCC" ForeColor="#336666" Height="0.5px" />
                            <NextPrevStyle Font-Size="6pt" ForeColor="#CCCCFF" />
                            <OtherMonthDayStyle ForeColor="#999999" />
                            <SelectedDayStyle BackColor="#009999" Font-Bold="True" ForeColor="#CCFF99" />
                            <SelectorStyle BackColor="#99CCCC" ForeColor="#336666" />
                            <TitleStyle BackColor="#003399" BorderColor="#3366CC" BorderWidth="1px" Font-Bold="True" Font-Size="8pt" ForeColor="#CCCCFF" Height="25px" />
                            <TodayDayStyle BackColor="#99CCCC" ForeColor="White" />
                            <WeekendDayStyle BackColor="#CCCCFF" />
                        </asp:Calendar>
                        <%-- <asp:TextBox id="datepicker" runat="server"></asp:TextBox>--%>
                     
                       <%-- <div>
                            <asp:TextBox ID="txtDate" runat="server" />
                        </div>--%>

                        <%-- <p>   <input type="text" id="datepicker"/></p>  --%>

                        <%--   <asp:Button ID="searchdatebutton" runat="server" Text="search" />--%>

                        <%--   <input id="searchdatetextbox" name="searchdatetextbox" type="text" size="25"/>
                        <a href="javascript:NewCal('searchdatetextbox','ddmmyyyy')" >
                         <img src="images/cal.gif" width="16" height="16" 
                             border="0" alt="Pick a date"/></a>--%>
                    </div>
                    <asp:UpdatePanel ID="UpdatePanel2" runat="server">
                        <ContentTemplate>
                            &nbsp&nbsp&nbsp&nbsp&nbsp&nbsp 
            
                     <asp:GridView ID="GridViewsearched" runat="server" AutoGenerateColumns="False"  Width="375px">
         <AlternatingRowStyle BackColor="#DCDCDC"></AlternatingRowStyle>
         <Columns>

             <asp:BoundField DataField="StartTime" HeaderText="Start" />
             <asp:BoundField DataField="EndTime" HeaderText="End" />
             <asp:BoundField DataField="name" HeaderText="Patient" />

         </Columns>
        
     </asp:GridView>

                            &nbsp&nbsp&nbsp&nbsp&nbsp&nbsp
                        </ContentTemplate>
                    </asp:UpdatePanel>
                    <br />
                </div>
                </div>
            </div>
<%--<script  src="assets/js/datetimepicker.js"></script>--%>
    <%--   <meta charset="utf-8"/>
  <meta name="viewport" content="width=device-width, initial-scale=1"/>
  <link rel="stylesheet" href="//code.jquery.com/ui/1.12.1/themes/base/jquery-ui.css"/>
  <link rel="stylesheet" href="/resources/demos/style.css"/>
    <script src="https://code.jquery.com/jquery-1.12.4.js"></script>
  <script src="https://code.jquery.com/ui/1.12.1/jquery-ui.js"></script>
  <script>
  $( function() {
    $( "#datepicker" ).datepicker();
  } );
  </script>--%>
</asp:Content>
