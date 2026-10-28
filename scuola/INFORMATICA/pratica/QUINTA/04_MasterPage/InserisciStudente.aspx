<%@ Page Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="InserisciStudente.aspx.cs" Inherits="_04_MasterPage.InserisciStudente" %>

<asp:Content ID="ContentAddStudente" runat="server" ContentPlaceHolderID="MainContent">
    <h2>Inserisci nuovo studente</h2>
    <asp:Label runat="server" ID="lblMessage"></asp:Label>
    <div class="container">
        <p>
            Nome: <asp:TextBox ID="txtNome" runat="server" CssClass="form-control"></asp:TextBox><br />
            Cognome: <asp:TextBox ID="txtCognome" runat="server" CssClass="form-control"></asp:TextBox><br />
            Matricola: <asp:TextBox ID="txtMatricola" runat="server" CssClass="form-control"></asp:TextBox><br />
            Data di Nascita: <asp:TextBox ID="txtDataNascita" TextMode="Date" runat="server" CssClass="form-control"></asp:TextBox><br />
            Classe:
            <asp:DropDownList runat="server" ID="ddlClasse" CssClass="form-control"></asp:DropDownList><br />
            <asp:Button ID="btnInserisci" runat="server" Text="Inserisci" CssClass="btn btn-primary" OnClick="btnInserisci_Click" />

        </p>
    </div>
</asp:Content>