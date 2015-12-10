<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPageLogin.master" AutoEventWireup="true" CodeFile="ClientLogin.aspx.cs" Inherits="ClientLogin" %>
<%@ Register Assembly="MSCaptcha" Namespace="MSCaptcha" TagPrefix="cc1" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <span style="color:#5C062D;font-size:x-large">
    &nbsp;Log In
    <br />
    <br />
    </span>
<table style="color:#5C062D">
<tr>
    <td>Username:</td>
    <td>
        <asp:TextBox ID="txtName" runat="server"></asp:TextBox><asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ErrorMessage="Username can not be empty" ControlToValidate="txtName" ForeColor="Red"></asp:RequiredFieldValidator>
    </td>
</tr>
<tr>
    <td>Password:</td>
    <td>
        <asp:TextBox ID="txtPassword" runat="server" TextMode="Password"></asp:TextBox>
        <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" 
            ErrorMessage="Password can not be empty" ControlToValidate="txtPassword" ForeColor="Red"></asp:RequiredFieldValidator>
    </td>
</tr>
<tr>
<td>Enter Code Below:</td>
<td>
    <asp:TextBox ID="txtCaptcha" runat="server" AutoCompleteType="Disabled"></asp:TextBox>
</td>
</tr>
<tr>
<td></td>
<td>
<cc1:CaptchaControl ID="Captcha1" runat="server"
 CaptchaBackgroundNoise="Low" CaptchaLength="5"
 CaptchaHeight="60" CaptchaWidth="200"
 CaptchaLineNoise="None" CaptchaMinTimeout="5"
 CaptchaMaxTimeout="240" FontColor = "#529E00" Width="199px" />
</td>
</tr>
<tr><td></td></tr>
<tr>
<td>
    <asp:Button ID="Button1" runat="server" Text="Login" onclick="Button1_Click" CssClass="butt" /> 
    <asp:LinkButton ID="LinkButton1" runat="server" ForeColor="#5C062D" Font-Underline="false" Font-Size="Small" PostBackUrl="ForgotPassword.aspx" CausesValidation="false">&nbsp&nbsp&nbsp; Forgot your password?</asp:LinkButton><br /> 
    </td>
</tr>
</table>
<asp:Label ID="lblError" runat="server" Text=""></asp:Label>
<br />
<br />
</asp:Content>

