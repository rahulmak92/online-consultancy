<%@ Page Title="" Language="C#" MasterPageFile="~/Admin/MasterPageAdmin.master" AutoEventWireup="true" CodeFile="ExpandUser.aspx.cs" Inherits="Admin_ExpandUser" %>

<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
<br />
<span style="font-size:x-large;margin-left:20px"><b>Info for User: </b></span><asp:Label runat="server" Text="" Font-Bold="true" ForeColor="Blue" ID="Label1" Font-Size="Large"></asp:Label>
<br />
<br /><span style="margin-left:150px"><asp:Label ID="Label2" runat="server" Text="" ForeColor="Red"></asp:Label></span>
<br />
<br />
<table style="margin-left:150px">
    <tr>
        <td>Username:</td>
        <td>
            <asp:TextBox ID="TextUsername" runat="server" Width="290px" Enabled="false"></asp:TextBox>
        </td>
    </tr>
    <tr><td></td></tr>
    <tr><td></td></tr> 
    <tr>
        <td>Password:</td>
        <td>
            <asp:TextBox ID="TextPassword" runat="server" Width="290px" Enabled="false"></asp:TextBox>
        </td>
    </tr>
    <tr><td></td></tr>
    <tr><td></td></tr> 
    <tr>
        <td>FirstName:</td>
        <td>
            <asp:TextBox ID="TextBox1" runat="server" Width="290px"></asp:TextBox>
        </td>
    </tr>
    <tr><td></td></tr>
    <tr><td></td></tr>   
    <tr>
        <td>LastName</td>
        <td>
            <asp:TextBox ID="TextBox2" runat="server" Width="290px"></asp:TextBox>
        </td>
    </tr>
    <tr><td></td></tr>
    <tr><td></td></tr>   
    <tr>
        <td>Email:</td>
        <td>
            <asp:TextBox ID="TextBox3" runat="server" Width="290px"></asp:TextBox>
        </td>
    </tr>
    <tr><td></td></tr>
    <tr><td></td></tr>   
    <tr>
        <td>Contact No:</td>
        <td>
            <asp:TextBox ID="TextBox4" runat="server" Width="290px"></asp:TextBox>
        </td>
    </tr>
    <tr><td></td></tr>
    <tr><td></td></tr>   
    <tr>
        <td>Active:</td>
        <td>
            <asp:DropDownList ID="DropDownList1" runat="server" Width="290px">
            </asp:DropDownList>
        </td>
    </tr>
    <tr><td></td></tr>
    <tr><td></td></tr>   
    <tr>
        <td>Role</td>
        <td>
            <asp:DropDownList ID="DropDownList2" runat="server" Width="290px">
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

