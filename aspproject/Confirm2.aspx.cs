using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace aspproject
{
    public partial class Confirm2 : System.Web.UI.Page
    {
        string start = "";
        static string end = "";
        static string d = "";
        static string n = "";
        static int tid = -1;
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["pid"] != null && Session["date"] != null
              && Session["time"] != null)
            {
                start = Session["time"].ToString();
                d = Session["date"].ToString();
                n = Session["pid"].ToString();
                if (start == "8:00AM")
                {
                    end = "9:00AM";
                    tid = 1;
                }
                else
                    if (start == "9:00AM")
                    {
                        end = "10:00AM";
                        tid = 2;
                    }
                    else
                        if (start == "10:00AM")
                        {
                            end = "11:00AM";
                            tid = 3;
                        }
                        else
                            if (start == "11:00AM")
                            {
                                end = "12:00PM";
                                tid = 4;
                            }
                            else
                                if (start == "12:00PM")
                                {
                                    end = "1:00PM";
                                    tid = 4;
                                }
                                else
                                    if (start == "1:00PM")
                                    {
                                        end = "2:00PM";
                                        tid = 5;
                                    }
                                    else
                                        if (start == "2:00PM")
                                        {
                                            end = "3:00PM";
                                            tid = 6;
                                        }
                                        else
                                            if (start == "3:00PM")
                                            {
                                                end = "4:00PM";
                                                tid = 7;
                                            }
                                            else
                                                if (start == "4:00PM")
                                                {
                                                    end = "5:00PM";
                                                    tid = 8;
                                                }
                                                else
                                                    if (start == "5:00PM")
                                                    {
                                                        end = "6:00PM";
                                                        tid = 9;
                                                    }
            }
            date2.Text = d;
            start2.Text = start;
            patient.Text = n;
            end2.Text = end;
        }

        protected void ConfirmBookButton_Click2(object sender, EventArgs e)
        {
            //  ScriptManager.RegisterClientScriptBlock(Page, this.GetType(), "MessageBox", "alert('Can not open connection !')" + Session["dentistId"].ToString() + start + end + tid + date, true);

            string connetionString = null;
            SqlConnection cnn;
            connetionString = "Data Source=.;Initial Catalog=mySmile;Server=DESKTOP-GB2S5V2;Database=mySmile;Trusted_Connection=True;";//UserID=UserName;Password=Password";

            cnn = new SqlConnection(connetionString);
            try
            {

                cnn.Open();
                //" + Session["pid"].ToString() + "
                String q = "insert into appointment (Patient_id,Dentist_id,StartTime,EndTime,Canceled,Date) values ('" + Session["pid"].ToString() + "','" + Session["user"].ToString() + "','" + start + "','" + end + "',0,'" + d + "')";
                String l = "insert into bookedtime values('" + Session["user"].ToString() + "','" + tid + "','" + d + "')";
                SqlCommand cmd = new SqlCommand(q, cnn);
                SqlCommand cmd2 = new SqlCommand(l, cnn);
                int check = cmd.ExecuteNonQuery();
                int check2 = cmd2.ExecuteNonQuery();

                if (check != 0 && check2 != 0)
                {

                    Response.Redirect("BookNow2.aspx");
                }


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