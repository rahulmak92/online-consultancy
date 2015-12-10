using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Collections;
using System.Net;
using System.IO;
using System.Web.UI.HtmlControls;

public partial class _Default : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        HtmlAnchor b = (HtmlAnchor)this.Page.Master.FindControl("home");
        b.Style.Add("font-weight", "bold");
        b.Style.Add("color", "orange"); 

        if (Session["gujarati"] == null)
        {

            Label2.Text = "Welcome<br />";
            Label3.Text = "to the Consultancy House <br /><br />";
            span1.Controls.Add(new LiteralControl("<br />"));
            span1.Controls.Add(new LiteralControl("<br />"));
            span1.InnerText = "Whether your enquiry is on a personal or corporate basis, the major financial decisions that you make will have significant and life-changing consequences. It is therefore essential that you seek professional financial advice from people you can trust.";
            span1.Controls.Add(new LiteralControl("<br />"));
            span1.Controls.Add(new LiteralControl("<br />"));
            Label lbl = new Label();
            lbl.Text = "Please browse our website to find out more about who we are, our level of knowledge, experience and expertise and how we conduct business, or contact us for further information.";
            span1.Controls.Add(lbl);
            span1.Controls.Add(new LiteralControl("<br />"));
            span1.Controls.Add(new LiteralControl("<br />"));
            Label lbl1 = new Label();
            lbl1.Text = "We work in partnership with our clients, and other professional advisers such as Solicitors and Accountants, to meet their financial aspirations and we recognise the importance of providing long-term on-going assistance and guidance. ";
            span1.Controls.Add(lbl1);

            Label1.Text = "Treating Customers Fairly <br />";
            span2.Controls.Add(new LiteralControl("<br />"));
            span2.InnerText = "The Consultancy House are an appointed representative of Sesame Ltd. Sesame Ltd are regulated by the Financial Conduct Authority (FCA).The Consultancy House are happy to work within a regulated environment which prioritises the interests of consumers. ";
            span2.Controls.Add(new LiteralControl("<br />"));
            span2.Controls.Add(new LiteralControl("<br />"));
            Label lbl2 = new Label();
            lbl2.Text = "The Consultancy House has responded to the FCA initiative, 'treating Customers Fairly' and has set out what our clients can expect as part of our advice process. ";
            span2.Controls.Add(lbl2);
            link1.Text = "View more news";

        }
        else
        {
            Label2.Text = "આપનું સ્વાગત છે <br />";
            Label3.Text = "કન્સલ્ટન્સી હાઉસ માં <br />";
            span1.Controls.Add(new LiteralControl("<br />"));
            span1.Controls.Add(new LiteralControl("<br />"));
            span1.InnerText = "જો તમારી પૂછપરછ વ્યક્તિગત અથવા કોર્પોરેટ ધોરણે હોય,તો તમે જે મુખ્ય આર્થિક નિર્ણયો લઇ શકો તે નોંધપાત્ર અને જીવન બદલવા રૂપ હશે.તેથી વિશ્વાસપાત્ર લોકો પાસેથી વ્યાવસાયિક નાણાકીય સલાહ લેવી જરૂરી છે.";
            span1.Controls.Add(new LiteralControl("<br />"));
          /*  span1.Controls.Add(new LiteralControl("<br />")); */
            Label lbl = new Label();
            lbl.Text = "અમે કોણ,અમારું જ્ઞાન, અનુભવ અને કુશળતા અને કેવી રીતે અમે વ્યવસાય કરીએ વિશે વધુ જાણવા માટેકૃપા કરીને અમારી વેબસાઇટ બ્રાઉઝ કરો અથવા અમારો સંપર્ક કરો .";
            span1.Controls.Add(lbl);
         /*   span1.Controls.Add(new LiteralControl("<br />")); */
            span1.Controls.Add(new LiteralControl("<br />"));
            Label lbl1 = new Label();
            lbl1.Text = "અમે તમારી નાણાકીય આકાંક્ષાઓ પૂરી કરવા અમારા ક્લાઈન્ટો અને અન્ય વ્યાવસાયિક સલાહકારો જેમ કે સોલિસિટરો અને એકાઉન્ટન્ટ્સ સાથે ભાગીદારીમાં કામ કરીએ છીએ.અને અમે લાંબા ગાળાનું પૂરું મહત્વ ઓળખી સહાય અને માર્ગદર્શન આપીયે છીએ.";
            span1.Controls.Add(lbl1);

            Label1.Text = "યોગ્ય ગ્રાહકની ગણના <br />";
            span2.Controls.Add(new LiteralControl("<br />"));
            span2.InnerText = "કન્સલ્ટન્સી હાઉસ,સેસામે લિમિટેડ નું પ્રતિનિધિ છે.સેસામે લિમિટેડ નિયમન ફાઇનાન્સિયલ આચાર ઓથોરિટી(FCA) દ્વારા કરવામાં આવે છે. કન્સલ્ટન્સી હાઉસ ગ્રાહકોની પ્રાથમિકતાઓના હિત ના વાતાવરણ અંદર કામ કરવા માટે ખુશ છે ";
            span2.Controls.Add(new LiteralControl("<br />"));
            span2.Controls.Add(new LiteralControl("<br />"));
            Label lbl2 = new Label();
            lbl2.Text = "કન્સલ્ટન્સી હાઉસ એ 'યોગ્ય ગ્રાહકની ગણના' માટે પહેલ કરી છે અને અમારા ક્લાઈન્ટો અમારી સલાહ પ્રક્રિયા ભાગ તરીકે અપેક્ષા કરી શકે છે તે ધ્યેય કર્યો છે.  ";
            span2.Controls.Add(lbl2);
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

                    lbl.Text = headcut+" ...";
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
                    lbl.Style.Add("font-size","small");
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
                    lbl.Style.Add("font-size","X-small");
                    
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