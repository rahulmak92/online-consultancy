<%@ Page Title="" Language="C#" MasterPageFile="~/Admin/MasterPageAdmin.master" AutoEventWireup="true" CodeFile="ListUsers.aspx.cs" Inherits="Admin_ListUsers" %>

<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
<br />
<span style="font-size:x-large;margin-left:40px"><b>User List</b></span>
<br />
<br />
<span style="margin-left:150px;text-align:center">
<asp:GridView ID="GridView1" runat="server" AllowPaging="True" AllowSorting="True" 
        AutoGenerateColumns="False" DataKeyNames="id" 
        DataSourceID="SqlDataSource1" OnRowCommand="GridView1_RowCommand" 
        BackColor="White" BorderColor="#CCCCCC" BorderStyle="None" BorderWidth="1px" 
        CellPadding="3" Width="700px" Height="186px" CssClass="gridview_margin" OnRowDataBound="GridView1_RowDataBound" OnSelectedIndexChanging="GridView1_SelectedIndexChanging">
    <Columns>
        <asp:BoundField DataField="id" HeaderText="ID" InsertVisible="False" 
            ReadOnly="True" SortExpression="id" />
        <asp:BoundField DataField="username" HeaderText="Username" 
            SortExpression="username" />
        <asp:BoundField DataField="role" HeaderText="Role" SortExpression="role" />
        
        <asp:TemplateField HeaderText="Delete">
            <ItemTemplate>
                <asp:ImageButton ID="ImageButton1" runat="server" OnClientClick="return confirm('Are you sure you want to delete this event?');" 
                    CommandName="Delete" ImageUrl="~/Admin/in-admin-panel/images/trash.png" 
                    Text="Delete" />
            </ItemTemplate>
        </asp:TemplateField>
        <asp:TemplateField HeaderText="User Info">
            <ItemTemplate>
                <asp:LinkButton ID="LinkButton1" runat="server" CommandName="View" Text="View" CommandArgument="<%# ((GridViewRow) Container).RowIndex %>" ></asp:LinkButton>
            </ItemTemplate>
        </asp:TemplateField>
        <asp:TemplateField HeaderText="Active">
            <ItemTemplate>
                <asp:ImageButton ID="LinkButton2" runat="server" CommandName="Select" ImageUrl='<%# Eval("isactive") %>' Width="20px" Height="20px" />
            </ItemTemplate>
        </asp:TemplateField>
        <asp:BoundField DataField="isactive" HeaderText="isactive" SortExpression="isactive" ItemStyle-CssClass="hidecolumn" HeaderStyle-CssClass="hidecolumn" />
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
        SelectCommand="SELECT [id], [username], [role], [isactive] FROM [Users]"
        DeleteCommand="DELETE FROM Users WHERE id=@id">
        
        <DeleteParameters>
            <asp:Parameter Name="id" Type="Int32" />
        </DeleteParameters>
    </asp:SqlDataSource>

    <asp:Label ID="Label1" runat="server" Text=""></asp:Label>
</asp:Content>

