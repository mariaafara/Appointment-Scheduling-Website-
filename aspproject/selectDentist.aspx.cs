using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace aspproject
{
    public partial class selectDentist : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            Session["page"] = "selectdentist";
            Session["dentistId"] = -1;

        }
        protected void Dentist3_Click(object sender, EventArgs e)
        {
            Session["dentistId"] = "celine";
            Session["dentistname"] = "Dr. Celine Hadad";
            Server.Transfer("selectDate.aspx", true);
            //   Master.FindControl("selectdateTime").EnableViewState = true;
        }

        protected void Dentist1_Click(object sender, EventArgs e)
        {
            Session["dentistId"] = "mehdi";
            Session["dentistname"] = "Dr. Mehdi Atwi";
            Server.Transfer("selectDate.aspx", true);
        }

        protected void Dentiat2_Click(object sender, EventArgs e)
        {
            Session["dentistId"] = "habib";
            Session["dentistname"] = "Dr. Habib Safadi";
            Server.Transfer("selectDate.aspx", true);
        }

        protected void Dentist4_Click(object sender, EventArgs e)
        {
            Session["dentistId"] = "marwan";
            Session["dentistname"] = "Dr. Marwan Kamil";
            Server.Transfer("selectDate.aspx", true);

        }
      
    }
}