using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _08_Bowling
{
    public partial class FrmMain : Form
    {
        /* COORDINATE GRAFICA PALLA DA BOWLING */
        const int PALLA_INIZIO_X = 400;
        const int PALLA_FILE_X = 20;
        /* TIRI A DISPOSIZIONE DI CIASCUN GIOCATORE */
        const int TIRI = 2; 
        /* GESTIONE SEZIONE CRITICA */
        object lock_campo = new object();

        volatile Random rnd;
        volatile int totaleGiocatori; // Giocatori a disp. nel file.txt
        volatile int nGioc; // Giocatori effettivi 
        volatile Dictionary<string, int> giocatori = new Dictionary<string, int>();
        volatile int[] puntiGiocatori;

        /* THREAD UTILIZZATI */
        Thread gestore; // Gestisce il torneo al posto del Main_Thread
        Thread[] thCampo;
        Thread[] thArb;

        public FrmMain()
        {
            InitializeComponent();
        }

        private void FrmMain_Load(object sender, EventArgs e)
        {
            StreamReader sr = new StreamReader("giocatori.txt");
            totaleGiocatori = 0;

            while (!sr.EndOfStream)
            {
                giocatori.Add(sr.ReadLine(), 0);
                totaleGiocatori++;
            }
            sr.Close();
            nUDpartecipanti.Maximum = totaleGiocatori; 
            puntiGiocatori = new int[totaleGiocatori];
        }

        private void btnAvvia_Click(object sender, EventArgs e)
        {
            setLabel(lblEsito, "");
            rnd = new Random();
            btnAvvia.Enabled = false;
            nGioc = Convert.ToInt32(nUDpartecipanti.Value);
           // gestisci_torneo();
            gestore = new Thread(gestisci_torneo);
            gestore.Start();
        }
        
        private void gestisci_torneo()
        {
            thArb = new Thread[4];
            thCampo = new Thread[4];
            int posGioc;

            while (nGioc > 0)
            {
                do
                {
                    posGioc = rnd.Next(0, totaleGiocatori);
                } while (giocatori.ElementAt(posGioc).Value == 1);
                giocatori[giocatori.ElementAt(posGioc).Key] = 1;
                nGioc--;
            }

            stampaPunteggio();

            for (int i = 0; i < thArb.Length; i++)
            {
                thArb[i] = new Thread(gestisciCorsia);
                thArb[i].Name = (i + 1).ToString();
                thArb[i].Start();
            }

            for (int i = 0; i < thArb.Length; i++)
            {
                thArb[i].Join();
                Console.WriteLine("FINE PER ARBITRO CAMPO " + thArb[i].Name);
            }
            stampaPunteggio();
            // RICERCA DEL VINCITORE 

            setLabel(lblEsito, "");

            int punteggioMassimo = puntiGiocatori.Max();
            for (int i = 0; i < puntiGiocatori.Length; i++)
            {
                if (puntiGiocatori[i] == punteggioMassimo)
                {
                    setLabel(lblEsito, lblEsito.Text + Environment.NewLine +  giocatori.ElementAt(i).Key);
                }
            }

            BeginInvoke((MethodInvoker)delegate
            {
                btnAvvia.Enabled = true;   
            });
        }

        private void gestisciCorsia()
        {
            int codGioc;
            Control[] par = new Control[3];
            Label[] lblGioc;
            PictureBox pic;

            Thread.Sleep(100);

            lock (lock_campo)
            {
                // Sezione critica
                /*
                 * Un thread per volta deve controllare 
                 * se sono rimasti giocatori, estrarlo dall'elenco
                 * e riportarlo nel suo campo
                 */

                if (giocatoriResidui() == 0)
                {
                    return;
                }

                do
                {
                    codGioc = rnd.Next(0, totaleGiocatori);
                } while (giocatori.ElementAt(codGioc).Value != 1);
                // Estratto il giocatore setto value a 2
                // => Non viene più estratto
                giocatori[giocatori.ElementAt(codGioc).Key] = 2;
                thCampo[Convert.ToInt32(Thread.CurrentThread.Name) - 1] = new Thread(partita);
            }
            lblGioc = new Label[2];
            lblGioc[0] = (Label) this.Controls["lblGioc" + Thread.CurrentThread.Name.ToString()];
            // lblGioc1, lblGioc2, lblGioc3
            lblGioc[1] = (Label) this.Controls["lblPunti" + Thread.CurrentThread.Name.ToString()];
            // picB1, picB2, picB3...
            pic = (PictureBox)this.Controls["picB" + Thread.CurrentThread.Name.ToString()];

            par[0] = lblGioc[0];
            par[1] = lblGioc[1];
            par[2] = pic;

            setLabel(lblGioc[0], giocatori.ElementAt(codGioc).Key);

            thCampo[Convert.ToInt32(Thread.CurrentThread.Name) - 1].Name = Thread.CurrentThread.Name;
            thCampo[Convert.ToInt32(Thread.CurrentThread.Name) - 1].Start(par);
            thCampo[Convert.ToInt32(Thread.CurrentThread.Name) - 1].Join();

            if (giocatoriResidui() > 0)
            {
                gestisciCorsia();
            }
        }

        private int giocatoriResidui()
        {
            int giocRes = 0;

            lock (lock_campo)
            {
                for (int i = 0; i < giocatori.Count(); i++)
                {
                    if (giocatori.ElementAt(i).Value == 1)
                    {
                        giocRes++;
                    }
                }
            }


            return giocRes;
        }

        private void partita(object param)
        {
            PictureBox pic = (PictureBox) (param as Control[])[2];
            Label lblNome = (Label) (param as Control[])[0];
            Label lblPunti = (Label)(param as Control[])[1];
            int campo = Convert.ToInt32(Thread.CurrentThread.Name);
            int punteggio;
            int codGioc = 0;

            /* Ricerca codGioc */
            while (giocatori.ElementAt(codGioc).Key != lblNome.Text)
                codGioc++;

            for (int i = 0; i < TIRI; i++)
            {
                do
                {
                    setPos(pic, pic.Location.X - rnd.Next(0, 20), pic.Location.Y);
                    Thread.Sleep(rnd.Next(10, 50));
                } while (pic.Location.X >= PALLA_FILE_X);
                setPos(pic, PALLA_INIZIO_X, pic.Location.Y);
                punteggio = rnd.Next(0, 10);
                puntiGiocatori[codGioc] += punteggio;
                setLabel(lblPunti, "Punti: " + puntiGiocatori[codGioc].ToString());
                Thread.Sleep(300);
            }
            Thread.Sleep(1000);
        }

        private void stampaPunteggio()
        {
            BeginInvoke((MethodInvoker)delegate () {
                txtPunteggio.Text = "";

                for(int i=0; i<giocatori.Count; i++)
                {
                    if (giocatori.ElementAt(i).Value != 0)
                    {
                        txtPunteggio.Text += $"[{giocatori.ElementAt(i).Value}] {giocatori.ElementAt(i).Key} " +
                                                $"{puntiGiocatori[i].ToString() } punti" +
                                            $"{Environment.NewLine}";
                    }
                }
            });
        }
        private void setLabel(Label lbl, string msg)
        {
            BeginInvoke((MethodInvoker)delegate ()
            {
                lbl.Text = msg;
            });
        }
        private void setPos(PictureBox pic, int x, int y)
        {
            BeginInvoke((MethodInvoker)delegate ()
            {
                pic.Location = new Point(x, y);
            });
        }
    }
}
