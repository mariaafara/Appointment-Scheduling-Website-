<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.Master" AutoEventWireup="true" CodeBehind="home.aspx.cs" Inherits="aspproject.home" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder" runat="server">
        <!--**********************************************************-->
   
    <!--**********************************************************-->

		<!-- Banner -->
			<section id="banner">
				<h1>Welcome to my Smile</h1>
				<p>An Appointment scheduling website</p>
                	<div class="inner">
					<footer>
						 <asp:Button ID="BookNowButton" runat="server"   cssClass="button special big" Text="Book Now" Width="191px" OnClick="BookNowButton_Click"  />
					</footer>
				</div>
			</section>
      
    <!-- One -->
			<section id="one" class="wrapper">
				<div class="inner">
					<div class="flex flex-3">
						<article>
							<header>
								<h3>Teeth Whitening</h3>
							</header>
							<p>Whitening is among the most popular dental procedures because it can greatly improve how your teeth look.</p>
							<footer>
								<%--<a href="#" class="button special">More</a>--%>
							</footer>
						</article>
						<article>
							<header>
								<h3>Teeth Cleaning</h3>
							</header>
							<p>Teeth cleaning is part of oral hygiene and involves the removal of dental plaque from teeth (dental caries).</p>
							<footer>
								<%--<a href="#" class="button special">More</a>--%>
							</footer>
						</article>
					
                        <article>
							<header>
								<h3>Quality Brackets</h3>
							</header>
							<p>Orthodontics is the branch of dentistry that corrects teeth and jaws that are positioned improperly.</p>
							<footer>
							<%--	<a href="#" class="button special">More</a>--%>
							</footer>
						</article>
					</div>
				</div>
			</section>

   
    <!-- Two -->
			<section id="two" class="wrapper style1 special">
				<div class="inner">
					<header>
						<h2>Our mission is to be Lebanon’s most trusted dental care provider. We do this by treating our patients as valued guests and providing exceptional service in line with our 4 C’s of patient satisfaction:</h2>
					</header>
					<div class="flex flex-4">
						<div class="box person">
							<h3>CARE</h3>
                             <br />
							<p>With decades of experience, the latest technology and modern practices, you’ll get results beyond compare.</p>
						</div>
						<div class="box person">
							<h3>COMFORT</h3>
                             <br />
							<p>To ensure your experience is as pleasant as possible, the clinic is modern and lets in plenty of daylight for your ultimate comfort and wellbeing.</p>
						</div>
						<div class="box person">
							<h3>CONVENIENCE</h3>
                            <br />
							<p>Conveniently located in a chic, prime location of Beirut, close to the city’s major attractions, hotels and business centers.</p>
						</div>
						<div class="box person">
						
							<h3>CONFIDENCEe</h3>
                             <br />
							<p>When you choose us to provide you with the finest dental services, you immediately feel the peace of mind that our 20 years of experience and a team of highly skilled professionals exude.</p>
						</div>
					</div>

                    <!--------------------------------------------------->
                  
				</div>
			</section>



</asp:Content>
