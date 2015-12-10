using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Admin_ExpandUser : System.Web.UI.Page
{
    
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {
            DropDownList1.Items.Add("active");
            DropDownList1.Items.Add("inactive");
            DropDownList2.Items.Add("client");
            DropDownList2.Items.Add("admin");

            Label1.Text = Session["uname"].ToString();
            User user = ConnectionClass.GetUserByName(Session["uname"].ToString());

            ViewState["id"] = user.Id;
            TextUsername.Text = user.UserName;
            TextPassword.Text = user.Password;
            TextBox1.Text = user.FirstName;
            TextBox2.Text = user.LastName;
            TextBox3.Text = user.Email;
            TextBox4.Text = user.ContactNo;
            if (user.Active == 1)
            {
                DropDownList1.SelectedItem.Text = "active";
            }
            else
            {
                DropDownList1.SelectedItem.Text = "inactive";
            }
            if (user.Role == "client")
            {
                DropDownList2.SelectedItem.Text = "client";
            }
            else
            {
                DropDownList2.SelectedItem.Text = "admin";
            }
        }
        
    }
    protected void Button2_Click(object sender, EventArgs e)
    {
        Response.Redirect("ListUsers.aspx");
    }

    protected void Button1_Click(object sender, EventArgs e)
    {
        int a1=1;
        if(DropDownList1.SelectedItem.Text=="active")
        {
            a1=1;
        }
        else
        {
            a1=0;
        }
        User user1 = new User(Convert.ToInt32(ViewState["id"]),TextUsername.Text,TextPassword.Text,TextBox1.Text,TextBox2.Text,TextBox3.Text,TextBox4.Text,a1,DropDownList2.SelectedItem.Text);
        String result = ConnectionClass.UpdateUser(user1);
        Label2.Text = result;
    }
}