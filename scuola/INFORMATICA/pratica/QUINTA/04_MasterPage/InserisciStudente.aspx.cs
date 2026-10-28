using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace _04_MasterPage
{
    public partial class InserisciStudente : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if(!IsPostBack)
            {
                txtDataNascita.Attributes["min"] = DateTime.Now.AddYears(-20).ToString("yyyy-MM-dd");
                txtDataNascita.Attributes["max"] = DateTime.Now.AddYears(-10).ToString("yyyy-MM-dd");
                popolaDropDownClasse();
            }
        }

        private void popolaDropDownClasse()
        {
            ddlClasse.Items.Clear();

            for(int i = 1; i <= 5; i++)
            {
                for (char sezione = 'A'; sezione <= 'E'; sezione++)
                    ddlClasse.Items.Add($"{i}^{sezione}");
            }
        }
        protected void btnInserisci_Click(object sender, EventArgs e)
        {
            ClsSQLServer ado = new ClsSQLServer("(LocalDB)\\MSSQLLocalDB",
                    Server.MapPath("./App_Data/ScuolaDB.mdf"));
            string query =
                "INSERT INTO Studenti (Nome, Cognome, Matricola, DataNascita, Classe) " +
                "VALUES (@Nome, @Cogn, @Matr, @DataNascita, @Classe);";
            Dictionary<string, object> param = new Dictionary<string, object>
            {
                { "@Nome", txtNome.Text },
                { "@Cogn", txtCognome.Text },
                { "@Matr", txtMatricola.Text },
                { "@DataNascita", txtDataNascita.Text },
                { "@Classe", ddlClasse.SelectedValue }
            };
            int res = ado.ExecuteNonQuery(query, param);
            lblMessage.Text = res > 0 ? lblMessage.Text = "Studente inserito con successo" : lblMessage.Text = "Erorre inserimento: " + ado.ErrorMessage;
        }
    }
}