<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.Master" AutoEventWireup="true" CodeBehind="login.aspx.cs" Inherits="aspproject.login" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder" runat="server">
        <section id="banner">
				<h1>Login  to my Smile</h1>
				<p>please provide yourse username and password provided from us.</p>
            <asp:Label ID="errorlabel" runat="server" ForeColor="Red"  Font-Bold="true"></asp:Label>
                	<div class="inner">
                        <header>
                            <div class="row">
						<div class="6u 12u$(small)">
                     
						<asp:TextBox ID="username" ForeColor="White" cssClass="query" runat="server" height="50px">UserName</asp:TextBox>
                         <asp:RequiredFieldValidator ID="RequiredFieldValidatorusername" runat="server" 
                                       ControlToValidate="username" Display="Dynamic"  ForeColor="Red"
                             Font-Bold="true" 
                                   ErrorMessage="please enter your username"></asp:RequiredFieldValidator>
                             </div>
                        <div class="6u 12u$(small)">
						<asp:TextBox ID="password" ForeColor="White" cssClass="query" runat="server" Height="50px" >Password</asp:TextBox>
                             <asp:RequiredFieldValidator ID="RequiredFieldValidatorpassword" runat="server" 
                                                ControlToValidate="password"         Font-Bold="true"
                                     Display="Dynamic"  ForeColor="Red"
                                   ErrorMessage="please enter your password"></asp:RequiredFieldValidator>
                            </div>
                                </div>  

                        </header>
					<footer>
                        <br />
                        <br />
                        <br />
						 <asp:Button ID="LogInButton" runat="server" cssClass="button special big" Text="LogIn" Width="191px" OnClick="LogInButton_Click"  />
					</footer>
				</div>
			</section>
</asp:Content>
