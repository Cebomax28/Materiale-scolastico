<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Login.aspx.cs" Inherits="_03_SessionCookies.Login" %>

<!DOCTYPE html>
<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <meta charset="utf-8" />
    <title>Lab04 - Login</title>
    <link href="https://cdn.jsdelivr.net/npm/bootstrap@5.3.0/dist/css/bootstrap.min.css"
          rel="stylesheet" />
</head>
<body>
    <form id="form1" runat="server">
        <div class="container mt-5" style="max-width:450px;">
            <h2 class="mb-4">Accesso</h2>

            <div class="mb-3">
                <label class="form-label" for="txtUsername">Nome utente</label>
                <asp:TextBox ID="txtUsername" runat="server" CssClass="form-control" />
                <asp:RequiredFieldValidator ID="rfvUsername" runat="server"
                    ControlToValidate="txtUsername" ErrorMessage="Il nome utente è obbligatorio."
                    CssClass="text-danger" Display="Dynamic" />
            </div>

            <div class="mb-3">
                <label class="form-label" for="txtPassword">Password</label>
                <asp:TextBox ID="txtPassword" runat="server" CssClass="form-control" TextMode="Password" />
                <asp:RequiredFieldValidator ID="rfvPassword" runat="server"
                    ControlToValidate="txtPassword" ErrorMessage="La password è obbligatoria."
                    CssClass="text-danger" Display="Dynamic" />
            </div>

            <div class="mb-3 form-check">
                <asp:CheckBox ID="chkRicordami" runat="server" CssClass="form-check-input" />
                <label class="form-check-label" for="chkRicordami_Chk">Ricordami (cookie persistente)</label>
            </div>

            <asp:Button ID="btnAccedi" runat="server" Text="Accedi" CssClass="btn btn-primary"
                OnClick="btnAccedi_Click" />

            <div class="mt-3">
                <asp:Literal ID="ltlMessaggio" runat="server" />
            </div>

            <hr />
            <p class="text-muted small">
                Credenziali demo: <b>admin</b> / <b>admin123</b>
            </p>
        </div>
    </form>
</body>