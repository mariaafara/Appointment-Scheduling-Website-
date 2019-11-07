using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace aspproject
{
    public partial class bookingsteps : System.Web.UI.MasterPage
    {
        protected void Page_Load(object sender, EventArgs e)
        {

            if (Session["page"].ToString() == "selectdentist")
            {
                selectdentist.Enabled = true;
                selectdentist.ForeColor = System.Drawing.Color.BlueViolet;
                selectdentist.BackColor = System.Drawing.Color.White;
                selectdateTime.Enabled = false;
                selectdateTime.ForeColor = System.Drawing.Color.White;
                selectdateTime.BackColor = System.Drawing.Color.Transparent;
                confirmbook.Enabled = false;
                confirmbook.ForeColor = System.Drawing.Color.White;
                confirmbook.BackColor = System.Drawing.Color.Transparent;
            }
            else
                if (Session["page"].ToString() == "confirm")
                {
                    confirmbook.Enabled = false;
                    confirmbook.ForeColor = System.Drawing.Color.BlueViolet;
                    confirmbook.BackColor = System.Drawing.Color.White;
                    selectdateTime.Enabled = true;
                    selectdateTime.ForeColor = System.Drawing.Color.BlueViolet;
                    selectdateTime.BackColor = System.Drawing.Color.White;
                    selectdentist.Enabled = true;
                    selectdentist.ForeColor = System.Drawing.Color.BlueViolet;
                    selectdentist.BackColor = System.Drawing.Color.White;
                }
                else if (Session["page"].ToString() == "selectdate")
                {
                    selectdentist.Enabled = true;
                    selectdentist.ForeColor = System.Drawing.Color.BlueViolet;
                    selectdentist.BackColor = System.Drawing.Color.White;
                    selectdateTime.Enabled = true;
                    selectdateTime.ForeColor = System.Drawing.Color.BlueViolet;
                    selectdateTime.BackColor = System.Drawing.Color.White;
                    confirmbook.Enabled = false;
                    confirmbook.ForeColor = System.Drawing.Color.White;
                    confirmbook.BackColor = System.Drawing.Color.Transparent;
                }


        }
       
    }
}