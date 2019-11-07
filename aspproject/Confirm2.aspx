<%@ Page Title="" Language="C#" MasterPageFile="~/Master2.Master" AutoEventWireup="true" CodeBehind="Confirm2.aspx.cs" Inherits="aspproject.Confirm2" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder" runat="server">
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
											    <td><asp:Label id="date2" 
                                                    Text="" 
                                                    runat="server"/>
         		                                </td>
											</tr>
											<tr>
												<td>Start time : </td>
												 <td><asp:Label id="start2" 
                                                    Text="" 
                                                    runat="server"/>
         		                                </td>
											</tr>
											<tr>
												<td>End time : </td>
												 <td><asp:Label id="end2" 
                                                    Text="" 
                                                    runat="server"/>
         		                                </td>
											</tr>
											<tr>
												<td>Patient</td>
												 <td><asp:Label id="patient" 
                                                    Text="" 
                                                    runat="server"/>
         		                                </td>
											</tr>
                                            <tr>
												<td colspan="2">
                                                   <asp:Button ID="ConfirmBookButton2" runat="server" 
                                                     cssClass="button special big" Text="  Confirm Book  " 
                                                     width="1080px" OnClick="ConfirmBookButton_Click2"   />
												</td>
												 
											</tr>
											
										</tbody>
									
									</table>
								</div>	



         </div>
         </section>
</asp:Content>
