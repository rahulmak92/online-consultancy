using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Collections;

public partial class NewsPage : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        
        ArrayList list = new ArrayList();
        if (Session["gujarati"] == null)
        {
            list = ConnectionClass.GetFullNews("NewsManagement");
        }
        else
        {
            list = ConnectionClass.GetFullNews("NewsManagementGujarati");
        }
        int length = list.Count;

        for (int i = 0; i < length; i++)
        {
            Label lbl = new Label();
            if (i % 3 == 0)
            {
                lbl.Style.Add("margin-left", "20px");
                lbl.Text = list[i].ToString();
                lbl.Style.Add("Font-bold", "true");
                lbl.Style.Add("Font-size", "large");
                span1.Controls.Add(lbl);
                span1.Controls.Add(new LiteralControl("<br />"));
            }
            else if (i % 3 == 1)
            {
                lbl.Style.Add("margin-left", "20px");
                lbl.Text = list[i].ToString();
                lbl.Style.Add("font-size", "small");
                span1.Controls.Add(lbl);
                span1.Controls.Add(new LiteralControl("<br />"));
                span1.Controls.Add(new LiteralControl("<br />"));
            }
            else
            {
                lbl.Style.Add("margin-left", "20px");
                lbl.Text = list[i].ToString();
                lbl.Style.Add("font-size", "x-small");
                span1.Controls.Add(lbl);
                Label lblline = new Label();
                span1.Controls.Add(new LiteralControl("<br />"));
                lblline.Style.Add("margin-left", "20px");
                lblline.Text = "---------------------------------------------------------------------------------------------------";
                span1.Controls.Add(lblline); 
                span1.Controls.Add(new LiteralControl("<br />"));
            }
            
        }
    }
}