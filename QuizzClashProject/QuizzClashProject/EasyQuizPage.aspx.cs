using System;
using System.Collections.Generic;
using System.Data;
using System.Data.OleDb;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using MySql.Data.MySqlClient;
using System.Timers;
using System.Web.UI.HtmlControls;
using System.Data.SqlClient;

namespace QuizzClash
{
    public partial class EasyQuizPage_aspx : System.Web.UI.Page
    {
        int questID =0;
        int correctAnswer=0;
        int counter=0;

        protected void Page_Load(object sender, EventArgs e)
        {

            string loginCheck = (string)Session["loginCheck"];
            if (loginCheck == null)
            {
                Response.Redirect("LoginPage.aspx");
            }

            txtQuestion.Visible = false;
            btnAnswer1.Visible = false;
            btnAnswer2.Visible = false;
            btnAnswer3.Visible = false;
            btnAnswer4.Visible = false;
            category.Visible = false;


            if (!IsPostBack)
            {
                Session["counter"] = counter;
                Session["correctAnswer"] = correctAnswer;
            }
        }

        protected void btnAnswer1_Click(object sender, EventArgs e)
        {
            questID = (int)Session["questID"];
            counter = (int)Session["counter"];
            correctAnswer = (int)Session["correctAnswer"];
            counter++;

            SqlConnection connection = new SqlConnection(System.Configuration.ConfigurationManager.ConnectionStrings["quizzClashConnection"].ConnectionString);
            connection.Open();

            SqlCommand cmd = new SqlCommand("SELECT canswer FROM  quiz WHERE questionID=@x ");
            cmd.Parameters.AddWithValue("@x", questID);
            cmd.Connection = connection;

            DataSet ds = new DataSet();
            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
            adapter.Fill(ds);

            string canswer = ds.Tables[0].Rows[0]["canswer"].ToString();

            if (btnAnswer1.Text == canswer)
            {
                correctAnswer++;

            }
            else
            {

            }
            connection.Close();
            Session["correctAnswer"] = correctAnswer;
            Session["counter"] = counter;
            btnStartGame_Click(sender, e);
        }

        protected void btnAnswer2_Click(object sender, EventArgs e)
        {
            questID = (int)Session["questID"];
            counter = (int)Session["counter"];
            correctAnswer = (int)Session["correctAnswer"];
            counter++;

            SqlConnection connection = new SqlConnection(System.Configuration.ConfigurationManager.ConnectionStrings["quizzClashConnection"].ConnectionString);
            connection.Open();

            SqlCommand cmd = new SqlCommand("SELECT canswer FROM  quiz WHERE questionID=@x ");
            cmd.Parameters.AddWithValue("@x", questID);
            cmd.Connection = connection;

            DataSet ds = new DataSet();
            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
            adapter.Fill(ds);

            string canswer = ds.Tables[0].Rows[0]["canswer"].ToString();

            if (btnAnswer2.Text == canswer)
            {
                correctAnswer++;

            }
            else
            {

            }
            connection.Close();
            Session["correctAnswer"] = correctAnswer;
            Session["counter"] = counter;

            btnStartGame_Click(sender, e);

        }

        protected void btnAnswer3_Click(object sender, EventArgs e)
        {
            questID = (int)Session["questID"];
            counter = (int)Session["counter"];
            correctAnswer = (int)Session["correctAnswer"];
            counter++;

            SqlConnection connection = new SqlConnection(System.Configuration.ConfigurationManager.ConnectionStrings["quizzClashConnection"].ConnectionString);
            connection.Open();

            SqlCommand cmd = new SqlCommand("SELECT canswer FROM  quiz WHERE questionID=@x ");
            cmd.Parameters.AddWithValue("@x", questID);
            cmd.Connection = connection;

            DataSet ds = new DataSet();
            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
            adapter.Fill(ds);

            string canswer = ds.Tables[0].Rows[0]["canswer"].ToString();

            if (btnAnswer3.Text == canswer)
            {
                correctAnswer++;

            }
            else
            {

            }
            connection.Close();
            Session["correctAnswer"] = correctAnswer;
            Session["counter"] = counter;

            btnStartGame_Click(sender, e);

        }

        protected void btnAnswer4_Click(object sender, EventArgs e)
        {
            questID = (int)Session["questID"];
            counter = (int)Session["counter"];
            correctAnswer = (int)Session["correctAnswer"];

            counter++;

            SqlConnection connection = new SqlConnection(System.Configuration.ConfigurationManager.ConnectionStrings["quizzClashConnection"].ConnectionString);
            connection.Open();

            SqlCommand cmd = new SqlCommand("SELECT canswer FROM  quiz WHERE questionID=@x ");
            cmd.Parameters.AddWithValue("@x", questID);
            cmd.Connection = connection;

            DataSet ds = new DataSet();
            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
            adapter.Fill(ds);

            string canswer = ds.Tables[0].Rows[0]["canswer"].ToString();

            if (btnAnswer4.Text == canswer)
            {
                correctAnswer++;

            }
            else
            {

            }
            connection.Close();
            Session["correctAnswer"] = correctAnswer;
            Session["counter"] = counter;

            btnStartGame_Click(sender, e);
        }

        protected void btnStartGame_Click(object sender, EventArgs e)
        {
            counter = (int)Session["counter"];
            correctAnswer = (int)Session["correctAnswer"];
            if (counter >= 5)
            {
                string url = string.Format("ResultPage.aspx?counter={0},correctAnswer={1}", counter,correctAnswer);
                Response.Redirect(url);
            }

            txtQuestion.Visible = true;
            txtQuestion.Enabled = false;
            btnAnswer1.Visible = true;
            btnAnswer2.Visible = true;
            btnAnswer3.Visible = true;
            btnAnswer4.Visible = true;
            category.Visible = true;
            btnStartGame.Visible = false;
            btnGoBackToMenu1.Visible = false;

            SqlConnection connection = new SqlConnection(System.Configuration.ConfigurationManager.ConnectionStrings["quizzClashConnection"].ConnectionString);
            connection.Open();

            SqlCommand cmd = new SqlCommand("SELECT TOP 1 * FROM quiz where difficulty='easy' ORDER BY NEWID() ");
            cmd.Connection = connection;

            System.Random rnd = new System.Random();
            var numbers = Enumerable.Range(2, 4).OrderBy(r => rnd.Next()).ToArray();

            DataSet ds = new DataSet();
            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
            adapter.Fill(ds);
            questID = Convert.ToInt32(ds.Tables[0].Rows[0]["questionID"]);
            txtQuestion.Text = ds.Tables[0].Rows[0]["question"].ToString();

            //string[] shuffle = new string[4];
            //shuffle[0] = ds.Tables[0].Rows[0]["canswer"].ToString();
            //shuffle[1] = ds.Tables[0].Rows[0]["canswer"].ToString();
            //shuffle[2] = ds.Tables[0].Rows[0]["canswer"].ToString();
            //shuffle[3] = ds.Tables[0].Rows[0]["canswer"].ToString();

            //Shuffle(shuffle);
            btnAnswer1.Text = ds.Tables[0].Rows[0][numbers[1]].ToString();
            btnAnswer2.Text = ds.Tables[0].Rows[0][numbers[2]].ToString();
            btnAnswer3.Text = ds.Tables[0].Rows[0][numbers[3]].ToString();
            btnAnswer4.Text = ds.Tables[0].Rows[0][numbers[0]].ToString();
            lblCategoryQuestion.Text = ds.Tables[0].Rows[0]["category"].ToString();

            connection.Close();

            Session["questID"] = questID;

        }

        protected void btnGoBackToMenu1_Click(object sender, EventArgs e)
        {
            Response.Redirect("MenuPage.aspx");
        }

        public static void Shuffle<T>(T[] array)
        {
            int n = array.Length;
            Random rng = new Random();
            while (n > 1)
            {
                int k = rng.Next(n--);
                T temp = array[n];
                array[n] = array[k];
                array[k] = temp;
            }
        }
    }

}