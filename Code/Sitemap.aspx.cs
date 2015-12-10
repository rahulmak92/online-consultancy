using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Collections;
using System.Web.UI.HtmlControls;

public partial class Sitemap : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        ArrayList list = new ArrayList();
        if (Session["gujarati"] == null)
        {
            list = ConnectionClass.GetNews("NewsManagement");
        }
        else
        {
            list = ConnectionClass.GetNews("NewsManagementGujarati");
        }
        
        int lengthoflist = list.Count;
        int num;
        if (Session["gujarati"] == null)
            num = 65;
        else
            num = 50;

        for (int i = 0; i < 6; i++)
        {

            Label lbl = new Label();


            if (i % 2 == 0)
            {
                if (list[i].ToString().Length > 28)
                {
                    string headcut = list[i].ToString().Substring(0, 27);

                    lbl.Text = headcut + " ...";
                }
                else
                {
                    lbl.Text = list[i].ToString();
                }
                lbl.Style.Add("color", "#5C062D");
                if (Session["gujarati"] == null)
                {
                    lbl.Style.Add("font-size", "small");
                }
                else
                {
                    lbl.Style.Add("font-size", "small");
                }
                lbl.Style.Add("font-weight", "bold");
                td1.Controls.Add(lbl);
                td1.Controls.Add(new LiteralControl("<br />"));
            }


            else
            {
                if (list[i].ToString().Length > num)
                {
                    string cut = list[i].ToString().Substring(0, num);
                    lbl.Text = cut + "...";
                }
                else
                {
                    lbl.Text = list[i].ToString();
                }
                if (Session["gujarati"] == null)
                {
                    lbl.Style.Add("font-size", "smaller");

                }
                else
                {
                    lbl.Style.Add("font-size", "X-small");

                }
                td1.Controls.Add(lbl);
                td1.Controls.Add(new LiteralControl("<br />"));
                Label lblline = new Label();
                if (i == 5)
                {
                }
                else
                {
                    lblline.Text = " ----------------------------------";
                    td1.Controls.Add(lblline);

                    td1.Controls.Add(new LiteralControl("<br />"));
                }
            }
        }

        if (Session["gujarati"] == null)
        {
            
            stmp.InnerText = "SiteMap";
            span1.Style.Add("font-size", "smaller");
            span2.Style.Add("font-size", "smaller");
          /*  ul1.Style.Add("font-size", "small");
            ul2.Style.Add("font-size", "small"); */
            home.InnerText = "Home";
            services.InnerText = "Services";
            con.InnerText = "Consultation";
            conreq.InnerText = "Consultation Request";
            conhis.InnerText = "Consultation History";
            acc.InnerText = "Accounting";
            accreq.InnerText = "Accounting Request";
            acchis.InnerText = "Accounting History";
            pay.InnerText = "Payroll";
            payreq.InnerText = "Payroll Request";
            payhis.InnerText = "Payroll History";
            vis.InnerText = "Visa Services";
            visreq.InnerText = "Visa Request";
            vishis.InnerText = "Visa History";
            bus.InnerText = "Business Planning";
            busreq.InnerText = "Business Planning Request";
            bushis.InnerText = "Business Planning History";
            oth.InnerText = "Others";
            othreq.InnerText = "Others Request";
            othhis.InnerText = "Others History";
            sto.InnerText = "Store";
            com.InnerText = "Company";
            par.InnerText = "Partners";
            au.InnerText = "About Us";
            ot.InnerText = "Our Team";
            cu.InnerText = "Contact Us";
            ne.InnerText = "News";
            lin.InnerText = "Links";
            pp.InnerText = "Privacy Policy";
            fp.InnerText = "Forgot Password";


        }
        else
        {
            stmp.Style.Add("font-size", "18px");
            stmp.Style.Add("font-weight", "bold");
            stmp.InnerText="સાઇટમેપ";
            span1.Style.Add("font-size", "small");
            span2.Style.Add("font-size", "small");
            ul1.Style.Add("font-size", "small");
            ul2.Style.Add("font-size", "small");
            home.InnerText = "હોમ";
            services.InnerText = "સેવાઓ";
            con.InnerText = "પરામર્શ";
            conreq.InnerText = "પરામર્શ રિકવેસ્ટ";
            conhis.InnerText = "પરામર્શ સૂચિ";
            acc.InnerText = "એકાઉન્ટિંગ";
            accreq.InnerText = "એકાઉન્ટિંગ રિકવેસ્ટ";
            acchis.InnerText = "એકાઉન્ટિંગ સૂચિ";
            pay.InnerText = "પેરોલ";
            payreq.InnerText = "પેરોલ રિકવેસ્ટ";
            payhis.InnerText = "પેરોલ સૂચિ";
            vis.InnerText = "વિઝા સેવા";
            visreq.InnerText = "વિઝા રિકવેસ્ટ";
            vishis.InnerText = "વિઝા સૂચિ";
            bus.InnerText = "વ્યાપાર આયોજન";
            busreq.InnerText = "વ્યાપાર આયોજન રિકવેસ્ટ";
            bushis.InnerText = "વ્યાપાર આયોજન સૂચિ";

            HtmlGenericControl ul3 = new HtmlGenericControl("ul");
            ul3.Style.Add("color", "#5C062D");
            ul3.Style.Add("font-size", "small");
            ul3.Style.Add("list-style-image", "url('Images/arrow.jpg')");
            ul3.Style.Add("margin-left", "30px");
            temp.Controls.Add(ul3);

            HtmlGenericControl li = new HtmlGenericControl("li");
            
            ul3.Controls.Add(li);
            HtmlGenericControl anya = new HtmlGenericControl("a");
            anya.Attributes.Add("href", "Others.aspx");
            anya.Style.Add("color", "#5C062D");

            anya.InnerText = "અન્ય"; ;
            li.Controls.Add(anya);
            HtmlGenericControl ul4 = new HtmlGenericControl("ul");
            li.Controls.Add(ul4);
            HtmlGenericControl li1 = new HtmlGenericControl("li");
            
            ul4.Controls.Add(li1);

            HtmlGenericControl anya1 = new HtmlGenericControl("a");
            anya1.Attributes.Add("href", "OthersRequest.aspx");
            anya1.Style.Add("color", "#5C062D");
            anya1.InnerText = "અન્ય રિકવેસ્ટ"; 
            li1.Controls.Add(anya1);

            HtmlGenericControl li2 = new HtmlGenericControl("li");           
            ul4.Controls.Add(li2);
            HtmlGenericControl anya2 = new HtmlGenericControl("a");
            anya2.Attributes.Add("href", "OthersRequest.aspx");
            anya2.Style.Add("color", "#5C062D");
            anya2.InnerText = "અન્ય સૂચિ";
            li2.Controls.Add(anya2);

            HtmlGenericControl li3 = new HtmlGenericControl("li");
            ul3.Controls.Add(li3);
            HtmlGenericControl st = new HtmlGenericControl("a");
            st.Attributes.Add("href", "Store.aspx");
            st.Style.Add("color", "#5C062D");
            st.InnerText = "સ્ટોર";
            li3.Controls.Add(st);

            oth.Visible = false;
            othreq.Visible = false;
            othhis.Visible = false;
            otherreq.Visible = false;
            otherhis.Visible = false;
            other.Visible = false;
            sto.Visible = false;
            store.Visible = false;
            com.InnerText = "પેઢી";
            par.InnerText = "ભાગીદાર";
            au.InnerText = "અમારા વિશે";
            ot.InnerText = "અમારી ટીમ";
            cu.InnerText = "સંપર્ક";
            ne.InnerText = "સમાચાર";
            lin.InnerText = "લિંક્સ";
            pp.InnerText = "ગોપનીયતા નીતિ";
            fp.InnerText = "ફોરગોટ પાસવર્ડ";
        }
    }


}