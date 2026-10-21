using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace _04_MasterPage
{
    public partial class Studenti : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
                caricaStudenti();
        }

        private void caricaStudenti()
        {
            ClsSQLServer ado = new ClsSQLServer("(LocalDB)\\MSSQLLocalDB", Server.MapPath("./App_Data/ScuolaDB.mdf"));
            string sql = "SELECT * FROM Studenti;";
            DataTable dtStudenti = ado.ExecuteQuery(sql);

            if (dtStudenti.Rows.Count > 0)
            {
                gvStudenti.DataSource = dtStudenti;
                gvStudenti.DataBind();
            }
            else
            {

            }
        }
    }
}                                                                                                                                                          