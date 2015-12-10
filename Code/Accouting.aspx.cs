using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Accouting : System.Web.UI.Page
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
        Response.Redirect("AccountingRequest.aspx");
    }
    protected void Button2_Click(object sender, EventArgs e)
    {
        Response.Redirect("AccountingRequestHistory.aspx");
    }
}