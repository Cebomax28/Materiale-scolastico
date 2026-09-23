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
    public partial class FrmGiocatori : Form
    {
        private GiocatoriController _gContr = new GiocatoriController();
        private int _idSelezionato = 0;
        public FrmGiocatori()
        {
            InitializeComponent();

            dtpAddDataN.MaxDate = DateTime.Now.AddYears(-14);
            dtpAddDataN.MinDate = new DateTime(1950, 1, 1);

            // Carico tutti i giocatori e vis. in Dgv
            CaricaGiocatori();
        }
        private void btnCercaNick_Click(object sender, EventArgs e)
        {
            CaricaGiocatori();
        }
        private void CaricaGiocatori()
        {
            string nickname = txtCercaNick.Text.Trim();

            dgvGiocatori.DataSource = (nickname.Length > 0) 
                        ? _gContr.GetByNickname(nickname) 
                        : _gContr.GetAll();

            dgvGiocatori.AutoSizeColumnsMode =
                        DataGridViewAutoSizeColumnsMode.AllCells;
        }

        private void btnAddGiocatore_Click(object sender, EventArgs e)
        {
            // TO DO.. 1. Validazione: tutti i campi obbligatori devono essere compilati
            
            if(MessageBox.Show("Confermare l'inserimento di un nuovo giocatore?", "Conferma",
                                MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                Giocatore g = new Giocatore
                {
                    Nome = txtAddNome.Text.Trim(),
                    Cognome = txtAddCogn.Text.Trim(),
                    Nickname = txtAddNickname.Text.Trim(),
                    Email = txtAddEmail.Text.Trim(),
                    DataNascita = dtpAddDataN.Value.Date
                };

                if (_gContr.Insert(g))
                {
                    txtAddNome.Text = txtAddCogn.Text = txtAddNickname.Text = txtAddEmail.Text = "";
                    CaricaGiocatori();
                    MessageBox.Show("Giocatore inserito con successo");
                }
                else
                {
                    MessageBox.Show("Errore durante l'inserimento: " + _gContr.Errore);
                }
            }

        }

        private void dgvGiocatori_SelectionChanged(object sender,
                            EventArgs e)
        {
            if (dgvGiocatori.SelectedRows.Count == 0)
                return;

            DataGridViewRow row = dgvGiocatori.SelectedRows[0];

            _idSelezionato = Convert.ToInt32(row.Cells["IdGiocatore"].Value);

            txtUpdNickname.Text = row.Cells["Nickname"].Value.ToString();
            txtUpdEmail.Text = row.Cells["Email"].Value.ToString();

        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (_idSelezionato != 0)
            {
                if (!(string.IsNullOrWhiteSpace(txtUpdNickname.Text) && (string.IsNullOrWhiteSpace(txtUpdEmail.Text))))
                {
                    Giocatore g = new Giocatore()
                    {
                        IdGiocatore = _idSelezionato,
                        Nickname = txtUpdNickname.Text,
                        Email = txtUpdEmail.Text
                    };
                    if (_gContr.Update(g))
                    {
                        CaricaGiocatori();
                        MessageBox.Show("Giocatore aggiornato con successo");
                    }
                    else
                        MessageBox.Show("Errore durante l'aggiornamento: " + _gContr.Errore);                    
                }
                else
                {
                    MessageBox.Show("Nickname e email sono obbligatori");
                }
            }
            else
            {
                MessageBox.Show("Selezioanre prima un giocatore");
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (_idSelezionato != 0)
            {
                if (MessageBox.Show("vuoi eliminare definitivamente il giocatore selezionato?", "Conferma", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    if (_gContr.Delete(_idSelezionato))
                    {
                        _idSelezionato = 0;
                        txtUpdEmail.Text = txtUpdNickname.Text = "";
                        CaricaGiocatori();
                        MessageBox.Show("Giocatore eliminato con successo");
                    }
                }
            }
            else
                MessageBox.Show("Seleziona prima un giocatore");
        }
    }
}
