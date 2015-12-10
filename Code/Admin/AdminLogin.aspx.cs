using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Admin_AdminLogin : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }
    protected void Button1_Click(object sender, EventArgs e)
    {
        User user=ConnectionClass.LoginUser(TextBox1.Text,TextBox2.Text);
        
        if (user != null)
        {
            Session["admin"] = user.UserName;
            Response.Redirect("AdminHome.aspx");
        }
        else
        {

            Label1.ForeColor = System.Drawing.Color.Red;
           
            Label1.Text = "Invalid Username and Password";
        }
    }
}