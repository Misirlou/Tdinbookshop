<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Default.aspx.cs" Inherits="_Default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Book Shop Website</title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <label>Nome Cliente:<asp:TextBox ID="tbName" runat="server" /></label><br />
        <label>Morada:<asp:TextBox ID="tbMorada" runat="server" /></label><br />
        <label>Email:<asp:TextBox ID="tbEmail" runat="server" /></label><br />
        <label>Livro: <asp:DropDownList ID="ddl1" runat="server"/></label><br />
        <label>Quantidade:<asp:TextBox ID="tbQuant" runat="server" /></label><br />
        <asp:Button ID="btGo" runat="server" OnClick="btGo_Click" Text="Confirmar Encomenda" />
    </div>
    </form>
</body>
</html>
