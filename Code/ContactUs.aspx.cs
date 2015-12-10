using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Net;
using System.Web.UI.HtmlControls;

public partial class ContactUs : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        HtmlAnchor b = (HtmlAnchor)this.Page.Master.FindControl("contactus");
        b.Style.Add("font-weight", "bold");
        b.Style.Add("color", "orange");
        
        GoogleMapForASPNet1.GoogleMapObject.APIKey = "AIzaSyBsinKE8VhDmBbrlfjJsuGq9wNCWlsuIk0";
        GoogleMapForASPNet1.GoogleMapObject.APIVersion = "2";
        GoogleMapForASPNet1.GoogleMapObject.Width = "745px";
        GoogleMapForASPNet1.GoogleMapObject.Height = "205px";
        GoogleMapForASPNet1.GoogleMapObject.ZoomLevel = 14;
        GooglePoint GP = new GooglePoint();
        GP.ID = "1";
        GP.Latitude = 23.0214418;
        GP.Longitude = 72.5545012;
        GoogleMapForASPNet1.GoogleMapObject.Points.Add(GP);
        Label1.Visible = false;

    }

    protected void SendMail()
    {
        var to = "11ceuos098.ce@ddu.ac.in";
        var from = "consultancyhouse2015@gmail.com";
        const string password = "y70j9jk2";
        string subject = "Enquiry From: " + TextBox1.Text;
        string body = "New Enquiry\n\n";
        body += " From : " + TextBox1.Text + "\n";
        body += " Email : " + TextBox2.Text + "\n";
        body += " Telephone No : " + TextBox3.Text + "\n";
        body += " Message : " + TextBox4.Text + "\n";

        var smtp = new System.Net.Mail.SmtpClient();
        {
            smtp.Host = "smtp.gmail.com";
            smtp.Port = 587;
            smtp.EnableSsl = true;
            smtp.DeliveryMethod = System.Net.Mail.SmtpDeliveryMethod.Network;
            smtp.Credentials = new NetworkCredential(from, password);
            smtp.Timeout = 20000;
        }

        smtp.Send(from, to, subject, body);
    }

    protected void Button1_Click(object sender, EventArgs e)
    {
        ContactUsClass contactus = new ContactUsClass(TextBox1.Text, TextBox2.Text, TextBox3.Text, TextBox4.Text);
        string result = ConnectionClass.AddEnquiry(contactus);
        Label1.Visible = true;
        Label1.ForeColor = System.Drawing.Color.Red;
        Label1.Text = result;
        try
        {
            SendMail();
        }
        catch (Exception)
        {

        }
        if (Label1.Text == "Enquiry Added Successfully")
        {

            TextBox1.Text = "";
            TextBox2.Text = "";
            TextBox3.Text = "";
            TextBox4.Text = "";
        }
    }
}