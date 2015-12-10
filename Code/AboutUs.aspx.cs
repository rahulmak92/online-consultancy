using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web.UI.HtmlControls;

public partial class AboutUs : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        HtmlAnchor b = (HtmlAnchor)this.Page.Master.FindControl("company");
        b.Style.Add("font-weight", "bold");
        b.Style.Add("color", "orange");
    }
}