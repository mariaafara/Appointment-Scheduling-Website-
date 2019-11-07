using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace aspproject
{
    public partial class home : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }
        protected void BookNowButton_Click(object sender, EventArgs e)
        {
            if (((string)Session["user"]) == null)

                Server.Transfer("login.aspx", true);
            else
                Server.Transfer("selectDentist.aspx", true);
        }

    }
}