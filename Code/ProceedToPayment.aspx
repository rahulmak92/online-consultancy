<%@ Page Language="C#" AutoEventWireup="true" CodeFile="ProceedToPayment.aspx.cs" Inherits="ProceedToPayment" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <link rel="Stylesheet" type="text/css" href="~/Styles/StyleSheet.css" />
</head>
<body>
<form action="https://www.sandbox.paypal.com/cgi-bin/webscr" method="post" target="_top" runat="server">
<div id="wrapper1">
        <div id="logo" style="width:100%">
            <div style="width:30%;float:left">
                <img src="Images/logo.jpg" width="300" height="100" class="picture" alt="logo"  />
            </div>
            <div style="width:70%;float:left">
                <asp:LinkButton ID="LinkButton1" runat="server" CssClass="linkposition" 
                    onclick="LinkButton1_Click">Logout</asp:LinkButton>
                <a href="#">
                <span class="linkposition">Links</span>
                </a>
                <a href="#">
                <span class="linkposition">Privacy Policy</span>
                </a>
                <a href="Default.aspx">
                <span class="linkposition">Home</span>
                </a>
            </div>
        </div>
        <div id="servicebanner" style="width:100%">
          <br />  &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:Label ID="lblLogin" runat="server" Font-Bold="true" Font-Size="X-Large" ></asp:Label>          
        </div>
        <div id="navigation">
            <ul id="nav1">
                <li><a href="Consultation.aspx"><span style="color:#fff">CONSULTATION</span></a></li>
                <li><a href="Accouting.aspx"><span style="color:#fff">&nbsp;&nbsp;&nbsp; ACCOUNTING</span></a></li>
                <li><a href="Store.aspx"><span style="color:#fff">&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; STORE</span></a></li>      
                <li><a href="Payroll.aspx"><span style="color:#fff">&nbsp;&nbsp;&nbsp;&nbsp; PAYROLL</span></a></li>             
                <li><a href="VisaServices.aspx"><span style="color:#fff">&nbsp; VISA SERVICES</span></a></li>
                <li><a href="Others.aspx"><span style="color:#fff">&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; OTHERS</span></a></li>
                <li><a href="Business.aspx"><span style="color:#fff">BUSINESS&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; PLANNING</span></a></li>
            </ul>
        </div>
        <span style="margin-left:200px"><asp:Label ID="Label1" runat="server" Font-Bold="true" Font-Size="XX-Large" ></asp:Label></span>
        <div id="panel1" style="width:100%;">
            
                 <br />
                 <br />
                 <br />
                 <br />
                 <span style="margin-left:450px">
                 
                
                <input type="hidden" name="cmd" value="_s-xclick">
                <input type="hidden" name="hosted_button_id" value="PRFEMFJMBPPA6">
                <input type="image" src="https://www.sandbox.paypal.com/en_US/i/btn/btn_buynowCC_LG.gif" border="0" name="submit" alt="PayPal - The safer, easier way to pay online!">
                <img alt="" border="0" src="https://www.sandbox.paypal.com/en_US/i/scr/pixel.gif" width="1" height="1">


                
                </span>
                <br />
                <br />
                <br />
                <br />
             <!--   <asp:Label ID="labeltr" runat="server" Text="Enter Transaction ID:"></asp:Label> <asp:TextBox runat="server" ID="transcationId"></asp:TextBox>
                <asp:Button ID="Go" Text="Go" runat="server" /><br /><br /><br /> -->
        </div>
        <div id="footer1">Ⓒ 2015 Consultancy House. All Rights Reserved</div>
    </div>
   </form>
   
</body>
</html>
