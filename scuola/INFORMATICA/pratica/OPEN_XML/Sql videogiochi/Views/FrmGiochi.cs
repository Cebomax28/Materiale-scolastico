using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _14_VideogiochiSQLServer.Views
{
    public partial class FrmGiochi : Form
    {
        private GiocoController gContr = new GiocoController();
        string[] categorie = {
    "Action RPG",
    "Adventure",
    "Battle Royale",
    "Co-op",
    "FPS",
    "Horror",
    "MOBA",
    "Party Game",
    "Platformer",
    "Puzzle",
    "Racing",
    "RPG",
    "Sandbox",
    "Shooter",
    "Simulation",
    "Sport",
    "Stealth",
    "Strategy"
};

        public FrmGiochi()
        {
            InitializeComponent();
        }

        private void btnResetFiltro_Click(object sender, EventArgs e)
        {
            CaricaGiochi();
        }

        private void CaricaGiochi()
        {
            if (txtGiocoNome.Text == "" && cmbCategoria.Text == "")
                dgvGiochi.DataSource = gContr.GetAll();
            else
            {
                if (txtGiocoNome.Text != "" && cmbCategoria.Text == "")
                {
                    dgvGiochi.DataSource = gContr.GetByTitolo(txtGiocoNome.Text);
                    txtGiocoNome.Text = "";
                }
                else
                {
                    dgvGiochi.DataSource = gContr.GetByCategoria(cmbCategoria.Text);
                    cmbCategoria.Text = "";
                }
            }
        }

        private void FrmGiochi_Load(object sender, EventArgs e)
        {
            CaricaGiochi();
            foreach (var item in categorie)
            {
                cmbCategoria.Items.Add(item);
            }
        }

        private void btnCercaGiochi_Click(object sender, EventArgs e)
        {
            CaricaGiochi();
        }

        private void btnAddGioco_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Confermare l'inserimento di un nuovo giocatore?", "Conferma",
                                MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                Gioco g = new Gioco
                {
                    Titolo = txtNewTitolo.Text.Trim(),
                    Categoria = txtNewCategoria.Text.Trim(),
                    CasaProduttrice = txtNewCasa.Text.Trim(),
                    AnnoUscita = Convert.ToInt32(numAnno.Text)
                };
                if (gContr.Insert(g))
                {
                    CaricaGiochi();
                    MessageBox.Show("Gioco inserito con successo");
                }
            }
        }

    }
}
