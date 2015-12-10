using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Admin_AddUser : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {
            DropDownList1.Items.Add("client");
            DropDownList1.Items.Add("admin");
            DropDownList2.Items.Add("active");
            DropDownList2.Items.Add("inactive");
        }
    }
    protected void Button1_Click(object sender, EventArgs e)
    {
        int a = 1;

        if (DropDownList2.Items.ToString() == "inactive")
        {
            a = 0;
        }
        User user = new User(TextBox1.Text, TextBox2.Text, TextBox3.Text, TextBox4.Text, TextBox5.Text, TextBox6.Text, a, DropDownList1.SelectedItem.Text);
        lblresult.Text = ConnectionClass.RegisterUser(user);
    }
    protected void Button2_Click(object sender, EventArgs e)
    {
        TextBox1.Text = "";
        TextBox2.Text = "";
        TextBox3.Text = "";
        TextBox4.Text = "";
        TextBox5.Text = "";
        TextBox6.Text = "";
       
    }
}