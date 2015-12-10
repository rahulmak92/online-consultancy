using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Admin_ExpandOthersRequest : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {
            DropDownList2.Items.Add("Processing");
            DropDownList2.Items.Add("Done");
            ConsultationRequestClass c = ConnectionClass.GetRequestById(Session["id"].ToString(), "RqstOthers");
            TextBox1.Text = c.RequestId.ToString();
            TextBox2.Text = c.UserName;
            TextBox3.Text = c.Name;
            TextBox4.Text = c.ConsultationTitle;
            TextBox5.Text = c.Deadline.ToString();
            TextBox6.Text = c.Description;
            DropDownList2.SelectedItem.Text = c.RequestStatus;
            TextBox7.Text = c.ConsultationType;
            ViewState["mail"] = c.Email;
            ViewState["file"] = c.UploadFile;
        }
    }

    protected void Button2_Click(object sender, EventArgs e)
    {
        Response.Redirect("EditOthersRequest.aspx");
    }
    protected void Button1_Click(object sender, EventArgs e)
    {
        if (FileUpload1.HasFile)
        {
            if (FileUpload1.PostedFile.ContentType == "application/pdf")
            {
                try
                {
                    FileUpload1.PostedFile.SaveAs(Server.MapPath("~/ResultFiles/Others/") + TextBox1.Text + ".pdf");
                }
                catch (Exception ex)
                {
                    lblError.Text = "File could not be uploaded" + ex.Message;
                }
            }
            else
            {
                lblError.Text = "File must be a PDF";
            }

            if (lblError.Text == "")
            {
                ConsultationRequestClass c = new ConsultationRequestClass(Convert.ToInt32(Session["id"]), TextBox3.Text, TextBox2.Text, ViewState["mail"].ToString(), TextBox4.Text, TextBox7.Text, Convert.ToDateTime(TextBox5.Text), TextBox6.Text, ViewState["file"].ToString(), DropDownList2.SelectedItem.Text, Session["id"].ToString());
                string result = ConnectionClass.UpdateRequest(c, "RqstOthers");
                Label1.Text = result;
            }
            else
            {
                Label1.Text = "";
            }
        }

    }
}