<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="Eksamensforberedelse.Default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <asp:TextBox ID="SøkFornavnTextBox" runat="server"></asp:TextBox>
        <asp:Button ID="SøkFornavnButton" runat="server" Text="Søk på foravn" OnClick="SøkFornavnButton_Click" />
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
        <asp:GridView ID="ElevGridView" runat="server" CellPadding="4" ForeColor="#333333" GridLines="None" Height="146px" Width="209px">
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
    </form>
</body>
</html>
