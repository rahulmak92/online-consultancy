using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Net;
using System.Net.Mail;

public partial class ForgotPassword : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }
    protected void Button1_Click(object sender, EventArgs e)
    {
        User user = ConnectionClass.GetUserByName(TextBox1.Text);
        if (user == null)
        {
            Label1.Text = "User not found";
        }
        else
        {
            string email = user.Email;
            try
            {
                var to = email;
                var from = "consultancyhouse2015@gmail.com";
                const string password = "y70j9jk2";
                string subject = "Consultancy House Client Login Password Recovery for :" + user.UserName;
                string body = " Consultancy House Login \n Password Recovery\n";
                body += "Your login Credentials : \n";
                body += "Username: " + user.UserName + "\n";
                body += "Password: " + user.Password + "\n\n";
                body += "If any query please reply on this same mail";
                var smtp = new System.Net.Mail.SmtpClient();
                {
                    smtp.Host = "smtp.gmail.com";
                    smtp.Port = 587;
                    smtp.EnableSsl = true;
                    smtp.DeliveryMethod = System.Net.Mail.SmtpDeliveryMethod.Network;
                    smtp.Credentials = new NetworkCredential(from, password);
                    smtp.Timeout = 20000;
                }

                smtp.Send(from, to, subject, body);
                Label1.Text = "Request for Password Recovery successfully submitted.We'll shortly contact you at your registered email.";
                TextBox1.Text = "";
            }
            catch (Exception)
            {

            }

        }
    }
    protected void Button2_Click(object sender, EventArgs e)
    {
        Response.Redirect("Default.aspx");
    }
}