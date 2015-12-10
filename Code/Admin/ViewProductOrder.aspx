<%@ Page Title="" Language="C#" MasterPageFile="~/Admin/MasterPageAdmin.master" AutoEventWireup="true" CodeFile="ViewProductOrder.aspx.cs" Inherits="ViewProductOrder" %>

<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
<br />
<span style="margin-left:40px;font-size:x-large">Order Details</span>
<br />
<br />
<table style="margin-left:40px;font-size:large">
<tr>
    <td>Order ID</td>
    <td><asp:Label ID="Label1" runat="server" Text=""></asp:Label></td>
</tr>
<tr><td></td></tr>

<tr>
    <td>Transaction ID</td>
    <td><asp:Label ID="Label2" runat="server" Text=""></asp:Label></td>
</tr>
<tr><td></td></tr>
<tr>
    <td>Product Sold To</td>
    <td><asp:Label ID="Label3" runat="server" Text=""></asp:Label></td>
</tr>
<tr><td></td></tr>
<tr>
    <td>Public IP Address</td>
    <td><asp:Label ID="Label4" runat="server" Text=""></asp:Label></td>
</tr>
<tr><td></td></tr>
<tr>
    <td>Order Date</td>
    <td><asp:Label ID="Label5" runat="server" Text=""></asp:Label></td>
</tr>

</table>
</asp:Content>

