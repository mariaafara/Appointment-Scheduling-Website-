<%@ Page Title="" Language="C#" MasterPageFile="~/bookingsteps.master" AutoEventWireup="true" CodeBehind="selectDate.aspx.cs" Inherits="aspproject.selectDate" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolderbook" runat="server">
      
    <section id="two" class="wrapper">
	 <div class="inner">
		<header>
            <h3>Please choose a date </h3>
		</header>
          <asp:Label id="Message" 
                    Text="No dates selected." 
                    runat="server"/>

         			<div class="row">
						<div class="6u 12u$(small)">
							 <asp:Calendar   ID="Calendar1" 
             OnSelectionChanged="Selection_Change"
            
            runat="server" BackColor="White" BorderColor="White" BorderWidth="1px" 
            Font-Names="Verdana" Font-Size="9pt" ForeColor="Black" Height="190px" 
            NextPrevFormat="FullMonth" Width="450px"
             OnDayRender="Calendar1_DayRender"
            >    
            <DayHeaderStyle Font-Bold="True" Font-Size="8pt"></DayHeaderStyle>
            <NextPrevStyle VerticalAlign="Bottom" Font-Bold="True" Font-Size="8pt"
                 ForeColor="#333333"></NextPrevStyle>
            <OtherMonthDayStyle ForeColor="#CC9966"></OtherMonthDayStyle>
            
            <SelectedDayStyle BackColor="#333399" ForeColor="White"></SelectedDayStyle>
            <TitleStyle BackColor="White" BorderColor="Black" BorderWidth="0px" 
                Font-Bold="True" Font-Size="12pt" ForeColor="#333399"></TitleStyle>
            <TodayDayStyle BackColor="#CCCCCC"></TodayDayStyle>
        </asp:Calendar>

						</div>
						<div id="select times" class="6u$ 12u$(small)">
						
                           <h3> <asp:Label ID="time" Visible="false" runat="server" Text="Select time"></asp:Label></h3>
						    <asp:ListBox ID="ListBoxtime" runat="server" Visible="false"
                                Font-Size="20pt"   ForeColor="#CCCCCC" 
                                Font-Bold="True" Height="312px" Width="265px"
                                AutoPostBack="True" EnableViewState="True"
                                 OnSelectedIndexChanged="ListBoxtime_SelectedIndexChanged"></asp:ListBox>
						</div>
						
				
					</div>




            </div>
        </section>

    


</asp:Content>
