using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.IO;

public partial class ConsultationRequest : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (Session["login"] != null)
        {
            if (!IsPostBack)
            {
                txtDeadline.Text = DateTime.Now.AddDays(21).ToString("MM-dd-yyyy");
                DropDownList1.Items.Add("Foreign Exchange");
                DropDownList1.Items.Add("Legal");
                DropDownList1.Items.Add("Stock");
                DropDownList1.Items.Add("Tax");
                DropDownList1.Items.Add("Management");
            }

            string savepath = Server.MapPath("~/Files/" + Session["login"].ToString());
            if (!Directory.Exists(savepath))
            {
                Directory.CreateDirectory(savepath);                
            }
            string targetpath = Server.MapPath("~/Files/" + Session["login"].ToString() + "/Consultation");
            if(!Directory.Exists(targetpath))
            {
                Directory.CreateDirectory(targetpath);
            }
           
        }
        else
        {
            Response.Redirect("ClientLogin.aspx");
        }
    }
    Boolean flag = false;
    protected void btnSubmit_Click(object sender, EventArgs e)
    {
        if (FileUpload1.HasFile)
        {

            if (FileUpload1.PostedFile.ContentType.Equals("application/pdf"))
            {
                if (flag == true)
                {
                    try
                    {
                        string filename = Path.GetFileName(FileUpload1.FileName);

                        FileUpload1.PostedFile.SaveAs(Server.MapPath("~/Files/" + Session["login"] + "/Consultation/") + filename);

                    }

                    catch (Exception ex)
                    {
                        lblFileUpload.Text = "File could not be uploaded" + ex.Message;
                    }
                }
            }
            else
            {
                lblFileUpload.Text = "File must be a PDF File";
            }
            if (lblFileUpload.Text == "")
            {
                if (flag == true)
                {
                    string selectedDate = txtDeadline.Text;
                    DateTime dt1 = DateTime.Parse(selectedDate);

                    ConsultationRequestClass consultationrequestclass = new ConsultationRequestClass(txtName.Text, Session["login"].ToString(), txtMail.Text, txtTitle.Text, DropDownList1.SelectedItem.Text, dt1, txtDescription.Text, "Consultation_"+FileUpload1.PostedFile.FileName.ToString(), "Processing", "");
                    string result = ConnectionClass.AddRequest(consultationrequestclass);
                    int a = ConnectionClass.RetrieveLastId("RqstConsultation");
                    ConnectionClass.UpdateConsultationFilenamebyId(a);
                    string oldname = Server.MapPath("~/Files/" + Session["login"] + "/Consultation/") + FileUpload1.PostedFile.FileName;
                    string newname = Server.MapPath("~/Files/" + Session["login"] + "/Consultation/") + Convert.ToString(a) + ".pdf";
                    File.Move(oldname, newname);

                    lblResult.Text = result;
                    
                }
            }
            else
            {
                lblResult.Text = "";
            }
        }

    }

    protected void DateValidate(Object sender, ServerValidateEventArgs args)
    {
        DateTime dt = Convert.ToDateTime(args.Value);
        args.IsValid = Convert.ToBoolean((dt >= DateTime.Now.AddDays(20)));
        if (args.IsValid == true)
        {
            flag = true;
        }

    }
    protected void Button2_Click(object sender, EventArgs e)
    {
        Response.Redirect("ConsultationRequestHistory.aspx");
    }
}