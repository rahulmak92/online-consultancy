using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class ClientLogin : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        
    }
    protected void Button1_Click(object sender, EventArgs e)
    {
        

        Captcha1.ValidateCaptcha(txtCaptcha.Text.Trim());

        if (Captcha1.UserValidated)
        {
            User user = ConnectionClass.LoginUser(txtName.Text, txtPassword.Text);
            if (user != null)
            {
                if (user.Role == "client")
                {
                    
                    if (user.Active == 1)
                    {
                        Session["login"] = user.UserName;
                        Response.Redirect("Default.aspx");
                    }
                    else
                    {
                        lblError.ForeColor = System.Drawing.Color.Red;
                        lblError.Text = "User is not Active, Contact your consultant";

                    }
                }
                else
                {
                    Session["admin"] = user.UserName;
                    Response.Redirect("~/Admin/AdminHome.aspx");
                }
            }
            else
            {
                lblError.ForeColor = System.Drawing.Color.Red;
                lblError.Text = "Username and Password didn't match";
                txtName.Text = "";
            }
        }

        else 
        {
            lblError.ForeColor = System.Drawing.Color.Red;
            lblError.Text = "Invalid characters. Try Again!";
            txtName.Text = "";
        }
        
    }
}