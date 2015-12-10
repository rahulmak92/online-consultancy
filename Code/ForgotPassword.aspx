<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPageLogin.master" AutoEventWireup="true" CodeFile="ForgotPassword.aspx.cs" Inherits="ForgotPassword" %>

<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
<br />
<br />
<span style="color:#5C062D;Font-Size:X-large;margin-left:30px">Forgot Password</span>
<br />
<br />
<span style="font-size:small;margin-left:30px">
Fields with <span style="color:Red">*</span> are required.</span>
<br />
<br /><span style="margin-left:20px"><asp:Label ID="Label1" runat="server" ForeColor="Red" Text="" Font-Size="Smaller"></asp:Label></span>
<br />
<table style="margin-left:30px;font-size:small">
    <tr>
        <td>Username:</td>
        <td><asp:TextBox ID="TextBox1" runat="server" Width="290px" AutoCompleteType="Disabled"></asp:TextBox><span style="color:Red">*</span><asp:RequiredFieldValidator 
                ID="RequiredFieldValidator1" runat="server" 
                ErrorMessage="You must enter username" ControlToValidate="TextBox1" ForeColor="Red"></asp:RequiredFieldValidator>
        </td> 
          
    </tr>
    <tr><td></td></tr>
    <tr>
        <td></td><td><asp:Button ID="Button1" runat="server" Text="Submit" 
            onclick="Button1_Click" CssClass="butt" />
        
        &nbsp&nbsp&nbsp&nbsp;<asp:Button ID="Button2" runat="server" Text="Cancel" 
            onclick="Button2_Click" CausesValidation="false" CssClass="butt" /></td>
    </tr>
</table>
</asp:Content>

