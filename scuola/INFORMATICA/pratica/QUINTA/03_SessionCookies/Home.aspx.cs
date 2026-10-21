using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace _03_SessionCookies
{
    public partial class Home : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["Username"] == null)
            {
                Response.Redirect("Login.aspx");
                return;
            }
            if(!IsPostBack)
            {
                ltlUsername.Text = Server.HtmlEncode(Session["Username"].ToString());
                if (Session["OraLogin"] != null)
                    ltlOraLogin.Text = ((DateTime)Session["OraLogin"]).ToString("dd/MM/yyyy HH:mm:ss");

                if (Session["OraInizioSessione"] != null)
                    ltlOraInizioSessione.Text = ((DateTime)Session["OraInizioSessione"]).ToString("dd/MM/yyyy HH:mm:ss");

                ltlContatoreAccessi.Text = Application["ContatoreAccessi"].ToString();

                HttpCookie cookieUtente = Request.Cookies["UltimoAccesso"];
                ltlCookie.Text = (cookieUtente != null) ? Server.HtmlEncode(cookieUtente.Value) : "(nessun cookie trovato)";
            }
        }
        protected void btnLogout_Click(object sender, EventArgs e)
        {
            Response.Redirect("Logout.aspx");
        }
    }
}