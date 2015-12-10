using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.IO;

public partial class Admin_EditVisaServices : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }

    protected void GridView1_RowCommand(object sender, GridViewCommandEventArgs e)
    {
        if (e.CommandName == "DownloadResultFile")
        {

            int index = Convert.ToInt32(e.CommandArgument);
            GridViewRow selectedRow = GridView1.Rows[index];
            TableCell resultfile = selectedRow.Cells[0];
            string filename = resultfile.Text + ".pdf";
            Label1.Text = filename;


            string[] filepaths = Directory.GetFiles(Server.MapPath("~/ResultFiles/VisaServices/"));


            foreach (string filepath in filepaths)
            {
                if (Path.GetFileName(filepath) == filename)
                {

                    Response.ContentType = ContentType;
                    Response.AppendHeader("Content-Disposition", "attachment; filename=" + Path.GetFileName(filepath));
                    Response.WriteFile(filepath);
                    Response.End();
                }
                else
                {
                    Label1.ForeColor = System.Drawing.Color.Red;
                    Label1.Text = "Result File not found. Request is still in process";
                }

            }

        }

        if (e.CommandName == "DownloadClientFile")
        {
            int index = Convert.ToInt32(e.CommandArgument);
            GridViewRow selectedrow = GridView1.Rows[index];
            TableCell clientfile = selectedrow.Cells[0];
            TableCell username = selectedrow.Cells[1];
            string filename = clientfile.Text + ".pdf";
            string user = username.Text;

            string[] filepaths = Directory.GetFiles(Server.MapPath("~/Files/" + user + "/VisaServices/RequestFiles/"));
            foreach (string filepath in filepaths)
            {
                if (Path.GetFileName(filepath) == filename)
                {

                    Response.ContentType = ContentType;
                    Response.AppendHeader("Content-Disposition", "attachment; filename=" + Path.GetFileName(filepath));
                    Response.WriteFile(filepath);
                    Response.End();
                }
                else
                {
                    Label1.Text = user;
                }
            }
        }

        if (e.CommandName == "DownloadPassportFile")
        {
            int index = Convert.ToInt32(e.CommandArgument);
            GridViewRow selectedrow = GridView1.Rows[index];
            TableCell clientfile = selectedrow.Cells[0];
            TableCell username = selectedrow.Cells[1];
            string filename = clientfile.Text + ".pdf";
            string user = username.Text;

            string[] filepaths = Directory.GetFiles(Server.MapPath("~/Files/" + user + "/VisaServices/PassportFiles/"));
            foreach (string filepath in filepaths)
            {
                if (Path.GetFileName(filepath) == filename)
                {

                    Response.ContentType = ContentType;
                    Response.AppendHeader("Content-Disposition", "attachment; filename=" + Path.GetFileName(filepath));
                    Response.WriteFile(filepath);
                    Response.End();
                }
                else
                {
                    Label1.Text = user;
                }
            }
        }

        if (e.CommandName == "EditRequest")
        {
            int index = Convert.ToInt32(e.CommandArgument);
            GridViewRow selectedRow = GridView1.Rows[index];
            TableCell id = selectedRow.Cells[0];
            string reqid = id.Text;
            Session["id"] = reqid;
            Response.Redirect("ExpandVisaServices.aspx");
        }
    }
}