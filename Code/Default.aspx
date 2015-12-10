<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeFile="Default.aspx.cs" Inherits="_Default" %>

<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
            
            <span style="color:#5C062D">
               <asp:Label ID="Label2" runat="server" Font-Bold="true" Font-Size="X-Large" ></asp:Label>
           </span>
           
        
           <span style="color:Black">
               <asp:Label ID="Label3" runat="server" Font-Size="Larger" ></asp:Label>
           </span>
           <span style="font-size:small" runat="server" id="span1">         
           
           </span>
           <span style="color:#5C062D">
           <br />
           <br />
               <asp:Label ID="Label1" runat="server" Font-Bold="true" Font-Size="X-Large"></asp:Label>
           </span>
           <br />
           
           <img src="Images/customer.jpg" alt="customer friendly" align="right" runat="server" style="border:1px solid" />
           <span style="font-size:small" runat="server" id="span2">
           
           </span>
           
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder2" runat="server">
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

