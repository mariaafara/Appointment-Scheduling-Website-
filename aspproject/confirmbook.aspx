<%@ Page Title="" Language="C#" MasterPageFile="~/bookingsteps.master" AutoEventWireup="true" CodeBehind="confirmbook.aspx.cs" Inherits="aspproject.confirmbook" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolderbook" runat="server">
     <section id="two" class="wrapper">
	 <div class="inner">
		<header>
            <h3>Confirm your booking </h3>
		</header>
            <asp:Label id="Message" 
                    Text="No dates selected." 
                    runat="server"/>
         		<div class="table-wrapper">
									<table id ="times">
									
										<tbody>
											<tr>
												<td>Date : </td>
											    <td><asp:Label id="date" 
                                                    Text="" 
                                                    runat="server"/>
         		                                </td>
											</tr>
											<tr>
												<td>Start time : </td>
												 <td><asp:Label id="start1" 
                                                    Text="" 
                                                    runat="server"/>
         		                                </td>
											</tr>
											<tr>
												<td>End time : </td>
												 <td><asp:Label id="end1" 
                                                    Text="" 
                                                    runat="server"/>
         		                                </td>
											</tr>
											<tr>
												<td>Dentist</td>
												 <td><asp:Label id="dentist" 
                                                    Text="" 
                                                    runat="server"/>
         		                                </td>
											</tr>
                                            <tr>
												<td colspan="2">
                                                   <asp:Button ID="ConfirmBookButton" runat="server" 
                                                     cssClass="button special big" Text="  Confirm Book  " 
                                                     width="1070px" OnClick="ConfirmBookButton_Click"   />
												</td>
												 
											</tr>
											
										</tbody>
									
									</table>
								</div>	



         </div>
         </section>
</asp:Content>
