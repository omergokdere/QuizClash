using System;
using System.Collections.Generic;
using System.Data;
using System.Data.OleDb;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Net.Mail;
using System.Data.SqlClient;

namespace QuizzClash
{
    public partial class CreateUserPage : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void CreateUserButtonID_Click(object sender, EventArgs e)
        {
            SqlConnection connection = new SqlConnection(System.Configuration.ConfigurationManager.ConnectionStrings["quizzClashConnection"].ConnectionString);
            connection.Open();

            SqlCommand cmdUserNameCheck = new SqlCommand("select * from users where username like @username;");
            cmdUserNameCheck.Parameters.AddWithValue("@username", UserName.Text);
            cmdUserNameCheck.Connection = connection;

            SqlCommand cmdEmailCheck = new SqlCommand("select * from users where useremail like @email;");
            cmdEmailCheck.Parameters.AddWithValue("@email", Email.Text);
            cmdEmailCheck.Connection = connection;

            DataSet ds = new DataSet();
            SqlDataAdapter adapter = new SqlDataAdapter(cmdUserNameCheck);
            adapter.Fill(ds);

            DataSet ds1 = new DataSet();
            SqlDataAdapter adapter1 = new SqlDataAdapter(cmdEmailCheck);
            adapter1.Fill(ds1);

            bool usernameExist = ((ds.Tables.Count > 0) && (ds.Tables[0].Rows.Count > 0));
            bool emailExist = ((ds1.Tables.Count > 0) && (ds1.Tables[0].Rows.Count > 0));

            if (usernameExist && emailExist)
            {
                Response.Write("<script>alert('Username and Email are already exist !!!');</script>");
                Response.Redirect("CreateUserPage.aspx");
            }
            else if (usernameExist)
            {
                Response.Write("<script>alert('Username is already exist !!!');</script>");
                Response.Redirect("CreateUserPage.aspx");

            }
            else if (emailExist)
            {
                Response.Write("<script>alert('Email is already exist !!!');</script>");
                Response.Redirect("CreateUserPage.aspx");

            }
            else if (Email.Text.Contains("@"))
            {
                SqlCommand cmdInsert = new SqlCommand("INSERT INTO users (username,userpass,useremail) VALUES  ('" + UserName.Text.Trim() + "','" + Password.Text.Trim() + "','" + Email.Text.Trim() + "')", connection);
                //cmdInsert.Parameters.AddWithValue("@username1", UserName.Text);
                //cmdInsert.Parameters.AddWithValue("@password1", Password.Text);
                //cmdInsert.Parameters.AddWithValue("@email1", Email.Text);
                cmdInsert.ExecuteNonQuery();
                SqlCommand cmdUserIDCheck = new SqlCommand("select userID from users where username like @username;");
                cmdUserIDCheck.Parameters.AddWithValue("@username", UserName.Text);
                cmdUserIDCheck.Connection = connection;

                DataSet ds2 = new DataSet();
                SqlDataAdapter adapter2 = new SqlDataAdapter(cmdUserIDCheck);
                adapter2.Fill(ds2);


                string userID = ds2.Tables[0].Rows[0]["userID"].ToString();
                for (int i = 0; i <= 4; i++)
                {
                    SqlCommand cmdInsertScore = new SqlCommand("INSERT INTO score (idUser,scores,difficulty) VALUES  (@userID,'0','Easy')", connection);
                    cmdInsertScore.Parameters.AddWithValue("@userID", userID);
                    cmdInsertScore.ExecuteNonQuery();
                }
                for (int j = 0; j <= 4; j++)
                {
                    SqlCommand cmdInsertScore = new SqlCommand("INSERT INTO score (idUser,scores,difficulty) VALUES  (@userID,'0','Medium')", connection);
                    cmdInsertScore.Parameters.AddWithValue("@userID", userID);
                    cmdInsertScore.ExecuteNonQuery();
                }
                for (int k = 0; k <= 4; k++)
                {
                    SqlCommand cmdInsertScore = new SqlCommand("INSERT INTO score (idUser,scores,difficulty) VALUES  (@userID,'0','Hard')", connection);
                    cmdInsertScore.Parameters.AddWithValue("@userID", userID);
                    cmdInsertScore.ExecuteNonQuery();
                }
                Response.Write("<script>alert('Your account has been successfuly created !!!');</script>");
                //string random = genCode();
                //sendMsg(Email.ToString(), UserName.ToString(), Password.ToString(), random);

                //Session["userEmail"] = Email.ToString();

                Response.Redirect("LoginPage.aspx");

            }
            else
            {
                Response.Write("<script>alert('Email format is wrong !!!');</script>");
                Response.Redirect("CreateUserPage.aspx");
            }

        }
        /*
        #region generate random number
        //Generate Random Number
        public String genCode()
        {
            var chars = "ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyz0123456789";
            var stringChars = new char[8];
            var random = new Random();

            for (int i = 0; i < stringChars.Length; i++)
            {
                stringChars[i] = chars[random.Next(chars.Length)];
            }

            var finalString = new String(stringChars);
            return finalString;
        }
        #endregion
        /*
        #region send email

        //send email
        public static void sendMsg(string email, string username, string pass, string random)
        {

            SmtpClient smtp = new SmtpClient();
            smtp.Host = "smtp.gmail.com";
            smtp.Port = 587;
            smtp.Credentials = new System.Net.NetworkCredential("omergokdere13@gmail.com", "Quizzclash");
            smtp.EnableSsl = true;

            MailMessage msg = new MailMessage();
            msg.Subject = "Hello " + username;
            msg.Body = "Hello " + username + "Thanks for Registering in QuizzClash...Your Account Details are given below:";
            msg.Body += "<tr>";
            msg.Body += "<td>User Name :" + username + "</td>";
            msg.Body += "</tr>";
            msg.Body += "<tr>";
            msg.Body += "<td>Password :" + pass + "</td>";
            msg.Body += "</tr>";
            msg.Body += "<tr>";
            msg.Body += "<td>Activation Number :" + random + "</td>";
            msg.Body += "</tr>";

            msg.Body += "<tr>";
            msg.Body += "<td>Thanking</td><td>Team QuizzClash</td>";
            msg.Body += "</tr>";

            string toAddress = "omrgkdr13@gmail.com"; // Add Recepient address
            msg.To.Add(new MailAddress(toAddress));

            string fromAddress = "\"QuizzClash \" <omergokdere13@gmail.com>";
            msg.From = new MailAddress(fromAddress);
            msg.IsBodyHtml = true;

            try
            {
                smtp.Send(msg);

            }
            catch
            {
                throw;
            }
        }
        #endregion
    */
    }
}