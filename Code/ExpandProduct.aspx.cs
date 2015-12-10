using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.IO;

public partial class ExpandProduct : System.Web.UI.Page
{
    string file;
    decimal price;
    protected void Page_Load(object sender, EventArgs e)
    {
        if (Session["login"] == null)
        {
            Response.Redirect("ClientLogin.aspx");
        }
        else
        {
            string check = Session["nameofproduct"].ToString();
            Product product = ConnectionClass.GetProductByName(check);
            file=product.ProductFile;
            lblName.Text = product.ProductName;
            lblDesc.Text = product.Description;
            price = product.Price;
            lblPrice.Text = product.Price.ToString();
            lblPrice.Text += " $";
            img1.Src = "Images/" + product.ProductPicture;
        }
    }
    protected void Button1_Click(object sender, EventArgs e)
    {
        Response.Redirect("Store.aspx");
    }
    protected void Button2_Click(object sender, EventArgs e)
    {
        
        if (price > 0)
        {
            
            Response.Redirect("ProceedToPayment.aspx");
        }
        else
        {
            string filepath = "~/Products/" + file;
            Response.ContentType = "image/jpeg";
            Response.AppendHeader("Content-Disposition", "attachment; filename="+file);
            Response.TransmitFile(Server.MapPath("~/Products/"+file));
            Response.End();
        }
        
    }
}