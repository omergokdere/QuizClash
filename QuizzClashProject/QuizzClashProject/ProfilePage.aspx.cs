using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace QuizzClashProject
{
    public partial class ProfilePage : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            string loginCheck = (string)Session["loginCheck"];
            string emailCheck = (string)Session["emailCheck"];

            if (loginCheck == null)
            {
                Response.Redirect("LoginPage.aspx");
            }

            lblEmail.Text = emailCheck.ToString();
            lblUserName.Text = loginCheck.ToString();
        }
    }
}