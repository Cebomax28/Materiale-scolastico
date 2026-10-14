<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Error.aspx.cs" Inherits="_03_SessionCookies.Error" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
    <link href="https://cdn.jsdelivr.net/npm/bootstrap@5.3.0/dist/css/bootstrap.min.css" rel="stylesheet" />
</head>
<body>
    <form id="form1" runat="server">
        <div class="container mt-5" style="max-width: 600px">
            <h2 class="text-center">Si è verificato un errore</h2>
            <p><asp:Literal ID="ltlErrore" runat="server" /></p>
            <a class="btn btn-primary" href="Login.aspx"> Torna al Login</a>
        </div>
    </form>
</body>
</html>
