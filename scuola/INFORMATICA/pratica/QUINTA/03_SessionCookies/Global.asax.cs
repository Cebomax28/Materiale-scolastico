using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Security;
using System.Web.SessionState;
using System.Web.UI;

namespace _03_SessionCookies
{
    public class Global : System.Web.HttpApplication
    {

        protected void Application_Start(object sender, EventArgs e)
        {
            ScriptManager.ScriptResourceMapping.AddDefinition("jquery",
                    new ScriptResourceDefinition
                    {
                        Path = "~/Scripts/jquery-3.7.1.min.js",
                        DebugPath = "~/Scripts/jquery-3.7.1.min.js",
                        CdnPath = "https://code.jquery.com/jquery-3.7.1.min.js",
                        CdnDebugPath = "https://code.jquery.com/jquery-3.7.1.min.js",
                        CdnSupportsSecureConnection = true,
                        LoadSuccessExpression = "window.jQuery"
                    });
            Application["ContatoreAccessi"] = 0;
        }

        protected void Session_Start(object sender, EventArgs e)
        {
            Application.Lock();
            Application["ContatoreAccessi"] = (int)Application["ContatoreAccessi"] + 1;
            Application.UnLock();

            Session["OraInizioSessione"] = DateTime.Now;
        }

        protected void Application_BeginRequest(object sender, EventArgs e)
        {
        }

        protected void Application_AuthenticateRequest(object sender, EventArgs e)
        {
        }

        protected void Application_Error(object sender, EventArgs e)
        {
            Exception ex = Server.GetLastError();
            if (ex != null)
                Session["UltimoErrore"] = ex.Message;
        }

        protected void Session_End(object sender, EventArgs e)
        {
        }

        protected void Application_End(object sender, EventArgs e)
        {

        }
    }
}