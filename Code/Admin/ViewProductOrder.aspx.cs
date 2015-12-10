using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class ViewProductOrder : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        int id = Convert.ToInt32(Session["id"]);
        Order order = ConnectionClass.GetOrder(id);
        Label1.Text = order.POId.ToString();
        Label2.Text = order.Transactionid.ToString();
        Label3.Text = order.Firstname + " " + order.Lastname;
        Label4.Text = order.IPAddress;
        Label5.Text = order.Orderdate.ToString();
    }
}