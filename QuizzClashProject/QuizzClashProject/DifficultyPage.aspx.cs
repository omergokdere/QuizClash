using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace QuizzClash
{
    public partial class DifficultyPage : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            string loginCheck = (string)Session["loginCheck"];
            if (loginCheck == null)
            {
                Response.Redirect("LoginPage.aspx");
            }

        }

        protected void btnEasyID_Click(object sender, EventArgs e)
        {
            Response.Redirect("EasyQuizPage.aspx");
        }

        protected void btnMediumID_Click(object sender, EventArgs e)
        {
            Response.Redirect("MediumQuizPage.aspx");

        }

        protected void btnHardID_Click(object sender, EventArgs e)
        {
            Response.Redirect("HardQuizPage.aspx");

        }

        protected void btnGoBackToMenu_Click(object sender, EventArgs e)
        {
            Response.Redirect("MenuPage.aspx");
        }
    }
}