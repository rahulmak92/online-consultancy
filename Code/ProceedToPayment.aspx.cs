using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Windows.Forms;

public partial class ProceedToPayment : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

        if (Session["login"] == null)
        {
            Response.Redirect("ClientLogin.aspx");
        }
        else
        {
            lblLogin.Text = Session["login"].ToString();
        }
    }
    protected void LinkButton1_Click(object sender, EventArgs e)
    {
        Session.Remove("login");
        Response.Redirect("Default.aspx");
    }
    protected void foo_Click(object sender, ImageClickEventArgs e)
    {
        Label1.Text = "Hello";
        Label1.Visible = true;
    }
}