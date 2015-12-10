<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPagePostLogin.master" AutoEventWireup="true" CodeFile="BusinessRequest.aspx.cs" Inherits="BusinessRequest" %>
<%@ Register TagPrefix="asp" Namespace="AjaxControlToolkit" Assembly="AjaxControlToolkit" %>

<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <asp:Button ID="Button1" runat="server" Width="212" Height="50" CssClass="btn2" Text="∇ REQUEST" BackColor="#DAC2CF" />
<asp:Button ID="Button2" runat="server" Width="212" Height="50" CssClass="btn2" 
        Text="⊲ HISTORY" onclick="Button2_Click" CausesValidation="false" />
<asp:ToolkitScriptManager ID="ToolkitScriptManager1" runat="server">
</asp:ToolkitScriptManager>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder2" Runat="Server">
    <br />
&nbsp
<a href="Business.aspx" style="font-size:small;color:#7a0c4a;text-decoration:none">Business Planning »</a>&nbsp;
<span style="font-size:small;text-decoration:none">Business Planning Request</span>
<br />
&nbsp;----------------------------------------------------------------------------------------------------------------------
<br />
    <br />
    <br />

&nbsp&nbsp&nbsp&nbsp;<span style="color:#5C062D;font-size:x-large">Add Request<br /></span>&nbsp;
<br />
<span style="font-size:small">
<table>
<tr><td style="height: 26px;width: 300px">Name</td>
<td style="height: 26px"><asp:TextBox ID="txtName" runat="server" Width="292px" 
        Height="22px"></asp:TextBox>
    <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" 
        ErrorMessage="Field can not be left empty" ForeColor="Red" ControlToValidate="txtName"></asp:RequiredFieldValidator>
    <br />
    <br />
    </td>
</tr>


<tr>
    <td>Email</td>
    <td><asp:TextBox ID="txtMail" runat="server" style="margin-left: 0px" Width="291px" 
            Height="22px">
        </asp:TextBox><asp:RegularExpressionValidator ID="RegularExpressionValidator1" runat="server" 
            ErrorMessage="Invalid Email Id" ForeColor="Red" ValidationExpression="\w+([-+.']\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*" ControlToValidate="txtMail"></asp:RegularExpressionValidator>
            <br /><br /></td>
    
</tr>

<tr>
    <td>Request Title</td>
    <td><asp:TextBox ID="txtTitle" runat="server" style="margin-left: 1px" 
            Width="290px" Height="22px"></asp:TextBox>
            <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" 
            ErrorMessage="Please Enter suitable title" ForeColor="Red" ControlToValidate="txtTitle"></asp:RequiredFieldValidator>
            <br /><br /></td>
</tr>
   

<tr>
    <td>Request Type</td>
    <td><asp:DropDownList ID="DropDownList1" runat="server" Height="22px" Width="293px">
    </asp:DropDownList><br /><br /></td>
</tr>    
   

<tr>
<td>Deadline</td>
<td><asp:TextBox ID="txtDeadline" runat="server" Width="190px" Height="22px"></asp:TextBox>
<span style="font-size:smaller">
        <asp:Image ID="Image1" runat="server" ImageUrl="~/Images/button-calendar.gif" />
        <asp:CalendarExtender ID="txtCalendar_CalendarExtender" runat="server" 
            TargetControlID="txtDeadline" PopupButtonID="Image1">
        </asp:CalendarExtender>
    <asp:CustomValidator ID="CustomValidator1" runat="server" ErrorMessage="Minimum deadline must be after 20 days of request" ForeColor="Red" ControlToValidate="txtDeadline" OnServerValidate="DateValidate"></asp:CustomValidator>
    <br />
</span><br /></td>
</tr>
   

<tr>
<td>Description</td>
<td><asp:TextBox ID="txtDescription" runat="server" style="margin-left: 0px" TextMode="MultiLine" Width="291px" Rows="4"></asp:TextBox>
<br /><br /></td>
</tr>    
   
<tr>
<td>Upload File</td>
<td><asp:FileUpload ID="FileUpload1" runat="server" Width="292px" />
    <asp:Label ID="Label1" runat="server" ForeColor="Red" 
        Text="*Size must be less than 1 MB"></asp:Label>
    <br /><br /></td>
</tr> 
</table>   
    <asp:Button ID="btnSubmit" runat="server" Text="Submit" Width="92px" 
        Visible="true" CssClass="btnsubmit" onclick="btnSubmit_Click" />
        <span style="margin-left:100px">
<asp:Label ID="lblFileUpload" runat="server" Text=""></asp:Label>
    <asp:Label ID="lblResult" runat="server" Text="" ForeColor="Red"></asp:Label>
    </span>
</span>
</asp:Content>

