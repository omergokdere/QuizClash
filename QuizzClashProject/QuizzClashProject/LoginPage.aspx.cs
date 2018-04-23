using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.OleDb;
using System.Data;
using MySql.Data.MySqlClient;
using System.Data.SqlClient;

namespace QuizzClash
{
    public partial class LoginPage : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }
        protected void LoginButtonClicked(object sender, EventArgs e)
        {
            //string connectionString = System.Configuration.ConfigurationManager.AppSettings["quizzClashConnection"].ToString(); //ToString here is optional unless you're doing some weirdness in the web.config
            SqlConnection connection = new SqlConnection(System.Configuration.ConfigurationManager.ConnectionStrings["quizzClashConnection"].ConnectionString);

            //connection.ConnectionString = "server=localhost;user id=root;password=oracle;persistsecurityinfo=True;database=user;port=3306";
            connection.Open();

            SqlCommand cmd = new SqlCommand("select * from users where username like @username and userpass = @password;");
            cmd.Parameters.AddWithValue("@username", UserName.Text);
            cmd.Parameters.AddWithValue("@password", Password.Text);
            cmd.Connection = connection;


            DataSet ds = new DataSet();
            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
            adapter.Fill(ds);
            connection.Close();
            bool loginSuccessful = ((ds.Tables.Count > 0) && (ds.Tables[0].Rows.Count > 0));

            if (loginSuccessful)
            {

                string loginCheck = UserName.Text.ToString();
                string emailCheck = ds.Tables[0].Rows[0]["useremail"].ToString();
                string idCheck = ds.Tables[0].Rows[0]["userID"].ToString();
                Session["idCheck"] = idCheck.ToString();
                Session["loginCheck"] = loginCheck.ToString();
                Session["emailCheck"] = emailCheck.ToString();
                Response.Redirect("MenuPage.aspx");

            }
            else
            {
                Response.Write("<script>alert('WRONG USERNAME OR PASSWORD);</script>");
                Response.Redirect("LoginPage.aspx");
            }


        }
    }
}