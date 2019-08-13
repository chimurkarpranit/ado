<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="EmployeeTerritories4.aspx.cs" Inherits="Day2.EmployeeTerritories4" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="false" AllowPaging="true" OnPageIndexChanging="OnPageIndexChanging" PageSize="5" Height="439px" style="margin-bottom: 61px" Width="986px">
            <AlternatingRowStyle BackColor="#CCCCCC" />
            <FooterStyle BackColor="#CCCCCC" />
            <HeaderStyle BackColor="Black" Font-Bold="True" ForeColor="White" />
            <PagerStyle BackColor="#999999" ForeColor="Black" HorizontalAlign="Center" />
            <SelectedRowStyle BackColor="#000099" Font-Bold="True" ForeColor="White" />
            <SortedAscendingCellStyle BackColor="#F1F1F1" />
            <SortedAscendingHeaderStyle BackColor="#808080" />
            <SortedDescendingCellStyle BackColor="#CAC9C9" />
            <SortedDescendingHeaderStyle BackColor="#383838" />
            <Columns>
                <asp:BoundField ItemStyle-Width="150px" DataField="EmployeeID" HeaderText="EmployeeID" />
                <asp:BoundField ItemStyle-Width="150px" DataField="TerritoryID" HeaderText="TerritoryID" />
            </Columns>
        </asp:GridView>
    </form>
</body>
</html>
