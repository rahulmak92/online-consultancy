<%@ Page Title="" Language="C#" MasterPageFile="~/MasterVisa.master" AutoEventWireup="true" CodeFile="SuccessfulPayment.aspx.cs" Inherits="SuccessfulPayment" %>

<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
<asp:Button ID="Button1" runat="server" Width="212" Height="50" CssClass="btn2" Text="∇ Store" />
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder2" Runat="Server">
    <br />
    <br />
    <br />
    <br />
    
    <span style="margin-left:200px">
    <asp:Label ID="Label1" runat="server" Text="Thank You for Downloading...." Font-Bold="true" Font-Size="XX-Large"></asp:Label>
    </span>
    <br />
    <br />
    <asp:LinkButton runat="server" ID="download" Font-Bold="true" 
        Font-Underline="true" Font-Size="Larger" onclick="download_Click">Download Here</asp:LinkButton>
    <br />
    <br />
    <asp:LinkButton ID="LinkButton1" runat="server" Font-Underline="false" Font-Size="Small" ForeColor="#5C062D" PostBackUrl="~/Store.aspx">Return to Store</asp:LinkButton>
</asp:Content>

