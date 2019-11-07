<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.Master" AutoEventWireup="true" CodeBehind="dentists.aspx.cs" Inherits="aspproject.dentists" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder" runat="server">
      <section id="banner2">
        </section>
    
    <asp:ScriptManager ID="ScriptManager1" runat="server"></asp:ScriptManager>
   
     <asp:UpdatePanel ID="UpdatePanel1" runat="server">
         <ContentTemplate>
        <asp:Timer ID="Timer1" runat="server" Interval="2500" OnTick="Timer1_Tick"></asp:Timer>

        <asp:Image ID="Image1" height="410px" Width="100%" runat="server" />
 
         </ContentTemplate>
         </asp:UpdatePanel>
    
  		<section id="three" class="wrapper">
				<div class="inner">
					<header class="align-center">
						<h2>mySmile Team</h2>
						<p>A CARING, FRIENDLY TEAM OF DENTAL PROFESSIONALS IS AVAILABLE 24/7</p>
					</header>
					<div class="flex flex-2">
						<article>
							<div class="image fit">
								<img src="images/mehdi.jpg" alt="Pic 01" height="270" />
							</div>
							<header>
								<h3>Dr. Mehdi Atwi ~Dentist</h3>
							</header>
							<p>Diagnose and treat problems with patients' teeth, gums, and related parts of the mouth. They provide advice and instruction on taking care of the teeth and gums and on diet choices that affect oral health.</p>
							<footer>
								<a href="#" class="button special">Mon</a>
                                <a href="#" class="button special">Wed</a>
                                <a href="#" class="button special">Thur</a>
                                <a href="#" class="button special">Fri</a>
							</footer>
						</article>
						<article>
							<div class="image fit">
								<img src="images/habib.jpg" alt="Pic 02"  height="270" />
							</div>
							<header>
								<h3>Dr. Habib Safadi ~Orthodontist</h3>
							</header>
							<p>Examine, diagnose, and treat dental malocclusions and oral cavity anomalies. Design and fabricate appliances to realign teeth and jaws to produce and maintain normal function and to improve appearance.</p>
							<footer>
								<a href="#" class="button special">Mon</a>
                                <a href="#" class="button special">Tues</a>
                                <a href="#" class="button special">Wed</a>
                                <a href="#" class="button special">Thur</a>
                                <a href="#" class="button special">Fri</a>
							</footer>
						</article>
					</div>
                    <br />
                    <br />

                    	<div class="flex flex-2">
						<article>
							<div class="image fit">
								<img src="images/celine.jpg" alt="Pic 01" height="270" />
							</div>
							<header>
								<h3>Dr. Celine Hadad ~Hygienist</h3>
							</header>
							<p>prevent dental decay by cleaning patients' teeth and providing them with education about how to care effectively for their teeth and gums, and the affects of diet on oral health.</p>
							<footer>
								
                                <a href="#" class="button special">Tues</a>
                                <a href="#" class="button special">Wed</a>
                                <a href="#" class="button special">Thur</a>
                                 <a href="#" class="button special">Fri</a>
							</footer>
						</article>
						<article>
							<div class="image fit">
								<img src="images/marwan.jpg" alt="Pic 02" height="270" />
							</div>
							<header>
								<h3>Dr. Marwan Kamil ~HollywoodSmile</h3>
							</header>
							<p>Hollywood smiles are pearly white paragons of straightness.Teeth might be described as having character.Whiter than white, it transpires. Teeth naturally vary in colour and the palette can tend closer to cream than white.</p>
                            
							<footer>
								<a href="#" class="button special">Mon</a>
                                <a href="#" class="button special">Tues</a>
                                <a href="#" class="button special">Wed</a>
                                <a href="#" class="button special">Fri</a>
                               
							</footer>
						</article>
					</div>
				</div>
			</section>

</asp:Content>
