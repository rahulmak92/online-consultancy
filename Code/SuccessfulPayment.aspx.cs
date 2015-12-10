using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Net;
using System.Text.RegularExpressions;
using System.IO;

public partial class SuccessfulPayment : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        
        if (!IsPostBack)
        {
            string check = Session["nameofproduct"].ToString();
            string name=Session["login"].ToString();
            Product product = ConnectionClass.GetProductByName(check);
            User user = ConnectionClass.GetUserByName(name);
            

           
                string externalIP;
                externalIP = (new WebClient()).DownloadString("http://checkip.dyndns.org/");
                externalIP = (new Regex(@"\d{1,3}\.\d{1,3}\.\d{1,3}\.\d{1,3}"))
                             .Matches(externalIP)[0].ToString();
               
           
           

            Order o=new Order(user.FirstName,user.LastName,name,user.Email,user.ContactNo,product.ProductNumber,product.ProductName,product.Price,DateTime.Now,"Success",externalIP,"");
            ConnectionClass.AddOrder(o);
            
            
        }
    }




    protected void download_Click(object sender, EventArgs e)
    {
        
        Product product = ConnectionClass.GetProductByName(Session["nameofproduct"].ToString());
        string file = product.ProductFile;
        string filepath = "~/Products/" + file;
        Response.ContentType = "image/jpeg";
        Response.AppendHeader("Content-Disposition", "attachment; filename=" + file);
        Response.TransmitFile(Server.MapPath("~/Products/" + file));
        Response.End();
    }
}