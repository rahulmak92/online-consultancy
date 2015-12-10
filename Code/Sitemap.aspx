<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeFile="Sitemap.aspx.cs" Inherits="Sitemap" %>

<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    
    <span style="color:#5C062D;font-size:x-large" runat="server" id="stmp">
    </span>
    
    <div style="width:100%;float:left">
    <div style="width:50%;float:left">
    <span id="span1" runat="server">
    <ul style="font-size:small;list-style-image:url('Images/arrow.jpg')"  runat="server" id="ul1">
      <li>
        <a href="Default.aspx" style="color:#5C062D" runat="server" id="home"> <br /></a>
      </li>  
      
      <li>
        <a href="Services.aspx"  style="color:#5C062D" runat="server" id="services"></a>
        <ul>
            <li>
                <a href="Consultation.aspx"  style="color:#5C062D" id="con" runat="server"></a>
                <ul>
                    <li><a href="ConsultationRequest.aspx" style="color:#5C062D" id="conreq" runat="server"></a></li>
                    <li><a href="ConsultationRequestHistory.aspx" style="color:#5C062D" id="conhis" runat="server"></a></li>
                </ul>
            </li>
            <li>
                <a href="Accouting.aspx"  style="color:#5C062D" id="acc" runat="server"></a>
                <ul>
                    <li><a href="AccountingRequest.aspx" style="color:#5C062D" id="accreq" runat="server"></a></li>
                    <li><a href="AccountingRequestHistory.aspx" style="color:#5C062D" id="acchis" runat="server"></a></li>
                </ul>
            </li>
            <li>
                <a href="Payroll.aspx"  style="color:#5C062D" id="pay" runat="server"></a>
                <ul>
                    <li><a href="PayrollRequest.aspx" style="color:#5C062D" id="payreq" runat="server"></a></li>
                    <li><a href="PayrollRequestHistory.aspx" style="color:#5C062D" id="payhis" runat="server"></a></li>
                </ul>
            </li>
            <li>
                <a href="VisaServices.aspx"  style="color:#5C062D" id="vis" runat="server"></a>
                <ul>
                    <li><a href="VisaServicesRequest.aspx" style="color:#5C062D" id="visreq" runat="server"></a></li>
                    <li><a href="VisaServicesHistory.aspx" style="color:#5C062D" id="vishis" runat="server"></a></li>
                </ul>
            </li>
            <li>
                <a href="Business.aspx"  style="color:#5C062D" id="bus" runat="server"></a>
                <ul>
                    <li><a href="BusinessRequest.aspx" style="color:#5C062D" id="busreq" runat="server"></a></li>
                    <li><a href="BusinessRequestHistory.aspx" style="color:#5C062D" id="bushis" runat="server"></a></li>
                </ul>
            </li>
            <li runat="server" id="other">
                <a href="Others.aspx"  style="color:#5C062D" id="oth" runat="server"><br /></a>
                <ul>
                    <li runat="server" id="otherreq"><a href="OthersRequest.aspx" style="color:#5C062D" id="othreq" runat="server"></a></li>
                    <li runat="server" id="otherhis"><a href="OthersRequestHistoryaspx.aspx" style="color:#5C062D" id="othhis" runat="server"></a></li>
                </ul>
            </li>
            <li runat="server" id="store">
                <a href="Store.aspx"  style="color:#5C062D" id="sto" runat="server"><br /></a>
            </li>
        </ul>
      </li>
      
    </ul>
    </span>
    </div>
    <div style="width:50%;float:left">
    <span id="span2" runat="server">
        <div id="temp" runat="server"></div>
        <ul style="font-size:small;list-style-image:url('Images/arrow.jpg')" runat="server" id="ul2">
        <li>
        <a href="#"  style="color:#5C062D" id="par" runat="server"></a>           
        </li>
      <li>
        <a href="#"  style="color:#5C062D" id="com" runat="server"></a>
        <ul>
            <li>
                <a href="AboutUs.aspx" style="color:#5C062D" id="au" runat="server"></a>
            </li>
            <li>
                <a href="OurTeam.aspx" style="color:#5C062D" id="ot" runat="server"><br /></a>
            </li>
        </ul>
      </li>
      <li>
        <a href="ContactUs.aspx" style="color:#5C062D" id="cu" runat="server"></a>
      </li>
      <li>
        <a href="NewsPage.aspx"  style="color:#5C062D" id="ne" runat="server"></a>
      </li>
     <li>
        <a href="#"  style="color:#5C062D" id="lin" runat="server"></a>
      </li>
      <li>
        <a href="#"  style="color:#5C062D" id="pp" runat="server"></a>
      </li> 
      <li>
        <a href="ForgotPassword.aspx" style="color:#5C062D" id="fp" runat="server"></a>
      </li>
        </ul>
    </span>
    </div>
    </div>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder2" Runat="Server">
    <br />
    <br />
    <div runat="server" id="div1">
    <table width="100%" style="margin-left:10px">
    <tr>
    <td runat="server" id="td1">
    </td>
    </tr>
    </table>
    </div>
    <asp:LinkButton ID="link1" runat="server" Font-Underline="false" Font-Size="X-Small" PostBackUrl="#" CssClass="linkposition">View More News</asp:LinkButton> 
</asp:Content>

