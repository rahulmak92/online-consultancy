using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Registration : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (Session["login"] != null)
        {
            Response.Redirect("Default.aspx");
        }
    }
    protected void btnRegister_Click(object sender, EventArgs e)
    {
        User user = new User(txtName.Text, txtPassword.Text,txtFirstname.Text,txtLastname.Text, txtmail.Text, txtContact.Text,1,"client");
        registerLbl.Text = ConnectionClass.RegisterUser(user);
        if (registerLbl.Text == "Thank You for registering with us")
        {
            btnRegister.Visible = false;
            lblName.Visible = false;
            lblPassword.Visible = false;
            lblConfirmPassword.Visible = false;
            lblFirstName.Visible = false;
            lblLastName.Visible = false;
            lblmail.Visible = false;
            lblContact.Visible = false;
            txtConfirmPassword.Visible = false;
            txtContact.Visible = false;
            txtFirstname.Visible = false;
            txtLastname.Visible = false;
            txtmail.Visible = false;
            txtName.Visible = false;
            txtPassword.Visible = false;
        }
    }
}