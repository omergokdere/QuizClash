using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace QuizzClash
{
    public partial class MenuPage : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
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

        }

        protected void btnPlayID_Click(object sender, EventArgs e)
        {
            Response.Redirect("DifficultyPage.aspx");
        }

        protected void btnTopScoresID_Click(object sender, EventArgs e)
        {
            Response.Redirect("ScoresPage.aspx");

        }

        protected void btnAboutID_Click(object sender, EventArgs e)
        {
            Response.Redirect("AboutPage.aspx");

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
    }
}