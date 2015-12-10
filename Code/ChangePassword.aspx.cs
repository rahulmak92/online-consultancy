using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class ChangePassword : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (Session["login"] == null)
        {
            Response.Redirect("ClientLogin.aspx");
        }
    }

    protected void Button1_Click(object sender, EventArgs e)
    {

        if (TextBox2.Text != TextBox3.Text)
        {
            Label1.Text = "Password and Confirm Password fields must match";
        }
        else
        {
            string result = ConnectionClass.ChangePasswordbyUser(Session["login"].ToString(), TextBox1.Text, TextBox2.Text);
            Label1.Text = result;
        }
    }
    protected void Button2_Click(object sender, EventArgs e)
    {
        TextBox1.Text = "";
        TextBox3.Text = "";
        TextBox2.Text = "";
    }
}