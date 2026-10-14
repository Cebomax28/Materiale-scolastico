<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Logout.aspx.cs" Inherits="_03_SessionCookies.Logout" %>

<!DOCTYPE html>
<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Lab04 - Logout</title>
    <link href="https://cdn.jsdelivr.net/npm/bootstrap@5.3.0/dist/css/bootstrap.min.css" rel="stylesheet" />
</head>
<body>
    <form id="form1" runat="server">
        <div class="container mt-5" style="max-width:450px;">
            <div class="alert alert-success">Logout effettuato con successo.</div>
            <a class="btn btn-primary" href="Login.aspx">Torna al login</a>
        </div>
    </form>
</body>
</html>