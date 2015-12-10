<%@ Page Title="" Language="C#" MasterPageFile="~/Admin/MasterPageAdmin.master" AutoEventWireup="true" CodeFile="ExpandVisaServices.aspx.cs" Inherits="Admin_ExpandVisaServices" %>

<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
<br />
<span style="font-size:x-large;margin-left:20px"><b>Edit Visa Request</b></span>
<br />
<br />
<span style="margin-left:150px"><asp:Label ID="Label1" runat="server" Text="" ForeColor="Red"></asp:Label></span>
<table style="margin-left:150px">
    <tr>
        <td>Req Id</td>
        <td>
            <asp:TextBox ID="TextBox1" runat="server" Enabled="False" Width="290px"></asp:TextBox>
        </td>
    </tr>
    <tr><td></td></tr>
    <tr><td></td></tr>
    <tr>
        <td>Username</td>
        <td>
            <asp:TextBox ID="TextBox2" runat="server" Enabled="False" Width="290px"></asp:TextBox>
        </td>
    </tr>
    <tr><td></td></tr>
    <tr><td></td></tr>
    <tr>
        <td>Name</td>
        <td>
            <asp:TextBox ID="TextBox3" runat="server" Enabled="False" Width="290px"></asp:TextBox>
        </td>
    </tr>
    <tr><td></td></tr>
    <tr><td></td></tr>
    <tr>
        <td>Email</td>
        <td>
            <asp:TextBox ID="TextBox4" runat="server" Enabled="False" Width="290px"></asp:TextBox>
        </td>
    </tr>
    <tr><td></td></tr>
    <tr><td></td></tr>
    <tr>
        <td>Title</td>
        <td>
            <asp:TextBox ID="TextBox5" runat="server" Enabled="False" Width="290px"></asp:TextBox>
        </td>
    </tr>
    <tr><td></td></tr>
    <tr><td></td></tr>
    <tr>
        <td>Type</td>
        <td>
            <asp:DropDownList ID="DropDownList1" runat="server" Width="290px" Enabled="false">
            </asp:DropDownList>
        </td>
    </tr>
    <tr><td></td></tr>
    <tr><td></td></tr>
    <tr>
        <td>Name of Applicant</td>
        <td>
            <asp:TextBox ID="TextBox6" runat="server" Enabled="False" Width="290px"></asp:TextBox>
        </td>
    </tr>
    <tr><td></td></tr>
    <tr><td></td></tr>
    <tr>
        <td>Date of Birth</td>
        <td>
            <asp:TextBox ID="TextBox7" runat="server" Enabled="False" Width="290px"></asp:TextBox>
        </td>
    </tr>
    <tr><td></td></tr>
    <tr><td></td></tr>
    <tr>
        <td>Passport No</td>
        <td>
            <asp:TextBox ID="TextBox8" runat="server" Enabled="False" Width="290px"></asp:TextBox>
        </td>
    </tr>
    <tr><td></td></tr>
    <tr><td></td></tr>
    <tr>
        <td>Mother's fullname</td>
        <td>
            <asp:TextBox ID="TextBox9" runat="server" Enabled="False" Width="290px"></asp:TextBox>
        </td>
    </tr>
    <tr><td></td></tr>
    <tr><td></td></tr>
    <tr>
        <td>Deadline</td>
        <td>
            <asp:TextBox ID="TextBox10" runat="server" Enabled="False" 
                Width="290px"></asp:TextBox>
        </td>
    </tr>
    <tr><td></td></tr>
    <tr><td></td></tr>
    <tr>
        <td>Description</td>
        <td>
            <asp:TextBox ID="TextBox11" runat="server" Enabled="False" Rows="4" 
                TextMode="MultiLine" Width="290px"></asp:TextBox>
        </td>
    </tr>
    <tr><td></td></tr>
    <tr><td></td></tr>
    <tr>
        <td>Status</td>
        <td>
            <asp:DropDownList ID="DropDownList2" runat="server" Width="290px">
            </asp:DropDownList>
        </td>
    </tr>
    <tr><td></td></tr>
    <tr><td></td></tr>
    <tr>
        <td>Result File</td>
        <td>
            <asp:FileUpload ID="FileUpload1" runat="server" />
            <asp:Label ID="lblError" runat="server" Text="" ForeColor="Red"></asp:Label>
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

