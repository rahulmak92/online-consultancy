<%@ Page Title="" Language="C#" MasterPageFile="~/Admin/MasterPageAdmin.master" AutoEventWireup="true" CodeFile="PremiumProductOrders.aspx.cs" Inherits="Admin_PremiumProductOrders" %>

<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
<br />
<span style="font-size:x-large;margin-left:40px"><b>Premium Product Orders</b></span>
<br />
<br />
<span style="margin-left:40px;text-align:center">
    <asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="False" 
        BackColor="White" BorderColor="#CCCCCC" BorderStyle="None" BorderWidth="1px" 
        CellPadding="3" DataKeyNames="POId" DataSourceID="SqlDataSource1" 
        OnRowCommand="GridView1_RowCommand" AllowPaging="True" AllowSorting="True">
        <Columns>
            <asp:BoundField DataField="POId" HeaderText="Order ID" InsertVisible="False" 
                ReadOnly="True" SortExpression="POId" />          
            <asp:BoundField DataField="username" HeaderText="Username" 
                SortExpression="username" />
            <asp:BoundField DataField="email" HeaderText="Email" SortExpression="email" />
            <asp:BoundField DataField="contactno" HeaderText="Contact No" 
                SortExpression="contactno" />
            <asp:BoundField DataField="productNumber" HeaderText="Product No" 
                SortExpression="productNumber" />
            <asp:BoundField DataField="productName" HeaderText="Product Name" 
                SortExpression="productName" />
            <asp:BoundField DataField="price" HeaderText="Price($)" SortExpression="price" />           
            <asp:BoundField DataField="paymentstatus" HeaderText="Status" 
                SortExpression="paymentstatus" />            
            <asp:BoundField DataField="transcationid" HeaderText="Transcation ID" 
                SortExpression="transcationid" />
            <asp:TemplateField HeaderText="Other Details">
                <ItemTemplate>
                    <asp:LinkButton ID="LinkButton1" runat="server" CommandName="ViewOrder" CommandArgument="<%# ((GridViewRow) Container).RowIndex %>">View</asp:LinkButton>
                </ItemTemplate>
            </asp:TemplateField>
        </Columns>
        <FooterStyle BackColor="White" ForeColor="#000066" />
        <HeaderStyle BackColor="#31A1E7" Font-Bold="True" ForeColor="White" />
        <PagerStyle BackColor="White" ForeColor="#000066" HorizontalAlign="Left" />
        <RowStyle ForeColor="#000066" />
        <SelectedRowStyle BackColor="#669999" Font-Bold="True" ForeColor="White" />
        <SortedAscendingCellStyle BackColor="#F1F1F1" />
        <SortedAscendingHeaderStyle BackColor="#007DBB" />
        <SortedDescendingCellStyle BackColor="#CAC9C9" />
        <SortedDescendingHeaderStyle BackColor="#00547E" />
    </asp:GridView>
    </span>
    <asp:SqlDataSource ID="SqlDataSource1" runat="server" 
        ConnectionString="<%$ ConnectionStrings:ConnectionString %>" 
        SelectCommand="SELECT [POId], [firstname], [lastname], [username], [email], [contactno], [productNumber], [productName], [price], [orderdate], [paymentstatus], [IPaddress], [transcationid] FROM [Orders]">
    </asp:SqlDataSource>
</asp:Content>

