using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace aspproject
{
    public partial class selectDate : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            Session["page"] = "selectdate";
            if (!Page.IsPostBack)
                Calendar1.SelectedDate = DateTime.Now.Date;

        }
        protected void Calendar1_DayRender(object sender, DayRenderEventArgs e)
        {
            if (e.Day.Date < DateTime.Now.Date)
            {
                e.Day.IsSelectable = false;
                e.Cell.ForeColor = System.Drawing.Color.Gray;
            }
            if (e.Day.Date.DayOfWeek == DayOfWeek.Saturday)
            {
                e.Day.IsSelectable = false;
                e.Cell.ForeColor = System.Drawing.Color.Gray;
            }
            if (e.Day.Date.DayOfWeek == DayOfWeek.Sunday)
            {
                e.Day.IsSelectable = false;
                e.Cell.ForeColor = System.Drawing.Color.Gray;
            }

            if (Session["dentistId"].ToString() == "mehdi")
            {
                if (e.Day.Date.DayOfWeek == DayOfWeek.Tuesday)
                {
                    e.Day.IsSelectable = false;
                    e.Cell.ForeColor = System.Drawing.Color.Gray;
                }

            }
            if (Session["dentistId"].ToString() == "habib")
            {
                if (e.Day.Date.DayOfWeek == DayOfWeek.Monday)
                {
                    e.Day.IsSelectable = false;
                    e.Cell.ForeColor = System.Drawing.Color.Gray;
                }
                if (Session["dentistId"].ToString() == "marwan")
                {
                    if (e.Day.Date.DayOfWeek == DayOfWeek.Thursday)
                    {
                        e.Day.IsSelectable = false;
                        e.Cell.ForeColor = System.Drawing.Color.Gray;
                    }


                }

            }
        }

        protected void Selection_Change(object sender, EventArgs e)
        {
            // Clear the current text.
            Message.Text = "";
            ListBoxtime.Items.Clear();
            // Iterate through the SelectedDates collection and display the
            // dates selected in the Calendar control.
            foreach (DateTime day in Calendar1.SelectedDates)
            {

                Message.Text += day.Date.ToShortDateString() + "<br />";
               // Server.Transfer("confirmbook.aspx", true);
                Session["date"] = day.Date.ToShortDateString();
                time.Visible = true;
                ListBoxtime.Visible = true;
                fillListBox();
            }
           
        }
        void fillListBox()
        {
            string connetionString = null;
            SqlConnection cnn;
            connetionString = "Data Source=.;Initial Catalog=mySmile;Server=DESKTOP-GB2S5V2;Database=mySmile;Trusted_Connection=True;";//UserID=UserName;Password=Password";

            cnn = new SqlConnection(connetionString);
            try
            {
                cnn.Open();

                String q = "select *  from time where timeId not in (select timeId from bookedtime where Dentist_id='" + Session["dentistId"] + "'and Date='" + Session["date"] + "')";
                SqlCommand cmd = new SqlCommand(q, cnn);
                 SqlDataReader dataReader;
                dataReader = cmd.ExecuteReader(); //cmd.ExecuteNonQuery();
                int intNumOfRows = 0;

                while (dataReader.Read())
                {
                    //intNumOfRows = Convert.ToInt32(dataReader.GetValue(2));
                    String time = dataReader.GetString(1);//time l 0 hye id
                    ListBoxtime.Items.Add(time);
                }

                if (intNumOfRows > 0)
                {
                   
                    
                }
                
                dataReader.Close();
                cmd.Dispose();

                cnn.Close();
            }
            catch (Exception ex)
            {
                ScriptManager.RegisterClientScriptBlock(Page, this.GetType(), "MessageBox", "alert('Can not open connection !')" + ex, true);
                }
        }

        protected void ListBoxtime_SelectedIndexChanged(object sender, EventArgs e)
        {
            Session["time"] = ListBoxtime.Text;
            Message.Text = ListBoxtime.Text;
            if (Session["time"]!=null)
            Server.Transfer("confirmbook.aspx", true);
        }
    
    }
}