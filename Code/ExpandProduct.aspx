<%@ Page Title="" Language="C#" MasterPageFile="~/MasterVisa.master" AutoEventWireup="true" CodeFile="ExpandProduct.aspx.cs" Inherits="ExpandProduct" %>

<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
<asp:Button ID="Button1" runat="server" Width="212" Height="50" CssClass="btn2" 
        Text="∇ Store" BackColor="#DAC2CF" onclick="Button1_Click" />
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder2" Runat="Server">
<br />
<br />
<span style="color:#5C062D;font-size:x-large;margin-left:30px">Download Center<br /></span>
<br />
<br />
<br />
<div id="Div1" style="width:40%;float:left" runat="server">
<br />
<img id="img1" runat="server" width="300" height="300" style="border:5px solid #000" />
</div>
<div id="Div2" style="width:60%;float:left" runat="server">
<br />
<asp:Label ID="lblName" runat="server" Text="" Font-Bold="true" Font-Size="XX-Large" ForeColor="#5C062D"></asp:Label>
<br />
<br />
<br />
<asp:Label ID="lblDesc" runat="server" Text="" ForeColor="GrayText"></asp:Label>
<br />
<br />
<span style="font-size:large">Price:  </span><asp:Label ID="lblPrice" runat="server" Text="" Font-Bold="true" Font-Size="Large" ForeColor="ControlDarkDark"></asp:Label>
</div>
<br />
<br />

    &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;

    <asp:Button ID="Button2" runat="server" CssClass="buy" Text="BUY" 
        onclick="Button2_Click"  />

</asp:Content>

