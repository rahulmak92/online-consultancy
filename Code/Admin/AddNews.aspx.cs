using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Admin_AddNews : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
       
    }
    protected void button1_Click(object sender, EventArgs e)
    {
        DateTime dt = Convert.ToDateTime(TextBox3.Text);
        DateTime dt1 = Convert.ToDateTime(TextBox4.Text);
        NewsClass news = new NewsClass(TextBox1.Text,TextBox2.Text,dt,dt1);
        string result=ConnectionClass.AddNews(news);
        lblresult.Text = result;
    }
    protected void button2_Click(object sender, EventArgs e)
    {
        TextBox1.Text = "";
        TextBox2.Text = "";
        TextBox3.Text = "";
        TextBox4.Text = "";
    }
}