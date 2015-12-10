<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPageLogin.master" AutoEventWireup="true" CodeFile="Registration.aspx.cs" Inherits="Registration" %>

<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <span style="color:#5C062D">
<table>
<tr>
    <td><asp:label ID="lblName" Text="Name:" runat="server"></asp:label></td>
    <td>
        <asp:TextBox ID="txtName" runat="server"></asp:TextBox>
        <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" 
            ControlToValidate="txtName" ErrorMessage="*"></asp:RequiredFieldValidator>
    </td>
</tr>
<tr>
    <td><asp:label ID="lblPassword" Text="Password:" runat="server"></asp:label></td>
    <td>
        <asp:TextBox ID="txtPassword" runat="server"  TextMode="Password"></asp:TextBox>
        <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" 
            ControlToValidate="txtPassword" ErrorMessage="*"></asp:RequiredFieldValidator>
    </td>
</tr>
<tr>
    <td><asp:label ID="lblConfirmPassword" Text="Confirm Password:" runat="server"></asp:label></td>
    <td>
        <asp:TextBox ID="txtConfirmPassword" runat="server"  TextMode="Password"></asp:TextBox>
        <asp:RequiredFieldValidator ID="RequiredFieldValidator3" runat="server" 
            ControlToValidate="txtConfirmPassword" ErrorMessage="*"></asp:RequiredFieldValidator>
    </td>
</tr>
<tr>
    <td><asp:label ID="lblFirstName" Text="Firstname:" runat="server"></asp:label></td>
    <td>
        <asp:TextBox ID="txtFirstname" runat="server"  TextMode="SingleLine"></asp:TextBox>
        <asp:RequiredFieldValidator ID="RequiredFieldValidator6" runat="server" 
            ControlToValidate="txtFirstname" ErrorMessage="*"></asp:RequiredFieldValidator>
    </td>
</tr>
<tr>
    <td><asp:label ID="lblLastName" Text="Lastname:" runat="server"></asp:label></td>
    <td>
        <asp:TextBox ID="txtLastname" runat="server"  TextMode="SingleLine"></asp:TextBox>
        <asp:RequiredFieldValidator ID="RequiredFieldValidator7" runat="server" 
            ControlToValidate="txtLastname" ErrorMessage="*"></asp:RequiredFieldValidator>
    </td>
</tr>
<tr>
    <td><asp:label ID="lblmail" Text="Email:" runat="server"></asp:label></td>
    <td>
        <asp:TextBox ID="txtmail" runat="server"></asp:TextBox>
        <asp:RequiredFieldValidator ID="RequiredFieldValidator4" runat="server" 
            ControlToValidate="txtmail" ErrorMessage="*"></asp:RequiredFieldValidator>
            
    </td>
</tr>
<tr>
    <td><asp:label ID="lblContact" Text="Contact No:" runat="server"></asp:label></td>
    <td>
        <asp:TextBox ID="txtContact" runat="server"></asp:TextBox>
        <asp:RequiredFieldValidator ID="RequiredFieldValidator5" runat="server" 
            ControlToValidate="txtContact" ErrorMessage="*"></asp:RequiredFieldValidator>
    </td>
</tr>
<tr>
    <td>
        <asp:Button ID="btnRegister" runat="server" Text="Register" CssClass="cbtn" 
            onclick="btnRegister_Click" />
        <asp:CompareValidator ID="CompareValidator1" runat="server" 
            ControlToCompare="txtConfirmPassword" ControlToValidate="txtPassword" 
            ErrorMessage="Passwords must match" CssClass="linkbtn"></asp:CompareValidator>
        <br />
        <br />
    <span style="color:#5C062D;float:right">
        <asp:Label ID="registerLbl" runat="server"></asp:Label>

    </span>
        <br />
    </td>
</tr>
</table>

    </span></asp:Content>

