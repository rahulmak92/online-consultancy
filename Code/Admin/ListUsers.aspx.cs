using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Admin_ListUsers : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }

    protected void GridView1_RowCommand(object sender, GridViewCommandEventArgs e)
    {
        if (e.CommandName == "View")
        {
            int index = Convert.ToInt32(e.CommandArgument);
            GridViewRow selectedRow = GridView1.Rows[index];
            TableCell name = selectedRow.Cells[1];
            string username = name.Text;
            Session["uname"] = username;
            Response.Redirect("ExpandUser.aspx");
        }

   /*     if (e.CommandName == "Active")
        {
            int index = Convert.ToInt32(e.CommandArgument);
            GridViewRow selectedrow1 = GridView1.Rows[index];
            TableCell name1 = selectedrow1.Cells[1];
            string user = name1.Text;
            ConnectionClass.ChangeActive(user);

            Response.Redirect("ListUsers.aspx");
        } */
    }

    protected void GridView1_RowDataBound(object sender, GridViewRowEventArgs e)
    {

        if (e.Row.RowType == DataControlRowType.DataRow)
        {
            
            ImageButton img = (ImageButton)e.Row.FindControl("LinkButton2");

            if (e.Row.Cells[6].Text == Convert.ToString(1))
            {
                img.ImageUrl = "~/Admin/in-admin-panel/images/user_active.png";
            }
            else
            {
                img.ImageUrl = "~/Admin/in-admin-panel/images/user_inactive.png";
            }
            
        }
        
    }

     protected void GridView1_SelectedIndexChanging(object sender, GridViewSelectEventArgs e)
    {
        // id of edit row
        int id = Convert.ToInt32(GridView1.Rows[e.NewSelectedIndex].Cells[0].Text);
   /*     int ac = Convert.ToInt32(GridView1.Rows[e.NewSelectedIndex].Cells[6].Text);
        if (ac == 0)
        {
            ac=1;
        }
        else
        {
            ac=0;;
        } */
        ConnectionClass.ChangeActive(id);
        Response.Redirect("ListUsers.aspx");
    }
}