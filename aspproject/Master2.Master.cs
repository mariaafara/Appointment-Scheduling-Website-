using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace aspproject
{
    public partial class Master2 : System.Web.UI.MasterPage
    {
        protected void Page_Load(object sender, EventArgs e)
        {

            if (Session["user"] != null)
            {
                log1.Text = "logout";
            }

        }

        protected void log1_Click(object sender, EventArgs e)
        {
            if (log1.Text.Equals("login"))
            {
                Response.Redirect("login.aspx");
            }
            else if (log1.Text.Equals("logout"))
            {
                log1.Text = "login";
                Session["user"] = null;
                Response.Redirect("login.aspx");
            }
        }
       
    }
}