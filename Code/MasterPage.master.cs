using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Collections;

public partial class MasterPage : System.Web.UI.MasterPage
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (Session["login"] != null)
        {
            if (Session["gujarati"] != null)
            {
                lblLogin.Text = "સુસ્વાગતમ્, " + Session["login"].ToString();
            }
            else
            {
                lblLogin.Text = "Welcome, " + Session["login"].ToString();
            }
            lblLogin.Visible = true;
            LinkButton1.Text = "LogOut";
            Button1.Visible = false;
            
        }
        else
        {
            lblLogin.Visible = false;
            LinkButton1.Text = "";
            Button1.Text = "Login";
        }
        if (Session["gujarati"] != null)
        {
            sitemaplink.InnerText = "સાઇટમેપ";
            links.InnerText = "લિંક્સ";
            privacypolicy.InnerText = "ગોપનીયતા નીતિ";
            news1.InnerText = "સમાચાર";
            home.InnerText = "હોમ";
            services.InnerText = "સેવાઓ";
            partners.InnerText = "પાર્ટનર્સ";
            company.InnerText = "પેઢી";
            aboutus.InnerText = "અમારા વિશે";
            ourteam.InnerText = "અમારી ટીમ";
            contactus.InnerText = "સંપર્ક";
        }
        else
        {
            sitemaplink.InnerText = "SiteMap";
            links.InnerText = "Links";
            privacypolicy.InnerText = "Privacy Policy";
            home.InnerText = "HOME";
            services.InnerText = "SERVICES";
            partners.InnerText = "PARTNERS";
            company.InnerText = "COMPANY";
            aboutus.InnerText = "ABOUT US";
            ourteam.InnerText = "OUR TEAM";
            contactus.InnerText = "CONTACT US";
            news1.InnerText = "News";
        }
       
    }
    protected void LinkButton1_Click(object sender, EventArgs e)
    {
        
            if (LinkButton1.Text == "")
            {
                Response.Redirect("ClientLogin.aspx");
            }
            else
            {
                Session.Remove("login");
                Response.Redirect("Default.aspx");
            }     
    }
    protected void ImageButton2_Click(object sender, ImageClickEventArgs e)
    {
        Session["gujarati"] = "start";
        Response.Redirect(Request.RawUrl);
    }
    protected void ImageButton1_Click(object sender, ImageClickEventArgs e)
    {
        Session["gujarati"] = null;
        Response.Redirect(Request.RawUrl);
    }
    protected void site_Click(object sender, ImageClickEventArgs e)
    {
        Response.Redirect("Sitemap.aspx");
    }
    protected void message_Click(object sender, ImageClickEventArgs e)
    {
        Response.Redirect("ContactUs.aspx");
    }
    protected void twitter_Click(object sender, ImageClickEventArgs e)
    {
        Response.Redirect("TwitterFeed.aspx");
    }
}
