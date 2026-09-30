using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Security;
using System.Web.SessionState;
using System.Web.UI;

namespace _02_FormValidation
{
    public class Global : System.Web.HttpApplication
    {
        // ESEGUITO UNA SOLA VOLTA all'avvio dell'applicazione server
        // Utilizzaato per l'inizializzazione di variabili, gestione routing, cache
        protected void Application_Start(object sender, EventArgs e)
        {
            Application["SessioniTotali"] = 0;
            
            ScriptManager.ScriptResourceMapping.AddDefinition("jquery",
                new ScriptResourceDefinition
                {
                    Path = "⁓/Scripts/jquery-3.7.1.min.js",
                    DebugPath = "⁓/Scripts/jquery-3.7.1.min.js",
                    CdnPath = "https://code.jquery.com/jquery-3.7.1.min.js",
                    CdnDebugPath = "https://code.jquery.com/jquery-3.7.1.min.js",
                    CdnSupportsSecureConnection = true,
                    LoadSuccessExpression = "window.jQuery"
                });
            
        }
        // Eseguito ad ogni NUOVA SESSIONE utente
        protected void Session_Start(object sender, EventArgs e)
        {
            Application.Lock();
            Application["SessioniTotali"] = (int)Application["SessioniTotali"] + 1;
            Application.UnLock();
        }

        protected void Application_BeginRequest(object sender, EventArgs e)
        {

        }

        protected void Application_AuthenticateRequest(object sender, EventArgs e)
        {

        }

        protected void Application_Error(object sender, EventArgs e)
        {

        }

        protected void Session_End(object sender, EventArgs e)
        {

        }

        protected void Application_End(object sender, EventArgs e)
        {
            Application.Lock();
            Application["SessioniTotali"] = (int)Application["SessioniTotali"] + 1;
            Application.UnLock();
        }
    }
}