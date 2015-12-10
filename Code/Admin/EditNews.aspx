<%@ Page Title="" Language="C#" MasterPageFile="~/Admin/MasterPageAdmin.master" AutoEventWireup="true" CodeFile="EditNews.aspx.cs" Inherits="Admin_EditNews" %>

<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
<br />
<span style="font-size:x-large;margin-left:40px"><b>Edit News</b></span>
<br />
<br />
<span style="margin-left:150px;text-align:center">
<asp:GridView ID="GridView1" runat="server" AllowPaging="True" AllowSorting="True" 
        AutoGenerateColumns="False" DataKeyNames="Id" 
        DataSourceID="SqlDataSource1" BackColor="White" BorderColor="#CCCCCC" 
        BorderStyle="None" BorderWidth="1px" CellPadding="3" CssClass="gridview_margin">
    <Columns>
        <asp:BoundField DataField="Id" HeaderText="ID" InsertVisible="False" 
            ReadOnly="True" SortExpression="Id" />
        <asp:BoundField DataField="NewsHeadlines" HeaderText="News Headlines" 
            SortExpression="NewsHeadlines" />
        <asp:BoundField DataField="NewsDetails" HeaderText="News Details" 
            SortExpression="NewsDetails" />
        <asp:BoundField DataField="ExpiryDate" HeaderText="Expiry Date" 
            SortExpression="ExpiryDate" />
        <asp:BoundField DataField="PublishDate" HeaderText="Publish Date" 
            SortExpression="PublishDate" />
        <asp:CommandField ButtonType="Image" 
            EditImageUrl="~/Admin/in-admin-panel/images/user_edit.png" HeaderText="Edit" 
            ShowEditButton="True" ShowHeader="True" />
        <asp:TemplateField HeaderText="Delete">
            <ItemTemplate>
                <asp:ImageButton ID="ImageButton1" runat="server" OnClientClick="return confirm('Are you sure you want to delete this event?');" 
                    CommandName="Delete" ImageUrl="~/Admin/in-admin-panel/images/trash.png" 
                    Text="Delete" />
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
        SelectCommand="SELECT * FROM [NewsManagement]"
        UpdateCommand="UPDATE [NewsManagement] SET NewsHeadlines=@NewsHeadlines,NewsDetails=@NewsDetails,ExpiryDate=@ExpiryDate,PublishDate=@PublishDate WHERE Id=@Id"
        DeleteCommand="DELETE FROM NewsManagement WHERE Id=@Id">
        
        <UpdateParameters>
            <asp:Parameter Name="NewsHeadlines" Type="String" />
            <asp:Parameter Name="NewsDetails" Type="String" />
            <asp:Parameter Name="ExpiryDate" Type="DateTime" />
            <asp:Parameter Name="PublishDate" Type="DateTime" />
            <asp:Parameter Name="Id" Type="Int32" />
        </UpdateParameters>
        <DeleteParameters>
            <asp:Parameter Name="Id" Type="Int32" />
        </DeleteParameters>
        </asp:SqlDataSource>
        
</asp:Content>


