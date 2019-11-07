using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace aspproject
{
    public partial class login : System.Web.UI.Page
    {
       
        protected void Page_Load(object sender, EventArgs e)
        {
           
        }

        protected void LogInButton_Click(object sender, EventArgs e)
        {
            // ScriptManager.RegisterClientScriptBlock(Page, this.GetType(), "MessageBox", "alert('Connection opens')", true);
         //   errorlabel.Visible = false;

            string connetionString = null;
            SqlConnection cnn;
            connetionString = "Data Source=.;Initial Catalog=mySmile;Server=DESKTOP-GB2S5V2;Database=mySmile;Trusted_Connection=True;";//UserID=UserName;Password=Password";

            cnn = new SqlConnection(connetionString);
            try
            {
                cnn.Open();
                // ScriptManager.RegisterClientScriptBlock(Page, this.GetType(), "MessageBox", "alert('Connection opens')", true);


                String q = "select  UserName , Password ,  COUNT(*) AS numofrows ,Role   from login where UserName='" + username.Text + "' and  Password ='" + password.Text + "' group by UserName , Password , Role";
                SqlCommand cmd = new SqlCommand(q, cnn);
                //cmd.Parameters.AddWithValue("@username", username.Text);
             
                SqlDataReader dataReader;
                dataReader = cmd.ExecuteReader(); //cmd.ExecuteNonQuery();
                int intNumOfRows = 0;

                while (dataReader.Read())
                {

                    if (Convert.ToString(dataReader.GetValue(3)) == "patient")
                    {
                        Session["role"] = "patient";
                    }
                    else if (Convert.ToString(dataReader.GetValue(3)) == "dentist")
                    {
                        Session["role"] = "dentist";
                    }
                    intNumOfRows = Convert.ToInt32(dataReader.GetValue(2));

                }

                if (intNumOfRows > 0)
                {
                    Session["user"] = username.Text;
                    Session["pid"] = username.Text;
                    
                    if (Session["role"].ToString() == "patient")
                    {
                        //errorlabel.Visible = false;
                        Server.Transfer("home.aspx", true);
                    }
                    else
                    {
                       // errorlabel.Visible = false;
                        Server.Transfer("BookNow2.aspx", true);
                      }

                }
                else {
                    Session["user"] = null;
                    errorlabel.Text = "Invalid Username or Password";
                }
                //   dataReader = cmd.ExecuteReader();
                // while (dataReader.Read()) { 
                //   MessageBox.Show(dataReader.GetValue(0) + " - " + dataReader.GetValue(1) + " - " + dataReader.GetValue(2)); 
                //} 
                dataReader.Close();
                cmd.Dispose();

                cnn.Close();
            }
            catch (Exception ex)
            {
                ScriptManager.RegisterClientScriptBlock(Page, this.GetType(), "MessageBox", "alert('Can not open connection !')" + ex, true);
                //  //ScriptManager.RegisterClientScriptBlock(Page, this.GetType(), "MessageBox", "alert('added succ')", true);
            }


        }




    }
}