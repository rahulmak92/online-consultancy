using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Collections;
using System.Web.UI.HtmlControls;

public partial class Partners : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        HtmlAnchor b = (HtmlAnchor)this.Page.Master.FindControl("partners");
        b.Style.Add("font-weight", "bold");
        b.Style.Add("color","orange"); 


        if (Session["gujarati"] == null)
        {
            span1.Style.Add("font-size", "15px");
            span1.InnerText = "Consultancy House partners with organizations that share our view that the way to improve living standard is by providing the caring power of your finance. Their long-term commitments are essential to addressing key financial issues, such as promoting financial stability and independence.";
            span1.Controls.Add(new LiteralControl("<br />"));
            span1.Controls.Add(new LiteralControl("<br />"));
            Label loo = new Label();
            loo.Text = "We have also established extensive networks within all the key Development Banks, Export Credit Agencies and Export-Import Banks and detailed knowledge of the business models they employ.";
            span1.Controls.Add(loo);
            span1.Controls.Add(new LiteralControl("<br />"));
            span1.Controls.Add(new LiteralControl("<br />"));
            Label loo1 = new Label();
            loo1.Text = " Our major partners are :";
            loo1.Style.Add("font-size", "18px");
            loo1.Style.Add("font-weight", "bold");
            loo1.Style.Add("color", "#5C062D");
            span1.Controls.Add(loo1);
            span1.Controls.Add(new LiteralControl("<br />"));
            span1.Controls.Add(new LiteralControl("<br />"));
            Label loo2 = new Label();
            loo2.Text = "Development Bank of Ahmedabad <br />Development Bank of Gujarat <br />Russel Bradford <br />People's Co-operative Bank <br />International Investment Bank <br />The World Bank Group <br />International Finance Corporation <br />National Round Table on the Environment <br />KfW Bankengruppe <br />Business Development Bank of India <br />PayPal <br />Bank of Saurashtra ";
            span1.Controls.Add(loo2);
            Label2.Text = "Partners";
            link1.Text = "View more news";
        }

        else
        {
            span1.Style.Add("font-size", "small");
            span1.InnerText = "કન્સલ્ટન્સી હાઉસ તે સંસ્થાઓ સાથે ભાગીદારી કરે છે જે નાણાકીય સહાય પૂરી પાડી પ્રમાણભૂત આજીવિકા સુધારવા માટે નું ધ્યેય રાખે છે.તેમના લાંબા ગાળાની ખાતરીઓ, નાણાકીય સ્થિરતા અને સ્વતંત્રતા પ્રોત્સાહન તરીકે નાણાકીય મુદ્દાઓના સંબોધન માટે જરૂરી છે.";
            span1.Controls.Add(new LiteralControl("<br />"));
        //    span1.Controls.Add(new LiteralControl("<br />"));
            Label loo = new Label();
            loo.Text = "અમે તમામ વિકાસ બેંકો, નિકાસ ક્રેડિટ એજન્સીઓ અને નિકાસ-આયાત બેંકો સાથે વ્યાપક નેટવર્ક સ્થાપી છે જેઓ નોકરી કે વ્યાપારના મોડેલોનું વિગતવાર જ્ઞાન ધરાવે છે .";
            span1.Controls.Add(loo);
            span1.Controls.Add(new LiteralControl("<br />"));
            span1.Controls.Add(new LiteralControl("<br />"));
            Label loo1 = new Label();
            loo1.Text = " અમારા મુખ્ય પાર્ટનર્સ :";
            loo1.Style.Add("font-size", "15px");
            loo1.Style.Add("font-weight", "bold");
            loo1.Style.Add("color", "#5C062D");
            span1.Controls.Add(loo1);
            span1.Controls.Add(new LiteralControl("<br />"));
           // span1.Controls.Add(new LiteralControl("<br />"));
            Label loo2 = new Label();
            loo2.Style.Add("font-size", "12px");
            loo2.Text = "ડેવલપમેન્ટ બેંક ઓફ અમદાવાદ <br />ડેવલપમેન્ટ બેંક ઓફ ગુજરાત <br />રસેલ બ્રેડફોર્ડ <br />People's કોઓપરેટિવ બેંક <br />આંતરરાષ્ટ્રીય ઇન્વેસ્ટમેન્ટ બેન્ક <br />વૈશ્વિક બેન્ક ગ્રુપ <br />ઇન્ટરનેશનલ ફાઇનાન્સ કોર્પોરેશન <br />નેશનલ પર્યાવરણ રાઉન્ડટેબલ <br />કે એફ ડબલ્યુ બેન્ક ગ્રુપ <br />ભારતીય બિઝનેસ ડેવલપમેન્ટ બેંક  <br />પે પાલ <br />બેંક ઓફ સૌરાષ્ટ્ર ";
            span1.Controls.Add(loo2);
            Label2.Text = "પાર્ટનર્સ";
            link1.Text = "વધુ સમાચાર જોવા";
        }


        
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

        for (int i = 0; i < lengthoflist; i++)
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
    }
}
