<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Home.aspx.cs" Inherits="_03_SessionCookies.Home" %>

<!DOCTYPE html>
<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Lab04 - Home</title>
    <link href="https://cdn.jsdelivr.net/npm/bootstrap@5.3.0/dist/css/bootstrap.min.css" rel="stylesheet" />
</head>
<body>
    <form id="form1" runat="server">
        <div class="container mt-5" style="max-width:600px;">
            <h2 class="mb-4">Area riservata</h2>

            <div class="card mb-3">
                <div class="card-body">
                    <p>Benvenuto, <b><asp:Literal ID="ltlUsername" runat="server" /></b>!</p>
                    <p>Login effettuato il: <asp:Literal ID="ltlOraLogin" runat="server" /></p>
                    <p>Sessione iniziata il: <asp:Literal ID="ltlOraInizioSessione" runat="server" /></p>
                    <p>Accessi totali all'applicazione: <asp:Literal ID="ltlContatoreAccessi" runat="server" /></p>
                    <p>Cookie "UltimoAccesso" letto dal browser: <asp:Literal ID="ltlCookie" runat="server" /></p>
                </div>
            </div>

            <asp:Button ID="btnLogout" runat="server" Text="Logout" CssClass="btn btn-outline-danger"
                OnClick="btnLogout_Click" />
        </div>
    </form>
</body>
</html>