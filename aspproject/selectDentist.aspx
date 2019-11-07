<%@ Page Title="" Language="C#" MasterPageFile="~/bookingsteps.master" AutoEventWireup="true"
     CodeBehind="selectDentist.aspx.cs" Inherits="aspproject.selectDentist" %>
<%@ MasterType VirtualPath="~/bookingsteps.master" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    	
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolderbook" runat="server">
    <!-- Banner -->
		
    			<section id="two" class="wrapper">

				<div class="inner">
                    <article>
					<header>
						<h3>Please choose a dentist</h3>
					</header>
                     </article>
					<div class="flex flex-4">
						<div class="box person">
							<div class="image round">
								<img src="images/mehdi.jpg" alt="Person 1" height="170" width="170"/>
							</div>
							<h3>Dr. Mehdi Atwi</h3>
							<p>Dentist</p>
                            <footer>
						 <asp:Button ID="Dentist1" runat="server" cssClass="button special" Text="Select" Width="191px" OnClick="Dentist1_Click"   />
					</footer>
						</div>
						<div class="box person">
							<div class="image round">
								<img src="images/habib.jpg" alt="Person 2" height="170" width="170"/>
							</div>
							<h3>Dr. Habib Safadi</h3>
							<p>Orthodontist</p>
                             <footer>
						    <asp:Button ID="Dentiat2" runat="server" cssClass="button special" Text="Select" Width="191px" OnClick="Dentiat2_Click"  />
					         </footer>
						</div>
						<div class="box person">
							<div class="image round">
								<img src="images/celine.jpg" alt="Person 3" height="170" width="170"/>
							</div>
							<h3>Dr. Celine Hadad</h3>
							<p>Hygienist</p>
                             <footer>
						 <asp:Button ID="Dentist3" runat="server" cssClass="button special" Text="Select" Width="191px" OnClick="Dentist3_Click"  />
					</footer>
						</div>
						<div class="box person">
							<div class="image round">
								<img src="images/marwan.jpg" alt="Person 4" height="170" width="170"/>
							</div>
							<h3>Dr. Marwan Kamil</h3>
							<p>HollywoodSmile</p>
                             <footer>
						 <asp:Button ID="Dentist4" runat="server" cssClass="button special" Text="Select" Width="191px" OnClick="Dentist4_Click"  />
					</footer>
						</div>
					</div>
				</div>
			</section>



    <!-- Scripts -->
			<script src="assets/js/jquery.min.js"></script>
			<script src="assets/js/skel.min.js"></script>
			<script src="assets/js/util.js"></script>
			<script src="assets/js/main.js"></script>
</asp:Content>
