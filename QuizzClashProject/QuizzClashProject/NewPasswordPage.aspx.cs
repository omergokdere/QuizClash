using System;
using System.Collections.Generic;
using System.Data.OleDb;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using MySql.Data.MySqlClient;
using System.Data.SqlClient;

namespace QuizzClash
{
    public partial class NewPasswordPage : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
           
        }

        protected void SavePasswordButton_Click(object sender, EventArgs e)
        {


            string idFromPreviousPage = Request.QueryString["id"];
            int userID = Convert.ToInt32(idFromPreviousPage);
            if (NewPassword.Text == ConfirmNewPassword.Text)
            {


                SqlConnection connection = new SqlConnection(System.Configuration.ConfigurationManager.ConnectionStrings["quizzClashConnection"].ConnectionString);
                connection.Open();

                SqlCommand cmdUpdate = new SqlCommand("UPDATE users SET userpass=@password WHERE userID=@userID;", connection);
                cmdUpdate.Parameters.AddWithValue("@password", NewPassword.Text);
                cmdUpdate.Parameters.AddWithValue("@userID", userID);
                cmdUpdate.ExecuteNonQuery();
                Response.Redirect("LoginPage.aspx");

            }
            else
            {
                Response.Redirect("NewPasswordPage.aspx");
            }
        }
    }
}