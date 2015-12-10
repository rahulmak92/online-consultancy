<%@ Page Title="" Language="C#" MasterPageFile="~/Admin/MasterPageAdmin.master" AutoEventWireup="true" CodeFile="AddProduct.aspx.cs" Inherits="Admin_AddProduct" %>
<%@ Register TagPrefix="asp" Namespace="AjaxControlToolkit" Assembly="AjaxControlToolkit"%>
<%@ Register assembly="AjaxControlToolkit" namespace="AjaxControlToolkit.HTMLEditor" tagprefix="cc1" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    
<br />
<span style="font-size:x-large;margin-left:20px"><b>Add Product</b></span>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
    <asp:Label ID="lbl" runat="server" Text="" ForeColor="Red"></asp:Label>
    <asp:Label ID="lblresult" runat="server" Text="" ForeColor="Red"></asp:Label>
<br />
<br />
<table style="margin-left:150px">
    <tr>
        <td>Product Number</td>
        <td>
            <asp:TextBox ID="TextBox1" runat="server" Width="290px"></asp:TextBox>
        </td>
    </tr>
    <tr><td></td></tr>
    <tr><td></td></tr>
    <tr>
        <td>Product Name</td>
        <td>
            <asp:TextBox ID="TextBox2" runat="server" Width="290px"></asp:TextBox>
        </td>
    </tr>
    <tr><td></td></tr>
    <tr><td></td></tr>
    <tr>
        <td>Description</td>
        <td>
            <asp:TextBox ID="TextBox3" runat="server" TextMode="MultiLine" Height="70px" 
                Width="290px"></asp:TextBox>
        </td>
    </tr>
    <tr><td></td></tr>
    <tr><td></td></tr>
    <tr>
        <td>Price</td>
        <td>
            <asp:TextBox ID="TextBox4" runat="server" Width="290px"></asp:TextBox>
        </td>
    </tr>
    <tr><td></td></tr>
    <tr><td></td></tr>
    <tr>
        <td>Release Date</td>
        <td>
            <asp:TextBox ID="TextBox5" runat="server" Width="290px"></asp:TextBox>
            <asp:CalendarExtender ID="TextBox5_CalendarExtender" runat="server" 
                TargetControlID="TextBox5" PopupButtonID="Image1">
            </asp:CalendarExtender>
            <asp:Image ID="Image1" runat="server" ImageUrl="~/Images/button-calendar.gif" />
       
        <asp:ToolkitScriptManager ID="ToolkitScriptManager1" runat="server">
        </asp:ToolkitScriptManager>
        </td>
    </tr>
    <tr><td></td></tr>
    <tr><td></td></tr>
    <tr>
        <td>Product Picture</td>
        <td>
            <asp:FileUpload ID="FileUpload1" runat="server" />
        </td>
    </tr>
    <tr><td></td></tr>
    <tr><td></td></tr>
    <tr>
        <td>Product File</td>
        <td>
            <asp:FileUpload ID="FileUpload2" runat="server" />
        </td>
    </tr>
    <tr><td></td></tr>
</table>

    <br />
    <span style="margin-left:300px">
    <asp:Button ID="Button1" runat="server" Text="Save" onclick="Button1_Click" />&nbsp&nbsp&nbsp;
    <asp:Button ID="Button2" runat="server" Text="Cancel" onclick="Button2_Click"/></span>
   
</asp:Content>

