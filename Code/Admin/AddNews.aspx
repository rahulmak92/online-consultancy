<%@ Page Title="" Language="C#" MasterPageFile="~/Admin/MasterPageAdmin.master" AutoEventWireup="true" CodeFile="AddNews.aspx.cs" Inherits="Admin_AddNews" %>
<%@ Register TagPrefix="asp" Namespace="AjaxControlToolkit" Assembly="AjaxControlToolkit"%>

<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
<br />
<span style="font-size:x-large;margin-left:20px"><b>Add News</b></span>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; &nbsp;
<asp:Label ID="lblresult" runat="server" Text="" ForeColor="Red"></asp:Label>
<br />
<br />
<table style="margin-left:150px">
    <tr>
        <td>News Headlines:</td>
        <td>
            <asp:TextBox ID="TextBox1" runat="server" Width="290px"></asp:TextBox>
        </td>
    </tr>
    <tr><td></td></tr>
    <tr><td></td></tr>
    <tr>
        <td>News Details:</td>
        <td><asp:TextBox ID="TextBox2" runat="server" Width="290px"></asp:TextBox></td>
    </tr>
    <tr><td></td></tr>
    <tr><td></td></tr>
    <tr>
        <td>Expiry Date:</td>
        <td><asp:ToolkitScriptManager ID="ToolkitScriptManager1" runat="server">
        </asp:ToolkitScriptManager><asp:TextBox ID="TextBox3" runat="server" Width="290px"></asp:TextBox>
            <img src="../Images/button-calendar.gif" id="Image1" alt="butcal" /><asp:CalendarExtender ID="CalendarExtender1" runat="server" PopupButtonID="Image1" TargetControlID="TextBox3">
            </asp:CalendarExtender>
        </td>
    </tr>
    <tr><td></td></tr>
    <tr><td></td></tr>
    <tr>
        <td>Publish Date:</td>
        <td><asp:TextBox ID="TextBox4" runat="server" Width="290px"></asp:TextBox>
        <img src="../Images/button-calendar.gif" id="Image2" alt="butcal" />
        <asp:CalendarExtender ID="CalendarExtender2" runat="server" PopupButtonID="Image2" TargetControlID="TextBox4">
            </asp:CalendarExtender></td>
    </tr>
    <tr><td></td></tr>
    <tr><td></td></tr>
</table>
<span style="margin-left:330px"></span>
<asp:Button ID="button1" runat="server" Text="Save" onclick="button1_Click"></asp:Button>&nbsp&nbsp&nbsp;
<asp:Button ID="button2" runat="server" Text="Cancel" onclick="button2_Click"></asp:Button>
</asp:Content>

