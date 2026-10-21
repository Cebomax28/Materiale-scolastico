using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace _03_SessionCookies
{
    public partial class Login : System.Web.UI.Page
    {
        const string USERNAME_VALIDO = "admin";
        const string PASSWORD_VALIDA = "admin123";
        protected void Page_Load(object sender, EventArgs e)
        {
            if(!IsPostBack)
            {
                // Se esiste già un cookie "UltimoAccesso" 
                // precompiliamo il campo username per comodità
                HttpCookie cookieUtente = Request.Cookies["UltimoAccesso"];
                if (cookieUtente != null)
                {
                    txtUsername.Text = cookieUtente.Value;
                }
            }
        }
        protected void btnAccedi_Click(object sender, EventArgs e)
        {
            string username = txtUsername.Text.Trim();
            string password = txtPassword.Text;

            //Verifica del login
            if (username == USERNAME_VALIDO && password == PASSWORD_VALIDA)
            {
                // SESSIONE: memorizziamo lo stato di autenticazione lato server 
                Session["Username"] = username;
                Session["OraLogin"] = DateTime.Now;

                // COOKIE: memorizziamo lato client l'ultimo utente che ha effettuato il log
                HttpCookie cookieUtente = new HttpCookie("UltimoAccesso", username);
                if (chkRicordami.Checked)
                    cookieUtente.Expires = DateTime.Now.AddDays(10);

                Response.Cookies.Add(cookieUtente);
                Response.Redirect("Home.aspx");
            }
            else
                ltlMessaggio.Text = "<div class='alert alert-danger'>Nome utente o password non validi</div>";
        }
    }
}