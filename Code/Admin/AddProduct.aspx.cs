using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.IO;

public partial class Admin_AddProduct : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        
    }
    protected void Button1_Click(object sender, EventArgs e)
    {
        decimal pr = decimal.Parse(TextBox4.Text);
        DateTime dt = DateTime.Parse(TextBox5.Text);
        try
        {
            if (FileUpload1.HasFile)
            {
                string filename1 = Path.GetFileName(FileUpload1.FileName);
                FileUpload1.SaveAs(Server.MapPath("~/Images/" + filename1));
            }
            if (FileUpload2.HasFile)
            {
                string filename2 = Path.GetFileName(FileUpload2.FileName);
                FileUpload2.SaveAs(Server.MapPath("~/Products/" + filename2));
            }

        }
        catch (Exception ex)
        {
            lbl.ForeColor = System.Drawing.Color.Red;
            lbl.Text = ex.Message;
        }
        if (lbl.Text == "")
        {
            Product product = new Product(Convert.ToInt32(TextBox1.Text), TextBox2.Text, TextBox3.Text, pr, dt, FileUpload1.PostedFile.FileName.ToString(), FileUpload2.PostedFile.FileName.ToString());
            string result = ConnectionClass.AddNewProduct(product);
            lblresult.ForeColor = System.Drawing.Color.Red;
            lblresult.Text = result;
        }
    }
    protected void Button2_Click(object sender, EventArgs e)
    {
        TextBox1.Text = "";
        TextBox2.Text = "";
        TextBox3.Text = "";
        TextBox4.Text = "";
        TextBox5.Text = "";
    }
}