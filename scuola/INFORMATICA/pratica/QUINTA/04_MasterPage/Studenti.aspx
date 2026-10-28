<%@ Page Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Studenti.aspx.cs" Inherits="_04_MasterPage.Studenti" %>

<asp:Content ID="ContentStudenti" runat="server" ContentPlaceHolderID="MainContent">
    <h2>Elenco Studenti</h2>
    <asp:GridView ID="gvStudenti" runat="server" 
       AutoGenerateColumns="false" DataKeyNames="ID"
        CssClass="table table-bordered table-striped">

        <Columns>
            <asp:BoundField HeaderText="ID" DataField="ID" />
            <asp:BoundField HeaderText="Nome" DataField="Nome" />
            <asp:BoundField HeaderText="Cognome" DataField="Cognome" />
            <asp:BoundField HeaderText="Matricola" DataField="Matricola" />
            <asp:BoundField HeaderText="Data di Nascita" DataField="DataNascita" DataFormatString="{0:dd/MM/yyyy}" />
            <asp:BoundField HeaderText="Classe" DataField="Classe" />
        </Columns>
    </asp:GridView>
</asp:Content>