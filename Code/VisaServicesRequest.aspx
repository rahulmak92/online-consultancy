<%@ Page Title="" Language="C#" MasterPageFile="~/MasterVisa.master" AutoEventWireup="true" CodeFile="VisaServicesRequest.aspx.cs" Inherits="VisaServicesRequest" %>
<%@ Register TagPrefix="asp" Namespace="AjaxControlToolkit" Assembly="AjaxControlToolkit"%>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <asp:Button ID="Button1" runat="server" Width="212" Height="50" CssClass="btn2" Text="∇ REQUEST" BackColor="#DAC2CF" />
<asp:Button ID="Button2" runat="server" Width="212" Height="50" CssClass="btn2" Text="⊲ HISTORY" onclick="Button2_Click" CausesValidation="false" />
<div style="background-color:#F0ECEC;height:582px">
</div>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder2" Runat="Server">
    <br />
&nbsp
<a href="VisaServices.aspx" style="font-size:small;color:#7a0c4a;text-decoration:none">Visa Services »</a>&nbsp;
<span style="font-size:small;text-decoration:none">Visa Services Request</span>
<br />
&nbsp;----------------------------------------------------------------------------------------------------------------------
<br />
    <br />
    <br />

&nbsp&nbsp&nbsp&nbsp;<span style="color:#5C062D;font-size:x-large">Add Request<span style="color:#5C062D;font-size:x-large"><span 
        style="font-size: small;">&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
<asp:Label ID="lblFileUpload" runat="server" Text="" ForeColor="Red"></asp:Label>
    <asp:Label ID="lblResult" runat="server" Text="" ForeColor="Red"></asp:Label>
    </span>
    </span><br /></span>&nbsp;
<br />
<span style="font-size:small">
<table>
<tr><td style="height: 26px;width: 300px">Name</td>
<td style="height: 26px"><asp:TextBox ID="txtName" runat="server" Width="292px" 
        Height="22px"></asp:TextBox>
    <br />
    <br />
    </td>
</tr>


<tr>
    <td style="height: 26px;width: 300px">Email</td>
    <td><asp:TextBox ID="txtMail" runat="server" style="margin-left: 0px" Width="291px" 
            Height="22px"></asp:TextBox><br /><br /></td>
</tr>

<tr>
    <td style="height: 26px;width: 300px">Request Title</td>
    <td><asp:TextBox ID="txtTitle" runat="server" style="margin-left: 1px" 
            Width="290px" Height="22px"></asp:TextBox><br /><br /></td>
</tr>
   

<tr>
    <td style="height: 26px;width: 300px">Request Type</td>
    <td><asp:DropDownList ID="DropDownList1" runat="server" Height="22px" Width="293px">
    </asp:DropDownList><br /><br /></td>
</tr>    
   
<tr>
    <td style="height: 26px;width: 300px">Name of Applicant</td>
    <td>
<span style="font-size:small">
        <asp:TextBox ID="txtNameOfAppl" runat="server" Width="292px" 
        Height="22px"></asp:TextBox>
        <asp:RequiredFieldValidator ID="RequiredFieldValidator3" runat="server" 
            ErrorMessage="*" ForeColor="Red" ControlToValidate="txtNameOfAppl"></asp:RequiredFieldValidator>
</span>
    </td>
</tr>

<tr>
    <td style="height: 26px;width: 300px">Date of Birth</td>
    <td>
<span style="font-size:small">
<span style="font-size:small">
        
        <asp:TextBox ID="txtCalendar" runat="server" Width="292px" 
        Height="22px"></asp:TextBox>
        <asp:CalendarExtender ID="txtCalendar_CalendarExtender" runat="server" 
            TargetControlID="txtCalendar" PopupButtonID="Image1" BehaviorID="myCEBID">
        </asp:CalendarExtender>
        <asp:Image ID="Image1" runat="server" ImageUrl="~/Images/button-calendar.gif" />
       
        <asp:ToolkitScriptManager ID="ToolkitScriptManager1" runat="server">
        </asp:ToolkitScriptManager>
       
      

</span>
    </span></td>
</tr>

<tr>
    <td style="height: 26px;width: 300px">Passport Number</td>
    <td>
<span style="font-size:small">
        <asp:TextBox ID="txtPassNo" runat="server" Width="292px" 
        Height="22px"></asp:TextBox>
        <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" 
            ErrorMessage="*" ForeColor="Red" ControlToValidate="txtPassNo"></asp:RequiredFieldValidator>
</span>
    </td>
</tr>

<tr>
    <td style="height: 26px;width: 300px">Mother's full name</td>
    <td>
<span style="font-size:small">
        <asp:TextBox ID="txtMother" runat="server" Width="292px" 
        Height="22px"></asp:TextBox>
</span>
    </td>
</tr>

<tr>
    <td style="height: 26px;width: 300px">Copy of passport</td>
    <td>
<span style="font-size:small">
        <asp:FileUpload ID="FileUpload2" runat="server" Width="292px" />
        <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" 
            ErrorMessage="*" ForeColor="Red" ControlToValidate="FileUpload2"></asp:RequiredFieldValidator>
</span>
    </td>
</tr>

<tr>
<td style="height: 26px;width: 300px">Deadline</td>
<td><asp:TextBox ID="txtDeadline" runat="server" Width="190px" Height="22px"></asp:TextBox>
<span style="font-size:small">
        <asp:Image ID="Image2" runat="server" ImageUrl="~/Images/button-calendar.gif" />
        <asp:CalendarExtender ID="CalendarExtender2" runat="server" 
            TargetControlID="txtDeadline" PopupButtonID="Image2">
        </asp:CalendarExtender>
    <asp:CustomValidator ID="CustomValidator1" runat="server" ErrorMessage="Minimum deadline must be after 20 days of request" ForeColor="Red" ControlToValidate="txtDeadline" OnServerValidate="DateValidate"></asp:CustomValidator>
</span><br /></td>
</tr>
   

<tr>
<td style="height: 26px;width: 300px">Description</td>
<td><asp:TextBox ID="txtDescription" runat="server" style="margin-left: 0px" TextMode="MultiLine" Width="291px" Rows="4"></asp:TextBox>
<br /><br /></td>
</tr>    
   
<tr>
<td style="height: 26px;width: 300px">Upload File</td>
<td><asp:FileUpload ID="FileUpload1" runat="server" Width="292px" /></td>
</tr> 
</table>
<asp:Button ID="btnSubmit" runat="server" Text="Submit" Width="92px" 
        Visible="true" CssClass="btnsubmit" onclick="btnSubmit_Click" />
        <span style="margin-left:100px">
</span>
    </span></asp:Content>   

