using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net.Configuration;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Gara_di_nuoto
{
    public partial class frmMain : Form
    {
        public volatile object lock_campo = new object();
        volatile int atletiLetti;
        volatile Random rnd = new Random();

        /* GRAFICA */
        const int BATTERIE = 4;
        const int INIZIO_Y = 20;
        const int INIZIO_CORSIA_Y = 53;
        const int FINE_CORSIA_Y = 648;
        // ACCESSO NON CONTROLLATO AD ELENCO ATLETI
        volatile Dictionary<string, int> atleti = new Dictionary<string, int>();

        Thread arbitro; // Gestione interno torneo
        Thread[] atlBatterie; // Gestione singola batteria

        volatile int primoArrivato; // CRITICA
        int a = 0;
        int turno = 0;
        
        public frmMain()
        {
            InitializeComponent();
            
        }

        private void frmMain_Load(object sender, EventArgs e)
        {
            StreamReader sr = new StreamReader("atleti.txt");
            string line;
            lblAtleti.Text = "";

            while (!sr.EndOfStream)
            {
                line = sr.ReadLine();
                atleti.Add(line, 1);
            }
            sr.Close();
            atletiLetti = atleti.Count;
            StampaAtletiPartecipanti();

            pictureBox1.SendToBack();
        }

        private void StampaAtletiPartecipanti()
        {
            BeginInvoke((MethodInvoker)delegate ()
            {
                lblAtleti.Text = "";

                for (int i = 0; i < atleti.Count; i++)
                {
                    if (atleti.ElementAt(i).Value == 1)
                    {
                        lblAtleti.Text += atleti.ElementAt(i).Key.ToString() + Environment.NewLine;
                    }
                }
            });
        }

        private void btnAvvia_Click(object sender, EventArgs e)
        {
            rnd = new Random();
            lblEsito.Text = "";
            lblEliminati.Text = "";

            arbitro = new Thread(avviaTorneo);
            arbitro.Start();
        }

        private void avviaTorneo()
        {
            int atletiResidui = atleti.Count;

            while (atletiResidui > 0)
            {
                primoArrivato = 0;
                // Stampa turno attuale
                setValore(lblTurno, "TURNO: " + (++turno).ToString());
                eseguiEliminatiore(0);
                atletiResidui -= 4;
            }
            // FASE FINALE
            // TO DO...

            primoArrivato = 0;
            setValore(lblTurno, "FINALE");
            eseguiEliminatiore(1);

        }

        /* a distingue la fase finale dalle eliminatorie */
        private void eseguiEliminatiore(int a)
        {
            /* PER OGNI ELIMINATORIA 4 BATTERIE DI ATLETI POSSONO PARTECIPARE*/
            atlBatterie = new Thread[BATTERIE];
            TextBox txtCorsia;
            int posAtl;
            for (int i = 0; i < BATTERIE; i++)
            {

                txtCorsia = new TextBox();
                txtCorsia = (TextBox)Controls["txtA" + (i + 1).ToString()];

                // Prelevare un atleta da quelli residui (cod. key = 1)
                posAtl = rnd.Next(0, atletiLetti);
                if (a == 0)
                { // ELIMINATORIE
                    while (atleti.ElementAt(posAtl).Value != 1)
                    {
                        posAtl = rnd.Next(0, atletiLetti);
                    }

                    atleti[atleti.ElementAt(posAtl).Key] = 0;
                    atlBatterie[i] = new Thread(gara);
                    atlBatterie[i].Start(txtCorsia);

                }
                else
                { // FINALE
                    while (atleti.ElementAt(posAtl).Value != 2)
                    {
                        posAtl = rnd.Next(0, atletiLetti);
                    }
                    atleti[atleti.ElementAt(posAtl).Key] = 3;
                    atlBatterie[i] = new Thread(gara);
                    atlBatterie[i].Start(txtCorsia);
                }

                BeginInvoke((MethodInvoker)delegate ()
                {
                    txtCorsia.BringToFront();
                    txtCorsia.Text = atleti.ElementAt(posAtl).Key;
                });
                Thread.Sleep(100);

            }
            setValore(lblStatus, "PRONTI...");
            StampaAtletiPartecipanti();

            for (int i = 0; i < BATTERIE; i++)
            {
                atlBatterie[i].Join();
            }
        }

        private void gara(object parametro)
        {
            TextBox txtCorsia = (parametro as TextBox);

            setPos(txtCorsia, txtCorsia.Location.X, INIZIO_CORSIA_Y);
            Thread.Sleep(2000);
            setValore(lblStatus, "VIA!");

            do
            {
                Thread.Sleep(300);
                setPos(txtCorsia, txtCorsia.Location.X, txtCorsia.Location.Y + rnd.Next(0, 150));
            } while (txtCorsia.Location.Y < FINE_CORSIA_Y - 200);


            //do
            //{
            //    Thread.Sleep(300);
            //    setPos(txtCorsia, txtCorsia.Location.X, txtCorsia.Location.Y - rnd.Next(0, 50));
            //} while (txtCorsia.Location.Y  >= INIZIO_CORSIA_Y + 50);

            // ESCO DAL CICLO QUANDO L'ATLETA é ARRIVATO ALLA FINE 
            // DEVO TROVARE VINCITORE


            lock (lock_campo)
            {
                if (primoArrivato == 0)
                {
                    atleti[txtCorsia.Text] = 2;
                    setValore(lblEsito, lblEsito.Text + txtCorsia.Text + Environment.NewLine);
                    primoArrivato = 1;
                }
                else
                {
                    setValore(lblEliminati, lblEliminati.Text + txtCorsia.Text + Environment.NewLine);
                }
            }
        }

        private void setPos(TextBox txt, int x, int y)
        {
            BeginInvoke((MethodInvoker)delegate ()
            {
                txt.Location = new Point(x, y);
            });
        }

        private void setValore(Label lblTurno, string msg)
        {
            BeginInvoke((MethodInvoker)delegate ()
            {
                lblTurno.Text = msg;
            });
        }
    }
}
