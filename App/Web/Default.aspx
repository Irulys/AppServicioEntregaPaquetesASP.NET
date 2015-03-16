<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="App.Web.Default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
        <asp:DetailsView ID="DetailsView1" runat="server" AllowPaging="True" AutoGenerateRows="False" CellPadding="4" DataSourceID="ObjectDataSource1" ForeColor="#333333" GridLines="None" Height="50px" Width="125px">
            <AlternatingRowStyle BackColor="White" />
            <CommandRowStyle BackColor="#D1DDF1" Font-Bold="True" />
            <EditRowStyle BackColor="#2461BF" />
            <FieldHeaderStyle BackColor="#DEE8F5" Font-Bold="True" />
            <Fields>
                <asp:BoundField DataField="Code" HeaderText="Code" SortExpression="Code" />
                <asp:BoundField DataField="Weight" HeaderText="Weight" SortExpression="Weight" />
                <asp:BoundField DataField="Cost" HeaderText="Cost" SortExpression="Cost" />
            </Fields>
            <FooterStyle BackColor="#507CD1" Font-Bold="True" ForeColor="White" />
            <HeaderStyle BackColor="#507CD1" Font-Bold="True" ForeColor="White" />
            <PagerStyle BackColor="#2461BF" ForeColor="White" HorizontalAlign="Center" />
            <RowStyle BackColor="#EFF3FB" />
        </asp:DetailsView>
        <asp:ObjectDataSource ID="ObjectDataSource1" runat="server" SelectMethod="getPackges" TypeName="App.Datos.BillsRepositories"></asp:ObjectDataSource>
    
    </div>
    </form>
</body>
</html>
