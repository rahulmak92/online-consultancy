using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class MasterPageLogin : System.Web.UI.MasterPage
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (Session["login"] != null)
        {
            if (Session["gujarati"] == null)
            {
                lblLogout.Text = "Welcome, " + Session["login"].ToString();
            }
            else
            {
                lblLogout.Text = "સુસ્વાગતમ્, " + Session["login"].ToString();
            }
            lblLogout.Visible = true;
            LinkButton1.Text = "Logout";
            LinkButton1.Visible = true;
        }
        else
        {
            lblLogout.Visible = false;
            LinkButton1.Visible = false;
        }
        
    }

    protected void LinkButton1_Click(object sender, EventArgs e)
    {
        if (LinkButton1.Text == "Logout")
        {
            Session.Remove("login");
            Response.Redirect("Default.aspx");
        }
    }
   
}
