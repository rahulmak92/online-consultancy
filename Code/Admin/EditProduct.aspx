<%@ Page Title="" Language="C#" MasterPageFile="~/Admin/MasterPageAdmin.master" AutoEventWireup="true" CodeFile="EditProduct.aspx.cs" Inherits="Admin_EditProduct" %>

<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
<br />
<span style="font-size:x-large;margin-left:40px"><b>Edit Product</b></span>
<br />
<br />
<span style="margin-left:150px;text-align:center">

    <asp:GridView ID="GridView1" runat="server" AllowPaging="True" 
        AllowSorting="True" AutoGenerateColumns="False" DataKeyNames="Id" 
        DataSourceID="SqlDataSource1" BackColor="White" CssClass="gridview_margin" 
        BorderColor="#CCCCCC" BorderStyle="None" BorderWidth="1px" CellPadding="3">
        <Columns>
            <asp:BoundField DataField="Id" HeaderText="ID" InsertVisible="False" 
                ReadOnly="True" SortExpression="Id" ControlStyle-Width="1px" >
<ControlStyle Width="1px"></ControlStyle>
            </asp:BoundField>
            <asp:BoundField DataField="productNumber" HeaderText="Product Number" 
                SortExpression="productNumber" />
            <asp:BoundField DataField="productName" HeaderText="Product Name" 
                SortExpression="productName" />
            <asp:BoundField DataField="description" HeaderText="Description" 
                SortExpression="description" />
            <asp:BoundField DataField="price" HeaderText="Price" SortExpression="price" />
            <asp:BoundField DataField="releasedate" HeaderText="Release Date" 
                SortExpression="releasedate" />
            <asp:BoundField DataField="productPicture" HeaderText="Product Picture" 
                SortExpression="productPicture" />
            <asp:BoundField DataField="productFile" HeaderText="Product File" 
                SortExpression="productFile" />
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
        <EditRowStyle  />
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
        SelectCommand="SELECT * FROM [StoreMaster]"
        UpdateCommand="UPDATE [StoreMaster] SET productNumber=@productNumber,productName=@productName,description=@description,price=@price,releasedate=@releasedate,productPicture=@productPicture,productFile=@productFile WHERE Id=@Id" 
        DeleteCommand="DELETE FROM StoreMaster WHERE Id=@Id">
        <UpdateParameters>
        <asp:Parameter Name="productNumber" Type="Int32" />
        <asp:Parameter Name="productName" Type="String" />
        <asp:Parameter Name="description" Type="String" />
        <asp:Parameter Name="price" Type="Decimal" />
        <asp:Parameter Name="releasedate" Type="DateTime" />
        <asp:Parameter Name="productPicture" Type="String" />
        <asp:Parameter Name="productFile" Type="String" />
        <asp:Parameter Name="Id" Type="Int32" />
        </UpdateParameters>
        <DeleteParameters>
        <asp:Parameter Name="Id" Type="Int32" />
        </DeleteParameters>
        </asp:SqlDataSource>

</asp:Content>

