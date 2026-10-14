using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace _03_SessionCookies
{
    public partial class Logout : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            // Elimino SESSIONI
            Session.Clear();
            Session.Abandon();

            // Elimino COOKIES
            HttpCookie cookieUtente = new HttpCookie("UltimoAccesso")
            {
                Expires = DateTime.Now.AddDays(-1)
            };
            Response.Cookies.Add(cookieUtente);
        }
    }
}