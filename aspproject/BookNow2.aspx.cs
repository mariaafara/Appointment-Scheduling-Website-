using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace aspproject
{
    public partial class BookNow2 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!Page.IsPostBack)
            {
                Calendar2.SelectedDate = DateTime.Now.Date;
                //for (int i = 0; i < ListBoxpatient.Items.Count; i++)
                //{
                //    if (i % 2 == 0)
                //    {
                //        ListBoxpatient.Items[i].Attributes.Add("style", "color:green;background-color:aliceblue;");
                //    }
                //    else
                //    {
                //        ListBoxpatient.Items[i].Attributes.Add("style", "color:snow;background-color:seagreen;");
                //    }
                //}
                //for (int i = 0; i < ListBoxtime.Items.Count; i++)
                //{
                //    if (i % 2 == 0)
                //    {
                //        ListBoxtime.Items[i].Attributes.Add("style", "color:green;background-color:aliceblue;");
                //    }
                //    else
                //    {
                //        ListBoxtime.Items[i].Attributes.Add("style", "color:snow;background-color:seagreen;");
                //    }
                //}

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
        protected void Selection_Change(object sender, EventArgs e)
        {
            // Clear the current text.

            ListBoxtime.Items.Clear();
            ListBoxpatient.Items.Clear();

            // Iterate through the SelectedDates collection and display the
            // dates selected in the Calendar control.
            foreach (DateTime day in Calendar2.SelectedDates)
            {

                Session["date"] = day.Date.ToShortDateString();
                ListBoxtime.Visible = true;
                ListBoxpatient.Visible = true;
                patientname.Visible = true;
                searchpatient.Visible = true;
                fillListBox();
                fillListBoxPatient();
              


            }

        }



        void fillListBoxPatient()
        {
            string connetionString = null;
            SqlConnection cnn;
            connetionString = "Data Source=.;Initial Catalog=mySmile;Server=DESKTOP-GB2S5V2;Database=mySmile;Trusted_Connection=True;";//UserID=UserName;Password=Password";

            cnn = new SqlConnection(connetionString);
            try
            {
                cnn.Open();

                String q = "select Patient_id , Name  from Patient";
                SqlCommand cmd = new SqlCommand(q, cnn);
                SqlDataReader dataReader;
                dataReader = cmd.ExecuteReader(); //cmd.ExecuteNonQuery();
                // int intNumOfRows = 0;

                while (dataReader.Read())
                {
                    //intNumOfRows = Convert.ToInt32(dataReader.GetValue(2));
                    String name = dataReader.GetString(1);//time l 0 hye id
                    ListBoxpatient.Items.Add(name);

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


        void fillListBox()
        {
            string connetionString = null;
            SqlConnection cnn;
            connetionString = "Data Source=.;Initial Catalog=mySmile;Server=DESKTOP-GB2S5V2;Database=mySmile;Trusted_Connection=True;";//UserID=UserName;Password=Password";

            cnn = new SqlConnection(connetionString);
            try
            {
                cnn.Open();

                String q = "select *  from time where timeId not in (select timeId from bookedtime where Dentist_id='" + Session["user"] + "'and Date='" + Session["date"] + "')";
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


        }

        protected void searchpatient_Click(object sender, EventArgs e)
        {
            String name = patientname.Text;  //FindMyString(name);
            if (name != "")
            {
                if (ListBoxpatient.Items.FindByValue(name) != null)
                {
                    ListBoxpatient.Items.FindByValue(name).Selected = true;
                }

            }
        }

        protected void Book_Click(object sender, EventArgs e)
        {
            Server.Transfer("Confirm2.aspx", true);
        }

        protected void ListBoxpatient_SelectedIndexChanged(object sender, EventArgs e)
        {
            string connetionString = null;
            SqlConnection cnn;
            connetionString = "Data Source=.;Initial Catalog=mySmile;Server=DESKTOP-GB2S5V2;Database=mySmile;Trusted_Connection=True;";//UserID=UserName;Password=Password";

            cnn = new SqlConnection(connetionString);
            try
            {

                cnn.Open();
                Session["pname"] = ListBoxpatient.Text;

                String q = "select Patient_id   from Patient where Name='" + Session["pname"] + "'";
                SqlCommand cmd = new SqlCommand(q, cnn);
                SqlDataReader dataReader;
                dataReader = cmd.ExecuteReader(); //cmd.ExecuteNonQuery();


                while (dataReader.Read())
                {

                    Session["pid"] = dataReader.GetString(0);


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
    }
}