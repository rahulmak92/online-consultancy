<%@ Page Title="" Language="C#" MasterPageFile="~/Admin/MasterPageAdmin.master" AutoEventWireup="true" CodeFile="AddUser.aspx.cs" Inherits="Admin_AddUser" %>

<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
<br />
<span style="font-size:x-large;margin-left:20px"><b>Add User</b></span>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; &nbsp;
<asp:Label ID="lblresult" runat="server" Text="" ForeColor="Red"></asp:Label>
<br />
<br />
<table style="margin-left:150px">
    <tr>
        <td>Username:</td>
        <td>
            <asp:TextBox ID="TextBox1" runat="server" Width="290px"></asp:TextBox>
        </td>
    </tr>
    <tr><td></td></tr>
    <tr><td></td></tr>
    <tr>
        <td>Password:</td>
        <td>
            <asp:TextBox ID="TextBox2" runat="server" Width="290px" TextMode="Password"></asp:TextBox>
        </td>
    </tr>
    <tr><td></td></tr>
    <tr><td></td></tr>
    <tr>
        <td>First Name:</td>
        <td>
            <asp:TextBox ID="TextBox3" runat="server" Width="290px"></asp:TextBox>
        </td>
    </tr>
    <tr><td></td></tr>
    <tr><td></td></tr>
    <tr>
        <td>Last Name:</td>
        <td>
            <asp:TextBox ID="TextBox4" runat="server" Width="290px"></asp:TextBox>
        </td>
    </tr>
    <tr><td></td></tr>
    <tr><td></td></tr>
    <tr>
        <td>E-mail:</td>
        <td>
            <asp:TextBox ID="TextBox5" runat="server" Width="290px"></asp:TextBox>
        </td>
    </tr>
    <tr><td></td></tr>
    <tr><td></td></tr>
    <tr>
        <td>Contact No:</td>
        <td>
            <asp:TextBox ID="TextBox6" runat="server" Width="290px"></asp:TextBox>
        </td>
    </tr>
    <tr><td></td></tr>
    <tr><td></td></tr>
    <tr>
        <td>Active:</td>
        <td>
            <asp:DropDownList ID="DropDownList2" runat="server" Width="290px">
            </asp:DropDownList>
        </td>
    </tr>
    <tr><td></td></tr>
    <tr><td></td></tr>
    <tr>
        <td>Role:</td>
        <td>
            <asp:DropDownList ID="DropDownList1" runat="server" Width="290px">
            </asp:DropDownList>
        </td>
    </tr>
    <tr><td></td></tr>
    <tr><td></td></tr>
</table>
<span style="margin-left:300px">
    <asp:Button ID="Button1" runat="server" Text="Save" onclick="Button1_Click" />&nbsp&nbsp&nbsp;
    <asp:Button ID="Button2" runat="server" Text="Cancel" onclick="Button2_Click" />
</span>
</asp:Content>

