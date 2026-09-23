<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="_01_LifeCycle.Default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <meta http-equiv="Content-Type" content="text/html; charset=utf-8" />
    <title>Ciclo di vita della pagina ASP.NET</title>
    <link rel="stylesheet" href="https://cdn.jsdelivr.net/npm/bootstrap@5.3.3/dist/css/bootstrap.min.css" integrity="sha384-QWTKZyjpPEjISv5WaRU9OFeRpok6YctnYmDr5pNlyT2bRjXh0JMhjY6hW+ALEwIH" crossorigin="anonymous">

    <style>
        /* ─── Stile per il pannello di log degli eventi ──────────────── */
        .evento {
            display: flex;
            align-items: flex-start;
            gap: 10px;
            padding: 8px 14px;
            margin: 3px 0;
            border-radius: 6px;
            border-left: 5px solid #adb5bd;
            background: #f8f9fa;
            font-size: 0.87rem;
        }

        .nome-evento {
            font-family: 'Courier New', monospace;
            font-weight: 700;
            min-width: 190px;
            flex-shrink: 0;
        }

        .desc-evento {
            color: #495057;
            line-height: 1.4;
        }

        /* Colore bordo diverso per ogni tipo di evento */
        .ev-preinit {
            border-left-color: #6f42c1;
            background: #f5f0ff;
        }

            .ev-preinit .nome-evento {
                color: #6f42c1;
            }

        .ev-init {
            border-left-color: #20c997;
            background: #f0fff8;
        }

            .ev-init .nome-evento {
                color: #20c997;
            }

        .ev-load-get {
            border-left-color: #0d6efd;
            background: #eff6ff;
        }

            .ev-load-get .nome-evento {
                color: #0d6efd;
            }

        .ev-load-post {
            border-left-color: #fd7e14;
            background: #fff3e0;
        }

            .ev-load-post .nome-evento {
                color: #fd7e14;
            }

        .ev-click {
            border-left-color: #dc3545;
            background: #fff0f0;
        }

            .ev-click .nome-evento {
                color: #dc3545;
            }

        .ev-prerender {
            border-left-color: #198754;
            background: #f0fff4;
        }

            .ev-prerender .nome-evento {
                color: #198754;
            }

        .ev-unload {
            border-left-color: #adb5bd;
            opacity: 0.7;
        }

            .ev-unload .nome-evento {
                color: #6c757d;
            }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <div class="container py-4">
            <div class="mb-4">
                <h1 class="h2 fw-bold">Ese01 - Ciclo di vita della Pagina ASP.NET</h1>
                <p class="text-muted">
                    Carica la pagina e osserva gli eventi. 
                    Scrivi e <b>Invia</b> il tuo nome per generare PostBack
                </p>
            </div>
            <div class="row g-4">

                <div class="col-lg-7">
                    <div class="card shadow-sm">
                        <div class="card-header bg-primary text-white">
                            <b>Log eventi – questa richiesta HTTP</b>
                        </div>
                        <div class="card-body p-2">

                            <div class="evento ev-unload">
                                <span class="nome-evento">Page_Unload</span>
                                <span class="desc-evento">Avviene dopo che l'HTML è già stato inviato al browser.
                                    Non può modificare la risposta. Usato per: chiudere connessioni DB,
                                    liberare risorse non gestite, scrivere log su file.
                                </span>
                            </div>

                        </div>
                    </div>
                </div>
                <div class="col-lg-5 d-flex flex-column gap-3">

                    <div class="card shadow-sm">
                        <div class="card-header bg-success text-white">
                            <b>Genera un PostBack</b>
                        </div>
                        <div class="card-body">
                            <p class="small text-muted mb-2">
                                Scrivi il tuo nome e clicca  Invia .
                                La pagina si ricaricherà (PostBack) e osserverai
                                il cambiamento nel log a sinistra.
                            </p>

                            <div class="mb-2">
                                <label class="form-label fw-semibold small">Il tuo nome:</label>

                               
                            </div>

                            <div class="mt-2 p-2 bg-light rounded border">
                                <small class="text-muted d-block">Risposta del server:</small>
                            </div>
                        </div>
                    </div>

                    <div class="card shadow-sm">
                        <div class="card-header bg-secondary text-white">
                            <b>Ordine degli eventi</b>
                        </div>
                        <div class="card-body p-2">
                            <ol class="mb-0" style="font-size: 0.82rem; line-height: 1.9;">
                                <li><code>Page_PreInit</code> – temi, MasterPage</li>
                                <li><code>Page_Init</code> – controlli creati</li>
                                <li><em class="text-muted">→ ripristino ViewState </li>
                                <li><code>Page_Load</code> – controlla IsPostBack</li>
                                <li><em class="text-muted">→ eventi controlli (Button.Click...) </li>
                                <li><code>Page_PreRender</code> – ultime modifiche</li>
                                <li><em class="text-muted">→ salvataggio ViewState </li>
                                <li><em class="text-muted">→ rendering HTML → browser </li>
                                <li><code>Page_Unload</code> – rilascio risorse</li>
                            </ol>
                        </div>
                    </div>

                </div>
            </div>
        </div>
    </form>
</body>
</html>
