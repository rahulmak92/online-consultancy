<%@ Page Title="" Language="C#" MasterPageFile="~/Admin/MasterPageAdmin.master" AutoEventWireup="true" CodeFile="EditVisaServices.aspx.cs" Inherits="Admin_EditVisaServices" %>

<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
 <br />
<span style="font-size:x-large;margin-left:20px"><b>Visa Request</b></span>
<br />
<br /><asp:Label ID="Label1" runat="server" Text=""></asp:Label>
<span style="font-size:small;text-align:center">
<asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="False" 
        BackColor="White" BorderColor="#CCCCCC" BorderStyle="None" BorderWidth="1px" 
        CellPadding="3" DataKeyNames="requestId" DataSourceID="SqlDataSource1" OnRowCommand="GridView1_RowCommand">
    <Columns>
        <asp:BoundField DataField="requestId" HeaderText="Req ID" 
            InsertVisible="False" ReadOnly="True" SortExpression="requestId" ItemStyle-CssClass="hidecolumn" HeaderStyle-CssClass="hidecolumn" />
        <asp:BoundField DataField="username" HeaderText="Username" 
            SortExpression="username" />
        <asp:BoundField DataField="name" HeaderText="Name" SortExpression="name" />
        <asp:BoundField DataField="requestTitle" HeaderText="Title" 
            SortExpression="requestTitle" />
        <asp:BoundField DataField="requestType" HeaderText="Type" 
            SortExpression="requestType" />
        <asp:BoundField DataField="applicantName" HeaderText="Applicant Name" 
            SortExpression="applicantName" />
        <asp:BoundField DataField="deadline" HeaderText="Deadline" 
            SortExpression="deadline" />
        <asp:BoundField DataField="requestStatus" HeaderText="Status" 
            SortExpression="requestStatus" />
        <asp:TemplateField HeaderText="PassportFile" ItemStyle-CssClass="download">
                <ItemTemplate>
                    <asp:LinkButton ID="LinkButton1" runat="server" CommandName="DownloadPassportFile" CommandArgument="<%# ((GridViewRow) Container).RowIndex %>">Download</asp:LinkButton>
                </ItemTemplate>

<ItemStyle CssClass="download"></ItemStyle>
            </asp:TemplateField>
            <asp:TemplateField HeaderText="ClientFile">
                <ItemTemplate>
                    <asp:LinkButton ID="LinkButton3" runat="server" CommandName="DownloadClientFile" CommandArgument="<%# ((GridViewRow) Container).RowIndex %>">Download</asp:LinkButton>
                </ItemTemplate>
            </asp:TemplateField>
            <asp:TemplateField HeaderText="ResultFile">
                <ItemTemplate>
                    <asp:LinkButton ID="LinkButton2" runat="server" CommandName="DownloadResultFile" CommandArgument="<%# ((GridViewRow) Container).RowIndex %>">Download</asp:LinkButton>
                </ItemTemplate>
            </asp:TemplateField>
            <asp:TemplateField HeaderText="Edit">
                <ItemTemplate>
                    <asp:LinkButton ID="LinkButton4" runat="server" CommandName="EditRequest" CommandArgument="<%# ((GridViewRow) Container).RowIndex %>">Edit</asp:LinkButton>
                </ItemTemplate>
            </asp:TemplateField>
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
</asp:GridView></span>
    <asp:SqlDataSource ID="SqlDataSource1" runat="server" 
        ConnectionString="<%$ ConnectionStrings:ConnectionString %>" 
        SelectCommand="SELECT [requestId], [username], [name], [requestTitle], [requestType], [applicantName], [deadline], [requestStatus], [passportCopy], [uploadFile], [resultFile] FROM [RqstVisaServices]"
        DeleteCommand="DELETE FROM RqstVisaServices WHERE requestId=@requestId">
        <DeleteParameters>
            <asp:Parameter Name="requestId" Type="Int32" />
        </DeleteParameters>
    </asp:SqlDataSource>
</asp:Content>

