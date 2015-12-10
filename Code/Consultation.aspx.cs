﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Drawing;

public partial class Consultation : System.Web.UI.Page
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
        Response.Redirect("ConsultationRequest.aspx");
    }
    protected void Button2_Click(object sender, EventArgs e)
    {
        Response.Redirect("ConsultationRequestHistory.aspx");
    }
}