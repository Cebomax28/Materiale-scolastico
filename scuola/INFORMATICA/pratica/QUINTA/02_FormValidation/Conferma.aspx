<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Conferma.aspx.cs" Inherits="_02_FormValidation.Conferma" %>

<!DOCTYPE html>
    <html xmlns="http://www.w3.org/1999/xhtml">

    <head runat="server">
        <meta http-equiv="Content-Type" content="text/html; charset=utf-8" />
        <meta name="viewport" content="width=device-width, initial-scale=1" />
        <title>Lab02 – Form di Iscrizione con Validazione</title>
        <link rel="stylesheet" href="https://cdn.jsdelivr.net/npm/bootstrap@5.3.0/dist/css/bootstrap.min.css" />
        <style>
            /* Stile per i messaggi di errore dei validatori */
            .validator-msg {
                color: #dc3545;
                font-size: 0.82rem;
                display: block;
                margin-top: 2px;
            }

            /* Stile per il campo non valido */
            .input-invalid {
                border-color: #dc3545 !important;
            }
        </style>
    </head>

    <body class="bg-light">
        <form id="form1" runat="server">
            <div class="container py-4" style="max-width:680px;">

                <h1 class="h3 fw-bold mb-1">Lab02 – Form di Iscrizione</h1>
                <p class="text-muted mb-4">
                    Compila tutti i campi. La validazione avviene sia
                    <b>lato client</b> (JavaScript, immediata) sia
                    <b>lato server</b> (C#, sicura).
                </p>

                <%-- * SEZIONE 1: DATI ANAGRAFICI * --%>
                    <div class="card shadow-sm mb-3">
                        <div class="card-header bg-primary text-white fw-semibold">
                            👤 Dati Anagrafici
                        </div>
                        <div class="card-body">
                            <div class="row g-3">

                                <%-- ── NOME --%>
                                    <div class="col-md-6">
                                        <label class="form-label fw-semibold">
                                            Nome <span class="text-danger">*</span>
                                        </label>
                                        <asp:TextBox  runat="server" ID ="txtNome" CssClass="form-control" placeholder="Inserisci il nome"/>
                                        <asp:RequiredFieldValidator runat="server" ID="rfvNome" CssClass="validator-msg" ControlToValidate="txtNome" ErrorMessage="Il nome è obbligatorio" Text="Campo obbligatorio" Display="Dynamic"/>
                                    </div>

                                    <%-- ── COGNOME --%>
                                        <div class="col-md-6">
                                            <label class="form-label fw-semibold">
                                                Cognome <span class="text-danger">*</span>
                                            </label>
                                        <asp:TextBox  runat="server" ID ="txtCognome" CssClass="form-control" placeholder="Inserisci il cognome"/>
                                        <asp:RequiredFieldValidator runat="server" ID="rfvCognome" CssClass="validator-msg" ControlToValidate="txtCognome" ErrorMessage="Il cognome è obbligatorio" Text="Campo obbligatorio" Display="Dynamic"/>
                                        </div>

                                        <%-- ── ETÀ --%>
                                            <div class="col-md-4">
                                                <label class="form-label fw-semibold">
                                                    Età <span class="text-danger">*</span>
                                                </label>
                                        <asp:TextBox  runat="server" ID ="txtEta" CssClass="form-control" placeholder="Inserisci l'età"/>
                                        <asp:RequiredFieldValidator runat="server" ID="rfvEta" CssClass="validator-msg" ControlToValidate="txtEta" ErrorMessage="Il cognome è obbligatorio" Display="Dynamic"/>
                                        <asp:RangeValidator runat="server" ID="rvEta" CssClass="validator-msg" ControlToValidate="txtEta" ErrorMessage="L'età deve essere tra 18 e 99 anni" Text="Età non valida (18-99)" Display="Dynamic" Type="Integer" MinimumValue="18" MaximumValue="99" />
                                        </div>
                                            </div>
                            </div>
                        </div>
                    </div>

                    <%-- * SEZIONE 2: CONTATTI * --%>
                        <div class="card shadow-sm mb-3">
                            <div class="card-header bg-success text-white fw-semibold">
                                📧 Contatti
                            </div>
                            <div class="card-body">
                                <div class="row g-3">

                                    <%-- ── EMAIL --%>
                                        <div class="col-md-7">
                                            <label class="form-label fw-semibold">
                                                Email <span class="text-danger">*</span>
                                            </label>
                                        <asp:TextBox  runat="server" ID ="txtEmail" CssClass="form-control" placeholder="Inserisci l'email"/>
                                        <asp:RequiredFieldValidator runat="server" ID="rfvEmail" CssClass="validator-msg" ControlToValidate="txtEmail" ErrorMessage="L'email è obbligatoria" Text="Campo obbligatorio" Display="Dynamic"/>
                                        <asp:RegularExpressionValidator runat="server" ID="revEmail" ControlToValidate="txtEmail" CssClass="validator-msg" Text="Formato email non valido" ErrorMessage="Formato email non valido (es. nome@dom.it)" Display="Dynamic" ValidationExpression="^[a-zA-Z0-9._-]+@[a-zA-Z0-9].-]+\.[a-z-A-Z]{2,}?"/>
                                        </div>

                                        <%-- ── TELEFONO (opzionale ma formato obbligatorio) --%>
                                            <div class="col-md-5">
                                                <label class="form-label fw-semibold">
                                                    Telefono <small class="text-muted">(opzionale)</small>
                                                </label>

                                            </div>

                                </div>
                            </div>
                        </div>

                        <%-- * SEZIONE 3: ACCESSO * --%>
                            <div class="card shadow-sm mb-3">
                                <div class="card-header bg-warning text-dark fw-semibold">
                                    🔒 Credenziali di Accesso
                                </div>
                                <div class="card-body">
                                    <div class="row g-3">

                                        <%-- ── PASSWORD --%>
                                            <div class="col-md-6">
                                                <label class="form-label fw-semibold">
                                                    Password <span class="text-danger">*</span>
                                                </label>
                                                <asp:TextBox  runat="server" ID ="txtPassword" CssClass="form-control" TextMode="Password" placeholder="Inserisci la password"/>
                                                <asp:RequiredFieldValidator runat="server" ID="rfvPassword" CssClass="validator-msg" ControlToValidate="txtPassword" ErrorMessage="La password è obbligatoria" Text="Campo obbligatorio" Display="Dynamic"/>
                                                <asp:RegularExpressionValidator runat="server" ID="revPassword" ControlToValidate="txtPassword" CssClass="validator-msg" Text="Minimo 6 caratteri" ErrorMessage="La password deve avere almeno 6 caratteri" Display="Dynamic" ValidationExpression="^,{6, }$"/>

                                            </div>

                                            <%-- ── CONFERMA PASSWORD --%>
                                                <div class="col-md-6">
                                                    <label class="form-label fw-semibold">
                                                        Conferma Password <span class="text-danger">*</span>
                                                    </label>
                                                <asp:TextBox  runat="server" ID ="txtConfermaPassword" CssClass="form-control" TextMode="Password"/>
                                                <asp:RequiredFieldValidator runat="server" ID="rfvConfermaPassword" CssClass="validator-msg" ControlToValidate="txtConfermaPassword" ErrorMessage="Il conferma password è obbligatoria" Text="Campo obbligatorio" Display="Dynamic"/>
                                                    <asp:CompareValidator runat="server" ID="cvcConfermaPassowrd" ControlToValidate="txtConfermaPassword" ControlToCompare="txtPassword" Operator="Equal" Type="String" ErrorMessage="La conferma password è obbligatoria" Text="Le password devono coincidere" Display="Dynamic"/ CssClass="validator-msg">

                                                </div>

                                    </div>
                                </div>
                            </div>

                            <%-- * SEZIONE 4: CODICE FISCALE E TERMINI --%>
                                <div class="card shadow-sm mb-3">
                                    <div class="card-header bg-secondary text-white fw-semibold">
                                        📋 Informazioni Aggiuntive
                                    </div>
                                    <div class="card-body">

                                        <%-- ── CODICE FISCALE (CustomValidator) --%>
                                            <div class="mb-3">
                                                <label class="form-label fw-semibold">
                                                    Codice Fiscale <small class="text-muted">(opzionale – se inserito
                                                        deve avere 16 caratteri)</small>
                                                </label>

                                            </div>

                                            <%-- ── ACCETTAZIONE TERMINI (CustomValidator) --%>
                                                <div class="mb-2">

                                                    <label class="form-check-label" for="chkTermini">
                                                        Accetto i
                                                        <a href="#" onclick="return false;">termini e le condizioni</a>
                                                        <span class="text-danger">*</span>
                                                    </label>
                                                </div>
                                    </div>

                                </div>
            </div>



            <p class="text-muted small mt-2 text-center">
                * Campi obbligatori
            </p>

            </div>
        </form>

        <script>

        </script>

    </body>

    </html>