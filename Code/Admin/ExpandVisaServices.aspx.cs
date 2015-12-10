using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Admin_ExpandVisaServices : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {
            DropDownList2.Items.Add("Processing");
            DropDownList2.Items.Add("Done");
            DropDownList1.Items.Add("Processing");
            DropDownList1.Items.Add("Done");
            VisaRequestClass vc = ConnectionClass.GetVisaRequestById(Session["id"].ToString(), "RqstVisaServices");
            TextBox1.Text = vc.RequestId.ToString();
            TextBox2.Text = vc.UserName;
            TextBox3.Text = vc.Name;
            TextBox4.Text = vc.Email;
            TextBox5.Text = vc.VisaTitle;
            TextBox6.Text = vc.NameofApplicant;
            TextBox7.Text = vc.DateofBirth.ToShortDateString();
            TextBox8.Text = vc.PassportNo;
            TextBox9.Text = vc.MotherName;
            TextBox10.Text = vc.Deadline.ToString();
            TextBox11.Text = vc.Description;
            ViewState["uploadfile"] = vc.UploadFile;
            ViewState["passportcopy"] = vc.PassportCopy;
            DropDownList1.SelectedItem.Text = vc.VisaType;
            DropDownList2.SelectedItem.Text = vc.RequestStatus;
        }
    }
    protected void Button1_Click(object sender, EventArgs e)
    {
        if (FileUpload1.HasFile)
        {
            if (FileUpload1.PostedFile.ContentType == "application/pdf")
            {
                try
                {
                    FileUpload1.PostedFile.SaveAs(Server.MapPath("~/ResultFiles/VisaServices/") + TextBox1.Text + ".pdf");
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
                VisaRequestClass vc = new VisaRequestClass(Convert.ToInt32(TextBox1.Text), TextBox3.Text, TextBox2.Text, TextBox4.Text, TextBox5.Text, DropDownList1.SelectedItem.Text, TextBox6.Text, Convert.ToDateTime(TextBox7.Text), TextBox8.Text, TextBox9.Text, ViewState["passportcopy"].ToString(), Convert.ToDateTime(TextBox10.Text), TextBox11.Text,ViewState["uploadfile"].ToString() ,DropDownList2.SelectedItem.Text, FileUpload1.PostedFile.FileName);
                string result = ConnectionClass.UpdateVisaRequest(vc, "RqstVisaServices");
                
                Label1.Text = result;
            }
            else
            {
                Label1.Text = "";
            }
        }
    }
    protected void Button2_Click(object sender, EventArgs e)
    {
        Response.Redirect("EditVisaServices.aspx");
    }
}