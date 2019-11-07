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
    public partial class mybookings : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
             if (Session["user"] != null)
            {
                string connetionString = null;
                SqlConnection cnn;
                connetionString = "Data Source=.;Initial Catalog=mySmile;Server=DESKTOP-GB2S5V2;Database=mySmile;Trusted_Connection=True;";//UserID=UserName;Password=Password";

                cnn = new SqlConnection(connetionString);
                try
                {
                    cnn.Open();
                    ////////////////upcomming///////////////////
                    String q = "select d.name,a.Dentist_id,a.Date,a.StartTime,a.EndTime,a.Appointment_id from  appointment a , Dentist d where a.Dentist_id=d.Dentist_id and Date>=CONVERT(date, getdate()) and Patient_id='" + Session["user"].ToString() + "' and Canceled=0 ";
                    SqlDataAdapter sqlDa = new SqlDataAdapter(q, cnn);
                    DataTable dtbl = new DataTable();
                    sqlDa.Fill(dtbl);
                    GridView1.DataSource = dtbl;
                    GridView1.DataBind();
                    Label2.Visible = true;
                    ////////////////old/////////////////////////
                    String s = "select d.name,a.Dentist_id,a.Date,a.StartTime,a.EndTime from  appointment a , Dentist d where a.Dentist_id=d.Dentist_id and Date <CONVERT(date, getdate()) and Patient_id='" + Session["user"].ToString() + "' and Canceled=0 ";
                    SqlDataAdapter sqlDa2 = new SqlDataAdapter(s, cnn);
                    DataTable dtbl2 = new DataTable();
                    sqlDa2.Fill(dtbl2);
                    GridView2.DataSource = dtbl2;
                    GridView2.DataBind();
                    Label1.Visible = true;
                    //////////////canceled//////////////////////
                    String l = "select d.name,a.Dentist_id,a.Date,a.StartTime,a.EndTime from  appointment a , Dentist d where a.Dentist_id=d.Dentist_id and Patient_id='" + Session["pid"].ToString() + "' and Canceled=1 ";
                    SqlDataAdapter sqlDa3 = new SqlDataAdapter(l, cnn);
                    DataTable dtbl3 = new DataTable();
                    sqlDa3.Fill(dtbl3);
                    GridView3.DataSource = dtbl3;
                    GridView3.DataBind();
                    Label3.Visible = true;
                    cnn.Close();

                    int r1 = Convert.ToInt32(GridView1.Rows.Count.ToString());
                    int r2 = Convert.ToInt32(GridView2.Rows.Count.ToString());
                    int r3 = Convert.ToInt32(GridView3.Rows.Count.ToString());
                    if (r1 > 0 || r2 > 0 || r3 > 0)
                    {

                    }
                    else
                    {
                        noapplabel.Visible = true;
                        Label3.Visible =false;
                        Label2.Visible = false;
                        Label1.Visible = false;
                    }
                }
                catch (Exception ex)
                {
                    ScriptManager.RegisterClientScriptBlock(Page, this.GetType(), "MessageBox", "alert('Can not open connection !')" + ex, true);
                }

            }
            else
                login.Visible = true;
        }
        
    

        protected void lnkCancel_Click(object sender, EventArgs e)
        {
            int appID = Convert.ToInt32((sender as LinkButton).CommandArgument);
            string connetionString = null;
            SqlConnection cnn;
            connetionString = "Data Source=.;Initial Catalog=mySmile;Server=DESKTOP-GB2S5V2;Database=mySmile;Trusted_Connection=True;";//UserID=UserName;Password=Password";

            cnn = new SqlConnection(connetionString);
            try
            {
                cnn.Open();

                String q = "update appointment set Canceled=1 where Appointment_id='" +appID+ "' ";
                SqlCommand cmd = new SqlCommand(q, cnn);
                int check = cmd.ExecuteNonQuery();
                //if(check==0)
                  GridView1.DataBind();
                 
                cnn.Close();
            }
            catch (Exception ex)
            {
                ScriptManager.RegisterClientScriptBlock(Page, this.GetType(), "MessageBox", "alert('Can not open connection !')" + ex, true);
            }
        }
        }
    }
