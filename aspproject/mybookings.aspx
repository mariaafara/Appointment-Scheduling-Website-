<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.Master" AutoEventWireup="true" CodeBehind="mybookings.aspx.cs" Inherits="aspproject.mybookings" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder" runat="server">
         <section id="banner2">
            </section>
      <br />
  <section id="three" class="wrapper">
				<div class="inner">
					<header class="align-center">
						<h2><asp:Label ID="noapplabel" runat="server" Visible="false" Text="There are no appointments yet.Press the 'Book Now' button to make an appointment"></asp:Label></h2>
						   <h3> <asp:Label ID="login" Visible="false" runat="server" Text="please login first to view your bookings"></asp:Label></h3>
						
					</header>
   <h3> <asp:Label ID="Label2" runat="server" Visible="false" Text="UpComming appointments"></asp:Label> </h3>
  
     <asp:ScriptManager ID="ScriptManager1" runat="server"></asp:ScriptManager>
   
         <asp:UpdatePanel ID="UpdatePanel1" runat="server">
         <ContentTemplate>
    &nbsp&nbsp&nbsp&nbsp&nbsp&nbsp 
     <asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="False"  Width="100%"  >
               <Columns>
                <asp:BoundField DataField="Date" HeaderText ="Date" DataFormatString="{0:d}" />
                <asp:BoundField DataField="name" HeaderText ="Dentist" />
                <asp:BoundField DataField="StartTime" HeaderText ="Start" />
                      <asp:BoundField DataField="EndTime" HeaderText ="End" />
                <asp:TemplateField>
                    <ItemTemplate>
                        <asp:LinkButton ID="lnkCancel" Text="Cancel" runat="server" 
                            CommandArgument='<%# Eval("Appointment_id") %>' 
                            OnClick="lnkCancel_Click" />
                    </ItemTemplate>
                </asp:TemplateField>
            </Columns>
        </asp:GridView>&nbsp&nbsp&nbsp&nbsp&nbsp&nbsp
              </ContentTemplate>
         </asp:UpdatePanel>
     <br />
   <h3> <asp:Label ID="Label3" runat="server" Visible="false" Text="Canceled appointments"></asp:Label> </h3>
  
   
         <asp:UpdatePanel ID="UpdatePanel2" runat="server">
         <ContentTemplate>
    &nbsp&nbsp&nbsp&nbsp&nbsp&nbsp 
     <asp:GridView ID="GridView3" runat="server" AutoGenerateColumns="False"  Width="100%"   >
               <Columns>
                <asp:BoundField DataField="Date" HeaderText ="Date" DataFormatString="{0:d}" />
                <asp:BoundField DataField="name" HeaderText ="Dentist" />
                <asp:BoundField DataField="StartTime" HeaderText ="Start" />
                 <asp:BoundField DataField="EndTime" HeaderText ="End" />
                
            </Columns>
        </asp:GridView>&nbsp&nbsp&nbsp&nbsp&nbsp&nbsp
              </ContentTemplate>
         </asp:UpdatePanel>
     <br />
   <h3> <asp:Label ID="Label1" runat="server" Visible="false" Text="Old appointments"></asp:Label> </h3>
    &nbsp&nbsp&nbsp&nbsp&nbsp&nbsp 
     <asp:GridView ID="GridView2" runat="server" AutoGenerateColumns="False"   Width="100%"  >
               <Columns>
                <asp:BoundField DataField="Date" HeaderText ="Date" DataFormatString="{0:d}" />
                <asp:BoundField DataField="name" HeaderText ="Dentist" />
                <asp:BoundField DataField="StartTime" HeaderText ="Start" />
                <asp:BoundField DataField="EndTime" HeaderText ="End" />
            </Columns>
        </asp:GridView>&nbsp&nbsp&nbsp&nbsp&nbsp&nbsp
  <br />
    </div>
      </section>
</asp:Content>
