<%@ Page Title="" Language="C#" MasterPageFile="~/Master2.Master" AutoEventWireup="true" CodeBehind="BookNow2.aspx.cs" Inherits="aspproject.BookNow2" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder" runat="server">
       <section id="banner2">
            </section>

      <section id="two" class="wrapper">
          <div class="inner">

              <div class="row" style="color:white">
                  <table style="border-color: #FFFFFF; background-color:white" border="0">

                      <tbody >
                      <tr style="background-color:white">

                          <td rowspan="2" style="padding-left: 2% ">

                              <asp:Calendar ID="Calendar2"
                                  OnSelectionChanged="Selection_Change"
                                  runat="server" BackColor="White" BorderColor="White" BorderWidth="1px"
                                  Font-Names="Verdana" Font-Size="9pt" ForeColor="Black" Height="420px"
                                  NextPrevFormat="FullMonth" Width="460px"
                                  OnDayRender="Calendar1_DayRender">
                                  <DayHeaderStyle Font-Bold="True" Font-Size="8pt"></DayHeaderStyle>
                                  <NextPrevStyle VerticalAlign="Bottom" Font-Bold="True" Font-Size="8pt"
                                      ForeColor="#333333"></NextPrevStyle>
                                  <OtherMonthDayStyle ForeColor="#CC9966"></OtherMonthDayStyle>

                                  <SelectedDayStyle BackColor="#333399" ForeColor="White"></SelectedDayStyle>
                                  <TitleStyle BackColor="White" BorderColor="Black" BorderWidth="0px"
                                      Font-Bold="True" Font-Size="12pt" ForeColor="#333399"></TitleStyle>
                                  <TodayDayStyle BackColor="#CCCCCC"></TodayDayStyle>
                              </asp:Calendar>


                          </td>

                          <td >
                              
                              <asp:TextBox visible="false" ID="patientname" runat="server" Height="35px" Width="223px" ForeColor="Black" BorderColor="Blue"></asp:TextBox>
                              <asp:Button ID="searchpatient" runat="server" Height="35px"  CssClass="alt"   visible="false" 
                                  Text="search" OnClick="searchpatient_Click" CausesValidation="False" Width="223px" />
                          </td>
                          <td>
                              &nbsp;</td>

                        <td></td>

                      </tr>
                      <tr style="background-color:white">
                          
                          <td style="background-color:white">

                              <asp:ListBox ID="ListBoxpatient" runat="server" Visible="false"
                                  Font-Size="20pt" ForeColor="#CCCCCC" AlternationCount="2"
                                  Font-Bold="True" Height="322px" Width="265px"
                                  AutoPostBack="True" EnableViewState="True" OnSelectedIndexChanged="ListBoxpatient_SelectedIndexChanged"></asp:ListBox>
                              <asp:RequiredFieldValidator ID="listboxpatientvalidator"
                                  ControlToValidate="ListBoxpatient" runat="server"
                                  ErrorMessage="must select a patient" BorderStyle="Dashed" ForeColor="Red"></asp:RequiredFieldValidator>
                               </td>
                            <td  style="background-color:white">
                              <asp:ListBox ID="ListBoxtime" runat="server" Visible="false"
                                  Font-Size="20pt" ForeColor="#CCCCCC"
                                  Font-Bold="True" Height="312px" Width="265px"
                                  AutoPostBack="True" EnableViewState="True"
                                  OnSelectedIndexChanged="ListBoxtime_SelectedIndexChanged"></asp:ListBox>
                         <asp:RequiredFieldValidator ID="listboxtimevalidator"
                                  ControlToValidate="ListBoxtime" runat="server"
                                  ErrorMessage="must select a patient" BorderStyle="Dashed" ForeColor="Red"></asp:RequiredFieldValidator>
                              
                                 </td>
                      </tr>
                   </tbody>
                  </table>
                    &nbsp&nbsp&nbsp&nbsp&nbsp&nbsp 
                  
              </div>
              <div>
                  <asp:Button ID="Book" runat="server" Height="50px" width="500px" CssClass="alt"  Text="Book" OnClick="Book_Click"  />
                   
              </div>
       </div>
          
        </section>



</asp:Content>
