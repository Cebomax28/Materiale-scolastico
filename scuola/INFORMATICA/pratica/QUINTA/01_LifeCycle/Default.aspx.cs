using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace _01_LifeCycle
{
    public partial class Default : System.Web.UI.Page
    {
        private readonly StringBuilder _log = new StringBuilder();
        /*
        Primo evento in assoluto.
            NON ESISTONO ancora: i controlli (Button, TextBox, Label...)
        Uso tipici:
            - Impostare il tema della pagina
            - Impostare MasterPage
            - Creare controlli server dinamicamente
         */
        protected void Page_PreInit(object sender, EventArgs e)
        {
            StampaMessaggio("ev-preinit", "Page_PreInit", "1° Evento. I controlli non esistono ancora." +
                " Usato per impostare il tema della pagina, MasterPage, creazione controlli dinamici");
        }

        /*
         I controlli ASP.NET (txtNome, lblRisposta...) sono creati e accessibili
        Però il ViewState non è ancora stato ripristinato:
            - txtNome.Text è vuoto anche se l'utete aveva già scritto qualcosa PostBack precedente
         */

        protected void Page_Init(object sender, EventArgs e)
        {
            StampaMessaggio("ev-preinit", "Page_PreInit", "2° Evento. I componenti esistono e sono accessibili." +
                            " Il ViewState NON è ancora ripristinato txtNome.Text = " + txtNome.Text + " (ancora vuoto)");
        }
        /*
         Evento più utilizzato.
         - I controlli esistono
         - Il ViewState è ripristinato
         - i dati POST del form sono disponibili

         IsPostBack = false -> prima visita (GET): inizializza i dati
         IsPostBack = true -> PostBack: la pagina è stata ricaricata da un'iterazione dell'utente
         */
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            { // PRIMA VISITA
                StampaMessaggio("ev-load-get", "Page_Load", "<b>Prima Visita (GET)</b> - IsPostBack = false. " + 
                                "Questo blocco si esegue UNA VOLTA SOLA");
                lblRisposta.Text = "Primo caricamento della pagina. Scrivi il tuo nome.";
            }
            else
            {
                StampaMessaggio("ev-load-post", "Page_Load", "<b>PostBack</b> - IsPostBack = true. " +
                                "La pagina è stata ricaricata da un'azione dell'utente chiamato: " + txtNome.Text);
            }
        }

        /*
         Viene scatenato SOLO quando l'utente clicca sul btnInvia
         Viene esegue DOPO Page_Load e prima del PreRender
         */

        protected void btnInvia_Click(object sender, EventArgs e)
        {
            Response.Write("");
        }

        /*
        L'ultimo evento PRIMA del rendering HTML
        ViewState serializzato in un campo hidden
        Poi inizia il rendering HTML che viene inviato al browser
        */

        protected void Page_PreRender(object sender, EventArgs e)
        {
            StampaMessaggio("ev-prerender", "Page_PreRender", "Ultimo eveno PRIMA del rendering HTML. ViewState viene serializzato in un campo nascosto");
            ltlLog.Text = _log.ToString();
        }
        /*
        La trasmissione di risposta HTTP è gia stata inviata al client.
        Non possono più essere modificati i controlli e la risposta

        Usi:
        -Chiudere connessioni a database
        -Liberare risorse
        -Elaborare la diagnostica
        */

        protected void Page_Unload(object sender, EventArgs e)
        {

        }

        private void StampaMessaggio(string cssClass, string nomeEvento, string descrizione)
        {
            _log.AppendFormat("<div class='evento {0}'>" + 
                              "<span class='nome-evento'>{1}</span>" +
                               "<span class='desc-evento'>{2}</span>" +
                               "</div>",
                               cssClass,
                               nomeEvento,
                               descrizione);
        }

    }
}