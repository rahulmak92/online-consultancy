<%@ Page Language="C#" AutoEventWireup="true" CodeFile="AdminLogin.aspx.cs" Inherits="Admin_AdminLogin" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <link rel="Stylesheet" type="text/css" href="in-admin-panel/style.css" />
    <link rel="stylesheet" type="text/css" media="all" href="in-admin-panel/niceforms-default.css" />
</head>

<body>
<form runat="server" id="form1">
    <div id="main_container">

	<div class="header_login">
    <div class="logo"><a href="#"><img src="in-admin-panel/images/logo.jpg" alt="" title="" border="0" width="270px" height="85px" /></a></div>
    </div>

     
         <div class="login_form">
         
         <h3>Admin Panel Login</h3>
         
         <a href="#" class="forgot_pass">Forgot password</a> 
         <br />
         <br />
             
         <br />
         <span style="margin-left:200px"><asp:Label ID="Label1" runat="server" Text="" ForeColor="Red" Font-Size="Larger"></asp:Label></span>
         <table style="margin-left:100px;margin-top:50px">
         
            <tr>
                <td>Username:</td>
                <td>
                    <asp:TextBox ID="TextBox1" runat="server" Width="250"></asp:TextBox>
                </td>
            </tr>
            
            <tr><td></td></tr>
            
            <tr>
                <td>Password:</td>
                <td>
                       <asp:TextBox ID="TextBox2" runat="server" Width="250px" TextMode="Password"></asp:TextBox>
                </td>
            </tr>
            
         </table>
         <br />
         <br />
         <span style="margin-left:260px">
         <asp:Button ID="Button1" runat="server" Text="Login" CssClass="" 
                 onclick="Button1_Click"/></span>
         </div>  
          
	
    
    <div class="footer_login">

    	<div class="right_footer_login" style="font-size:small">
        <span style="float:right">All rights reserved</span><br />
        <a href="http://indeziner.com">Privacy Policy </a>|<a href="http://google.com"> Terms of Use</a>
        </div>
    </div>

</div>
</form>		
</body>
</html>
