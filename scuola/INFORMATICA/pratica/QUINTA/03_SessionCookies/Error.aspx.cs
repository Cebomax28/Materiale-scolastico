using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace _03_SessionCookies
{
    public partial class Error : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["UltimoErrore"] != null)
            {
                ltlErrore.Text = Server.HtmlEncode(Session["UltimoErrore"].ToString());
                Session.Remove("UltimoErrore");
            }
            else
                ltlErrore.Text = "Errore non specificato";
        }
    }
}