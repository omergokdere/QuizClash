using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web.Security;
using System.Data.SqlClient;

namespace QuizzClash
{
    public partial class ScoresPage : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            
            string idCheck = (string)Session["idCheck"];
            string loginCheck = (string)Session["loginCheck"];
            if (loginCheck == null)
            {
                Response.Redirect("LoginPage.aspx");
            }
            else
            {
                btnProfile.Text = (string)Session["loginCheck"];
            }

            HttpContext.Current.Response.Cache.SetExpires(DateTime.UtcNow.AddDays(-1));
            HttpContext.Current.Response.Cache.SetValidUntilExpires(false);
            HttpContext.Current.Response.Cache.SetRevalidation(HttpCacheRevalidation.AllCaches);
            HttpContext.Current.Response.Cache.SetCacheability(HttpCacheability.NoCache);
            HttpContext.Current.Response.Cache.SetNoStore();

            SqlConnection connection = new SqlConnection(System.Configuration.ConfigurationManager.ConnectionStrings["quizzClashConnection"].ConnectionString);
            connection.Open();

            SqlCommand cmdScores = new SqlCommand("SELECT scores,difficulty from score where iduser=@idCheck and scores > 0 order by scores desc", connection);
            cmdScores.Parameters.AddWithValue("@idCheck", idCheck);
            SqlDataReader dr = cmdScores.ExecuteReader();
            gvTopScoresID.DataSource = dr;
            gvTopScoresID.DataBind();
            connection.Close();

        }

        protected void btnProfile_Click(object sender, EventArgs e)
        {
            Response.Redirect("ProfilePage.aspx");
        }

        protected void btnLogout_Click(object sender, EventArgs e)
        {
            Session.Abandon();//Abandon session
            FormsAuthentication.SignOut();
            Session["loginCheck"] = null;
            Response.Redirect("LoginPage.aspx");
        }

        protected void btnGoBackToMenu_Click(object sender, EventArgs e)
        {
            Response.Redirect("MenuPage.aspx");
        }

    }
}