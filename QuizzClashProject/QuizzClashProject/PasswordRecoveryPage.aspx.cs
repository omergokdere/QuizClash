using System;
using System.Collections.Generic;
using System.Data;
using System.Data.OleDb;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using MySql.Data.MySqlClient;
using System.Data.SqlClient;

namespace QuizzClash
{
    public partial class PasswordRecoveryPage : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void SubmitButton_Click(object sender, EventArgs e)
        {
            SqlConnection connection = new SqlConnection(System.Configuration.ConfigurationManager.ConnectionStrings["quizzClashConnection"].ConnectionString);
            connection.Open();

            SqlCommand cmdUserNameCheck = new SqlCommand("select userID from users where username like @username and useremail like @email;");
            cmdUserNameCheck.Parameters.AddWithValue("@username", UserName.Text);
            cmdUserNameCheck.Parameters.AddWithValue("@email", Email.Text);
            cmdUserNameCheck.Connection = connection;

            //OleDbCommand cmdEmailCheck = new OleDbCommand("select * from user where useremail like @email;");
            
            //cmdEmailCheck.Connection = connection;

            DataSet ds = new DataSet();
            SqlDataAdapter adapter = new SqlDataAdapter(cmdUserNameCheck);
            adapter.Fill(ds);

            //DataSet ds1 = new DataSet();
            //OleDbDataAdapter adapter1 = new OleDbDataAdapter(cmdEmailCheck);
            //adapter1.Fill(ds1);

            bool idExist = ((ds.Tables.Count > 0) && (ds.Tables[0].Rows.Count > 0));
            //bool emailExist = ((ds1.Tables.Count > 0) && (ds1.Tables[0].Rows.Count > 0));

            if (idExist)
            {
                //OleDbCommand cmdID = new OleDbCommand("select ID from Login where USERNAME like @username AND EMAIL like @email;");
                //cmdID.Parameters.AddWithValue("@username", UserName.Text);
                //cmdID.Parameters.AddWithValue("@email", Email.Text);
                //cmdID.Connection = connection;

                //DataSet ds2 = new DataSet();
                //OleDbDataAdapter adapter2 = new OleDbDataAdapter(cmdID);
                //adapter.Fill(ds2);
                string userID = string.Empty;
                foreach (DataRow dr in ds.Tables[0].Rows)
                {
                    userID = dr["userID"].ToString();
                }
                string url = string.Format("NewPasswordPage.aspx?id={0}",userID);
                Response.Redirect(url);
            }
            else
            {
                Response.Write("<script>alert('Wrong Username or Email');</script>");
                Response.Redirect("PasswordRecoveryPage.aspx");
            }
        }
    }
}