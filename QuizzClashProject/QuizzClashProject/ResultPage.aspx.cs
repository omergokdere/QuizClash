using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace QuizzClash
{
    public partial class ResultPage : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

            if (!IsPostBack)
            {


                string loginCheck = (string)Session["loginCheck"];
                if (loginCheck == null)
                {
                    Response.Redirect("LoginPage.aspx");
                }


                int correctAnswer = (int)Session["correctAnswer"];
                int counterQuestion = (int)Session["counter"];
                string idCheck = (string)Session["idCheck"];


                lblResult.Text = correctAnswer.ToString();
                lblResult2.Text = counterQuestion.ToString();

                SqlConnection connection = new SqlConnection(System.Configuration.ConfigurationManager.ConnectionStrings["quizzClashConnection"].ConnectionString);
                connection.Open();


                SqlCommand cmdInsertScore1 = new SqlCommand("SELECT top 1 min(scores) from score where idUser=@idCheck and difficulty='Easy';", connection);
                cmdInsertScore1.Parameters.AddWithValue("@correctAnswer", correctAnswer);
                cmdInsertScore1.Parameters.AddWithValue("@idCheck", idCheck);
                cmdInsertScore1.ExecuteNonQuery();

                DataSet ds1 = new DataSet();
                SqlDataAdapter adapter1 = new SqlDataAdapter(cmdInsertScore1);
                adapter1.Fill(ds1);

                int easy = Convert.ToInt32(ds1.Tables[0].Rows[0][0]);
                if (correctAnswer >= easy)
                {
                    if (counterQuestion == 5)
                    {
                        SqlCommand cmdInsertScore11 = new SqlCommand("UPDATE TOP (1) score set scores = @correctAnswer where scores=(select top 1 min(scores) from score where idUser=@idCheck and difficulty='Easy') and idUser= @idCheck and difficulty='Easy'; ", connection);
                        cmdInsertScore11.Parameters.AddWithValue("@correctAnswer", correctAnswer);
                        cmdInsertScore11.Parameters.AddWithValue("@idCheck", idCheck);
                        cmdInsertScore11.ExecuteNonQuery();
                    }
                }
                SqlCommand cmdInsertScore2 = new SqlCommand("SELECT top 1 min(scores) from score where idUser=@idCheck and difficulty='Easy';", connection);
                cmdInsertScore2.Parameters.AddWithValue("@correctAnswer", correctAnswer);
                cmdInsertScore2.Parameters.AddWithValue("@idCheck", idCheck);
                cmdInsertScore2.ExecuteNonQuery();

                DataSet ds2 = new DataSet();
                SqlDataAdapter adapter2 = new SqlDataAdapter(cmdInsertScore2);
                adapter2.Fill(ds2);

                int medium = Convert.ToInt32(ds2.Tables[0].Rows[0][0]);
                if (correctAnswer >= medium)
                {
                    if (counterQuestion == 10)
                    {
                        SqlCommand cmdInsertScore22 = new SqlCommand("UPDATE TOP (1) score set scores = @correctAnswer where scores=(select top 1 min(scores) from score where idUser=@idCheck and difficulty='Medium') and idUser= @idCheck and difficulty='Medium'; ", connection);
                        //MYSQL QUERY //"UPDATE score set scores = @correctAnswer where scores=(select min(scores)) and idUser= @idCheck and difficulty='Medium' order by scores asc limit 1; ", connection);
                        cmdInsertScore22.Parameters.AddWithValue("@correctAnswer", correctAnswer);
                        cmdInsertScore22.Parameters.AddWithValue("@idCheck", idCheck);
                        cmdInsertScore22.ExecuteNonQuery();
                    }
                }
                SqlCommand cmdInsertScore3 = new SqlCommand("SELECT top 1 min(scores) from score where idUser=@idCheck and difficulty='Easy';", connection);
                cmdInsertScore3.Parameters.AddWithValue("@correctAnswer", correctAnswer);
                cmdInsertScore3.Parameters.AddWithValue("@idCheck", idCheck);
                cmdInsertScore3.ExecuteNonQuery();

                DataSet ds3 = new DataSet();
                SqlDataAdapter adapter3 = new SqlDataAdapter(cmdInsertScore3);
                adapter3.Fill(ds3);

                int hard = Convert.ToInt32(ds3.Tables[0].Rows[0][0]);
                if (correctAnswer >= hard)
                {
                    if (counterQuestion == 15)
                        {
                            SqlCommand cmdInsertScore33 = new SqlCommand("UPDATE TOP (1) score set scores = @correctAnswer where scores=(select top 1 min(scores) from score where idUser=@idCheck and difficulty='Hard') and idUser= @idCheck and difficulty='Hard'; ", connection);
                            cmdInsertScore33.Parameters.AddWithValue("@correctAnswer", correctAnswer);
                            cmdInsertScore33.Parameters.AddWithValue("@idCheck", idCheck);
                            cmdInsertScore33.ExecuteNonQuery();
                        }
                }

                connection.Close();

            }
        }

        protected void btnPlayAgain_Click(object sender, EventArgs e)
        {
            Response.Redirect("DifficultyPage.aspx");

        }

        protected void btnGoBackToMenu_Click(object sender, EventArgs e)
        {
            Response.Redirect("MenuPage.aspx");
        }
    }
}