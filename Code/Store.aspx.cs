using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Store : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        int total = 0;
        int i=1;
        
        total = ConnectionClass.GetTotalProducts();
        
        int a1 = total % 2;
        int a2 = (total + 1) % 2;
        while (total > 0)
        {
            if (total % 2 == a1)
            {
                Product product = ConnectionClass.GetProduct(total);
                LinkButton mylabel = new LinkButton();
                mylabel.Text = product.ProductName;
                mylabel.ID = "lblName" + i;
                mylabel.Click+=new EventHandler(mylabel_Click);
                i++;
                mydiv1.Style.Add("font-size", "small");
                mydiv1.Style.Add("font-weight", "bold");
                mylabel.Style.Add("margin-left","30px");
                Image myimage = new Image();
                myimage.Height = 100;
                myimage.Width = 100;
                myimage.ID = "img" + i;
                myimage.ImageUrl = "Images/" + product.ProductPicture;
                myimage.Visible = true;
                mydiv1.Controls.Add(mylabel);
                mydiv1.Controls.Add(new LiteralControl("<br />"));
                mydiv1.Controls.Add(new LiteralControl("<br />"));
                mydiv1.Controls.Add(myimage);
                myimage.Style.Add("margin-left","30px");
                
                Label lblprice = new Label();
                lblprice.Text = "<br /><br />Price: "+product.Price.ToString() + "$";
               
                mydiv1.Controls.Add(lblprice);
                lblprice.Style.Add("float", "right");
                lblprice.Style.Add("margin-right", "200px");
                lblprice.Style.Add("color", "grey");
                
                mydiv1.Controls.Add(new LiteralControl("<br />"));
                mydiv1.Controls.Add(new LiteralControl("<br />"));
                total--;
                
            }
            else
            {
                Product product = ConnectionClass.GetProduct(total);
                LinkButton mylabel = new LinkButton();
                mylabel.Text = product.ProductName;
                mylabel.ID = "lblName" + i;
                mylabel.Click += new EventHandler(mylabel_Click);
                i++;
                mydiv2.Style.Add("font-size", "small");
                mydiv2.Style.Add("font-weight", "bold");
             //   mydiv2.Style.Add("margin-left", "30px");
                Image myimage = new Image();
                myimage.Height = 100;
                myimage.Width = 100;
                myimage.ID = "img" + i;
                myimage.ImageUrl = "Images/" + product.ProductPicture;
                myimage.Visible = true;
                mydiv2.Controls.Add(mylabel);
                mydiv2.Controls.Add(new LiteralControl("<br />"));
                mydiv2.Controls.Add(new LiteralControl("<br />"));
                mydiv2.Controls.Add(myimage);
                Label lblprice = new Label();
                lblprice.Text = "<br /><br /><br />Price: " + product.Price.ToString() + "$";
                mydiv2.Controls.Add(lblprice);
                lblprice.Style.Add("float", "right");
                lblprice.Style.Add("margin-right", "220px");
                lblprice.Style.Add("color", "grey");
                mydiv2.Controls.Add(new LiteralControl("<br />"));
                mydiv2.Controls.Add(new LiteralControl("<br />"));
                total--;
            }
        }
         
    }

    protected void mylabel_Click(object sender, EventArgs e)
    {

        LinkButton lnkbtn = (LinkButton)sender;
        Session["nameofproduct"] = lnkbtn.Text;
        Response.Redirect("ExpandProduct.aspx");
    }

    
}