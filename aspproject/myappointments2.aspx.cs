using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace aspproject
{
    public partial class myappointments2 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!Page.IsPostBack)
                Calendar1.SelectedDate = DateTime.Now.Date;
            filltoday();
            

            /////////////////////////////////////////////////////


        }
        protected void Selection_Change(object sender, EventArgs e)
        {
            // Clear the current text.
          
          
            foreach (DateTime day in Calendar1.SelectedDates)
            {

              
               String date = day.Date.ToShortDateString();
               string connetionString = null;
               SqlConnection cnn;
               connetionString = "Data Source=.;Initial Catalog=mySmile;Server=DESKTOP-GB2S5V2;Database=mySmile;Trusted_Connection=True;";//UserID=UserName;Password=Password";

               cnn = new SqlConnection(connetionString);
               try
               {
                   cnn.Open();
                   String q = "select p.Name,a.StartTime,a.EndTime,a.Appointment_id from  appointment a ,Patient p where a.Patient_id=p.Patient_id  and  Dentist_id='" + Session["user"].ToString() + "' and Canceled=0 and a.Date='"+date+"'";
                   SqlDataAdapter sqlDa = new SqlDataAdapter(q, cnn);
                   DataTable dtbl = new DataTable();
                   sqlDa.Fill(dtbl);
                   GridViewsearched.DataSource = dtbl;
                   GridViewsearched.DataBind();

               }

               catch (Exception ex)
               {
                   ScriptManager.RegisterClientScriptBlock(Page, this.GetType(), "MessageBox", "alert('Can not open connection !')" + ex, true);
               }
            }

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

            if (Session["user"].ToString() =="mehdi")
            {
                if (e.Day.Date.DayOfWeek == DayOfWeek.Tuesday)
                {
                    e.Day.IsSelectable = false;
                    e.Cell.ForeColor = System.Drawing.Color.Gray;
                }

            }
            if (Session["user"].ToString() == "habib")
            {
                if (e.Day.Date.DayOfWeek == DayOfWeek.Monday)
                {
                    e.Day.IsSelectable = false;
                    e.Cell.ForeColor = System.Drawing.Color.Gray;
                }
                if (Session["user"].ToString() == "marwan")
                {
                    if (e.Day.Date.DayOfWeek == DayOfWeek.Thursday)
                    {
                        e.Day.IsSelectable = false;
                        e.Cell.ForeColor = System.Drawing.Color.Gray;
                    }


                }

            }
        }
        void filltoday()
        {
            string connetionString = null;
            SqlConnection cnn;
            connetionString = "Data Source=.;Initial Catalog=mySmile;Server=DESKTOP-GB2S5V2;Database=mySmile;Trusted_Connection=True;";//UserID=UserName;Password=Password";

            cnn = new SqlConnection(connetionString);
            try
            {
                cnn.Open();
                String q = "select p.Name,a.StartTime,a.EndTime,a.Appointment_id from  appointment a ,Patient p where a.Patient_id=p.Patient_id and a.Date=CONVERT(date, getdate()) and  Dentist_id='" + Session["user"].ToString() + "' and Canceled=0 ";
                SqlDataAdapter sqlDa = new SqlDataAdapter(q, cnn);
                DataTable dtbl = new DataTable();
                sqlDa.Fill(dtbl);
                GridViewtoday.DataSource = dtbl;
                GridViewtoday.DataBind();

            }

            catch (Exception ex)
            {
                ScriptManager.RegisterClientScriptBlock(Page, this.GetType(), "MessageBox", "alert('Can not open connection !')" + ex, true);
            }
        }
    }
}