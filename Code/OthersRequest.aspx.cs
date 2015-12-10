using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.IO;

public partial class OthersRequest : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (Session["login"] != null)
        {
            if (!IsPostBack)
            {
                txtDeadline.Text = DateTime.Now.AddDays(21).ToString("MM-dd-yyyy");               
            }
            string savepath = Server.MapPath("~/Files/" + Session["login"].ToString());
            if (!Directory.Exists(savepath))
            {
                Directory.CreateDirectory(savepath);
            }
            string targetpath = Server.MapPath("~/Files/" + Session["login"].ToString() + "/Others");
            if (!Directory.Exists(targetpath))
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
    protected void Button2_Click(object sender, EventArgs e)
    {
        Response.Redirect("OthersRequestHistoryaspx.aspx");
    }
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
                        FileUpload1.PostedFile.SaveAs(Server.MapPath("~/Files/" + Session["login"] + "/Others/") + filename);

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

                    ConsultationRequestClass consultationrequestclass = new ConsultationRequestClass(txtName.Text, Session["login"].ToString(), txtMail.Text, txtTitle.Text, txtType.Text, dt1, txtDescription.Text, FileUpload1.PostedFile.FileName.ToString(), "Processing", "");
                    string result = ConnectionClass.AddOthersRequest(consultationrequestclass);
                    int a = ConnectionClass.RetrieveLastId("RqstOthers");
                    ConnectionClass.UpdateOthersFilenamebyId(a);
                    string oldname = Server.MapPath("~/Files/" + Session["login"] + "/Others/") + FileUpload1.PostedFile.FileName;
                    string newname = Server.MapPath("~/Files/" + Session["login"] + "/Others/") + Convert.ToString(a) + ".pdf";
                    File.Move(oldname, newname);
                    lblResult.Text = result;
                    Label1.Visible = false;
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
        DateTime dt=Convert.ToDateTime(args.Value);
        args.IsValid=Convert.ToBoolean((dt>=DateTime.Now.AddDays(20)));
        if (args.IsValid == true)
        {
            flag = true;
        }
        
    }
}