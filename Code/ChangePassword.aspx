<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPageLogin.master" AutoEventWireup="true" CodeFile="ChangePassword.aspx.cs" Inherits="ChangePassword" %>
<%@ Register TagPrefix="asp" Assembly="AjaxControlToolkit" Namespace="AjaxControlToolkit"  %>

<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
<br />
<br />
<span style="color:#5C062D;Font-Size:X-large;margin-left:30px">Change Password</span>   
<br /><asp:ToolkitScriptManager ID="ToolkitScriptManager1" runat="server"></asp:ToolkitScriptManager>
<span style="margin-left:180px"><asp:Label ID="Label1" runat="server" Text="" ForeColor="Red" Font-Size="Small"></asp:Label></span>
<br />
    
<table style="margin-left:30px;font-size:small">
<tr>
    <td>Old Password</td>
    <td><asp:TextBox ID="TextBox1" runat="server" Width="290px" TextMode="Password"></asp:TextBox><asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ErrorMessage="You must enter old password" ForeColor="Red" ControlToValidate="TextBox1"></asp:RequiredFieldValidator></td>
    
</tr>
<tr><td></td></tr>
<tr><td></td></tr>
    
<tr>
    <td>New Password</td>
    <td><asp:TextBox ID="TextBox2" runat="server" Width="290px" TextMode="Password"></asp:TextBox><asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" ErrorMessage="You must enter old password" ForeColor="Red" ControlToValidate="TextBox2"></asp:RequiredFieldValidator>
        <asp:PasswordStrength ID="TextBox2_PasswordStrength" runat="server" TargetControlID="TextBox2" StrengthIndicatorType="BarIndicator" DisplayPosition="RightSide" StrengthStyles="VeryPoor; Weak; Average; Excellent; Strong;" CalculationWeightings="25;25;15;35" BarBorderCssClass="borderstrength" PrefixText="Strength:" >
        </asp:PasswordStrength>
        
    </td>
    
</tr>
<tr><td></td></tr>
<tr><td></td></tr>
<tr>
    <td>Confirm New Password</td>
    <td><asp:TextBox ID="TextBox3" runat="server" Width="290px" TextMode="Password"></asp:TextBox><asp:RequiredFieldValidator ID="RequiredFieldValidator3" runat="server" ErrorMessage="You must re-enter new password" ForeColor="Red" ControlToValidate="TextBox3"></asp:RequiredFieldValidator></td>
</tr>
</table>
 
<br />
<br />
<span style="margin-left:190px">
<asp:Button ID="Button1" runat="server" Text="Save" CssClass="butt" 
        onclick="Button1_Click"/>&nbsp&nbsp&nbsp;
<asp:Button ID="Button2" runat="server" Text="Cancel" CssClass="butt" 
        CausesValidation="false" onclick="Button2_Click" />
</span>
</asp:Content>

