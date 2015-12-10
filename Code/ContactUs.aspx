<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPageLogin.master" AutoEventWireup="true" CodeFile="ContactUs.aspx.cs" Inherits="ContactUs" %>

<%@ Register src="GoogleMapForASPNet.ascx" tagname="GoogleMapForASPNet" tagprefix="uc1" %>

<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <div style="width:100%">
<div style="width:40%;float:left">
<span style="font-size:small">
Consultancy House
<br />
<br />
3rd floor, Saffron Tower,
<br />
<br />
Nr. Panchwati Circle,
<br />
<br />
Ahmedabad,Gujarat 380006
</span>
<br />
<br />
<span style="font-weight:bold;font-size:small">T: </span>
<span style="font-size:small">079-26609923</span>
<br />
<br />
<span style="font-weight:bold;font-size:small">E: </span>
<span style="font-size:small">enquiries@consultancyhouse.com</span>  
</div>
<div style="width:60%;float:left">
<span style="font-size:small">
Name: <span style="color:Red"> *&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; </span>
    &nbsp;<asp:TextBox ID="TextBox1" runat="server" Width="222px" 
        style="margin-left: 1px"></asp:TextBox>
    <asp:RegularExpressionValidator ID="RegularExpressionValidator1" runat="server" 
         ControlToValidate="TextBox1" ErrorMessage="<br />Invalid Name"  ValidationExpression="^[a-zA-Z''-'\s]{1,40}$" ForeColor="Red"></asp:RegularExpressionValidator>
    
    &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
    <span style="font-size:small">
    <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" 
        ErrorMessage="Above field Can not be left Empty" ControlToValidate="TextBox1" ForeColor="Red" ></asp:RequiredFieldValidator>
</span>
    
    <br />
    
E-mail: <span style="color:Red"> *&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; 
<span style="font-size:small">
    <asp:TextBox ID="TextBox2" runat="server" Width="222px" 
        style="margin-left: 2px"></asp:TextBox>
</span>
    </span>
    <br />
     <asp:RegularExpressionValidator ID="RegularExpressionValidator2"  runat="server" 
         ControlToValidate="TextBox2" ErrorMessage="Invalid Email id" ValidationExpression="\w+([-+.']\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*" ForeColor="Red"></asp:RegularExpressionValidator>
    &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;

    <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" 
        ErrorMessage="Above field Can not be left Empty" ControlToValidate="TextBox2" ForeColor="Red" ></asp:RequiredFieldValidator>
    <br />
Telephone: <span style="color:Red"> *&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; </span>&nbsp; 
    <asp:TextBox 
        ID="TextBox3" runat="server" Width="222px" style="margin-left: 2px"></asp:TextBox>
    <br />
    <asp:RegularExpressionValidator ID="RegularExpressionValidator3" runat="server" 
        ErrorMessage="Invalid Telephone no" ControlToValidate="TextBox3"  ForeColor="Red" ValidationExpression="\(?\d{3}\)?-? *\d{3}-? *-?\d{4}"></asp:RegularExpressionValidator>
    <asp:RequiredFieldValidator ID="RequiredFieldValidator3" runat="server" 
        ErrorMessage="Above field Can not be left Empty" ControlToValidate="TextBox3"  ForeColor="Red"></asp:RequiredFieldValidator>
    <br />
Message: <span style="color:Red"> &nbsp;
    <br />
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; </span>&nbsp;<asp:TextBox 
        ID="TextBox4" runat="server" Height="80px" Width="222px" Columns="255" 
        style="margin-left: 6px" TextMode="MultiLine"></asp:TextBox>
    <br />
    &nbsp;
    <br />
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
    <asp:Button ID="Button1" runat="server" Text="Submit" onclick="Button1_Click" />
    <asp:Label ID="Label1" runat="server"></asp:Label>
</span>
</div>    
</div>
<div style="border:2px solid #FFFFF">
    <uc1:GoogleMapForASPNet ID="GoogleMapForASPNet1" runat="server" />

</div>
</asp:Content>

