<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeFile="Partners.aspx.cs" Inherits="Partners" %>

<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
<span style="color:#5C062D">
               <asp:Label ID="Label2" runat="server" Font-Bold="true" Font-Size="X-Large" ></asp:Label>
           </span>
           <br />
           <br />
<span runat="server" id="span1"></span>

</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder2" Runat="Server">
<br />
<br />
    <div runat="server" id="div1">
    <table width="100%"  style="margin-left:10px">
    <tr>
    <td runat="server" id="td1">
        
    </td>
    </tr>
    </table>
    </div>
    <asp:LinkButton ID="link1" runat="server" Font-Underline="false" PostBackUrl="NewsPage.aspx" CssClass="linkposition" Font-Size="X-Small" ></asp:LinkButton> 
</asp:Content>

