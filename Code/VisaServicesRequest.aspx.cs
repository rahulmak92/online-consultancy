using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.IO;
public partial class VisaServicesRequest : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (Session["login"] != null)
        {
            if (!IsPostBack)
            {
                txtDeadline.Text = DateTime.Now.AddDays(21).ToString("MM-dd-yyyy");
                DropDownList1.Items.Add("Visa Service");
                DropDownList1.Items.Add("Renew Visa");
           
            }
            string savepath = Server.MapPath("~/Files/" + Session["login"].ToString());
            if (!Directory.Exists(savepath))
            {
                Directory.CreateDirectory(savepath);
            }
            string targetpath = Server.MapPath("~/Files/" + Session["login"].ToString() + "/VisaServices");
            if (!Directory.Exists(targetpath))
            {
                Directory.CreateDirectory(targetpath);
            }
            string targetpath1 = Server.MapPath("~/Files/" + Session["login"].ToString() + "/VisaServices/RequestFiles");
            if (!Directory.Exists(targetpath1))
            {
                Directory.CreateDirectory(targetpath1);
            }
            string targetpath2 = Server.MapPath("~/Files/" + Session["login"].ToString() + "/VisaServices/PassportFiles");
            if (!Directory.Exists(targetpath2))
            {
                Directory.CreateDirectory(targetpath2);
            }

        }
        else
        {
            Response.Redirect("ClientLogin.aspx");
        }
    }
    protected void Button2_Click(object sender, EventArgs e)
    {
        Response.Redirect("VisaServicesHistory.aspx");
    }

    Boolean flag = false;
    Boolean flag_deadline = false;
    protected void btnSubmit_Click(object sender, EventArgs e)
    {
        if (FileUpload1.HasFile)
        {
            if (FileUpload1.PostedFile.ContentType.Equals("application/pdf"))
            {
                if (flag_deadline == true)
                {
                    try
                    {
                        string filename = Path.GetFileName(FileUpload1.FileName);
                        FileUpload1.SaveAs(Server.MapPath("~/Files/" + Session["login"] + "/VisaServices/RequestFiles/") + filename);
                        flag = true;
                    }
                    catch (Exception ex)
                    {
                        lblResult.Text = ex.ToString();
                    }
                }
            }
            else
            {
                lblFileUpload.Text = "Passport File must be a PDF File";
                flag = false;
            }
        }

        if (FileUpload2.HasFile)
        {
            if (FileUpload2.PostedFile.ContentType.Equals("application/pdf"))
            {
                if (flag_deadline == true)
                {
                    try
                    {
                        string filename = Path.GetFileName(FileUpload2.FileName);
                        FileUpload2.SaveAs(Server.MapPath("~/Files/" + Session["login"] + "/VisaServices/PassportFiles/") + filename);
                        flag = true;
                    }
                    catch (Exception ex)
                    {
                        lblResult.Text = ex.ToString();
                    }
                }
            }
            else
            {
                lblFileUpload.Text = "Request File must be a PDF File";
                flag = false;
            }
        }

        if (flag == true)
        {
            string selectedDate = txtDeadline.Text;
            DateTime dt1 = DateTime.Parse(selectedDate);
            selectedDate = txtCalendar.Text;
            DateTime dt2 = DateTime.Parse(selectedDate);

            VisaRequestClass visarequestclass = new VisaRequestClass(txtName.Text, Session["login"].ToString(), txtMail.Text, txtTitle.Text, DropDownList1.SelectedItem.Text, txtNameOfAppl.Text, dt2, txtPassNo.Text, txtMother.Text, FileUpload2.PostedFile.FileName.ToString(), dt1, txtDescription.Text, FileUpload1.PostedFile.FileName.ToString(), "Processing", "");
            string result = ConnectionClass.AddVisaRequest(visarequestclass);
            int a = ConnectionClass.RetrieveLastId("RqstVisaServices");
            ConnectionClass.UpdateVisaFilenamebyId(a);
            string oldname = Server.MapPath("~/Files/" + Session["login"] + "/VisaServices/RequestFiles/") + FileUpload1.PostedFile.FileName;
            string newname = Server.MapPath("~/Files/" + Session["login"] + "/VisaServices/RequestFiles/") + Convert.ToString(a) + ".pdf";
            File.Move(oldname, newname);
            oldname = Server.MapPath("~/Files/" + Session["login"] + "/VisaServices/PassportFiles/") + FileUpload2.PostedFile.FileName;
            newname = Server.MapPath("~/Files/" + Session["login"] + "/VisaServices/PassportFiles/") + Convert.ToString(a) + ".pdf";
            File.Move(oldname, newname);

            lblResult.Text = result;
            lblFileUpload.Text = "";
        }
    }
    protected void DateValidate(Object sender, ServerValidateEventArgs args)
    {
        DateTime dt = Convert.ToDateTime(args.Value);
        args.IsValid = Convert.ToBoolean((dt >= DateTime.Now.AddDays(20)));
        if (args.IsValid == true)
        {
            flag_deadline = true;
        }

    }
}