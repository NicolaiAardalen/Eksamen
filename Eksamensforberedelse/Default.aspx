<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="Eksamensforberedelse.Default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <link href="Content/bootstrap-grid.min.css" rel="stylesheet" />
    <script src="Scripts/bootstrap.min.js"></script>
</head>
<body>
    <form id="form1" runat="server">
        <asp:TextBox ID="SøkFornavnTextBox" runat="server"></asp:TextBox>
        <asp:Button ID="SøkFornavnButton" runat="server" Text="Søk på fornavn" OnClick="SøkFornavnButton_Click" />
        <br />
        <asp:TextBox ID="SøkKlasseTextBox" runat="server"></asp:TextBox>
        <asp:Button ID="SøkKlasseButton" runat="server" Text="Søk på klasse" OnClick="SøkKlasseButton_Click" />
        <br />
        <asp:TextBox ID="SøkFagTextBox" runat="server"></asp:TextBox>
        <asp:Button ID="SøkFagButton" runat="server" Text="Søk på fag" OnClick="SøkFagButton_Click" />
        <br />
        <br />
        <asp:Button ID="AlleEleverButton" runat="server" Text="Se alle elever" OnClick="AlleEleverButton_Click" />
        <br />
        <br />
        <asp:GridView ID="ElevGridView" runat="server" CellPadding="4" ForeColor="#333333" GridLines="None" Height="146px" PageSize="10" AllowPaging="true" Width="209px" OnPageIndexChanging="Elev_PageIndexChanging" OnSelectedIndexChanged="ElevGridView_SelectedIndexChanged1">
            <AlternatingRowStyle BackColor="White" ForeColor="#284775" />
            <EditRowStyle BackColor="#999999" />
            <FooterStyle BackColor="#5D7B9D" Font-Bold="True" ForeColor="White" />
            <HeaderStyle BackColor="#5D7B9D" Font-Bold="True" ForeColor="White" />
            <PagerStyle BackColor="#284775" ForeColor="White" HorizontalAlign="Center" />
            <RowStyle BackColor="#F7F6F3" ForeColor="#333333" />
            <SelectedRowStyle BackColor="#E2DED6" Font-Bold="True" ForeColor="#333333" />
            <SortedAscendingCellStyle BackColor="#E9E7E2" />
            <SortedAscendingHeaderStyle BackColor="#506C8C" />
            <SortedDescendingCellStyle BackColor="#FFFDF8" />
            <SortedDescendingHeaderStyle BackColor="#6F8DAE" />
        </asp:GridView>
        <br />
        <br />
        <asp:Button ID="GetKlassecount1A" runat="server" Text="Hvor mange elever i 1A" OnClick="GetKlassecount1A_Click" />
        <br />
        <asp:Button ID="GetKlassecount1B" runat="server" Text="Hvor mange elever i 1B" OnClick="GetKlassecount1B_Click" />
        <br />
        <asp:Label ID="countKlassemembers" runat="server" Visible="true"></asp:Label>
        <br />
        <br />
        <asp:Button ID="TeacherReportButton" runat="server" Text="TeaherReport" OnClick="TeacherReportButton_Click" />
    </form>
</body>
</html>
