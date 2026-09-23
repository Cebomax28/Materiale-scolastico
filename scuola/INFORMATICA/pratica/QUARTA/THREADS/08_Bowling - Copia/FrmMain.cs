using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
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
            gestore = new Thread(gestisci_torneo);
            gestore.Start();
        }
        
        private void gestisci_torneo()
        {
            thCampo = new Thread[4];
            thArb = new Thread[4];

            while (nGioc > 0)
            {
                int codGioc = 0;
                do
                {
                    codGioc = rnd.Next(0, totaleGiocatori);
                } while (giocatori.ElementAt(codGioc).Value != 0);
                giocatori[giocatori.ElementAt(codGioc).Key] = 1;
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
            }
            stampaPunteggio();

            int punteggioMassimo = puntiGiocatori.Max();

            for (int i = 0; i < giocatori.Count(); i++)
            {
                if (giocatori.ElementAt(i).Value == punteggioMassimo)
                {
                    setLabel(lblEsito, lblEsito.Text + Environment.NewLine +  giocatori.ElementAt(i).Key);
                }
            }
        }

        private void gestisciCorsia()
        {
            int codGioc;
            Label[] lblGioc;
            Control[] control = new Control[3];
            PictureBox pic;

            lock (lock_campo)
            {
                if (giocatoriResidui() <= 0)
                {
                    return;
                }

                do
                {
                    codGioc = rnd.Next(0, totaleGiocatori);
                } while (giocatori.ElementAt(codGioc).Value != 1);
                giocatori[giocatori.ElementAt(codGioc).Key] = 2;
            }

            lblGioc = new Label[2];
            lblGioc[0] = (Label)this.Controls["lblGioc" + Thread.CurrentThread.Name];
            lblGioc[1] = (Label)this.Controls["lblPunti" + Thread.CurrentThread.Name];
            pic = (PictureBox)this.Controls["picB" + Thread.CurrentThread.Name];
            control[0] = lblGioc[0];
            control[1] = lblGioc[1];
            control[2] = pic;

            setLabel(lblGioc[0], giocatori.ElementAt(codGioc).Key);
            thCampo[Convert.ToInt32(Thread.CurrentThread.Name) - 1] = new Thread(partita);
            thCampo[Convert.ToInt32(Thread.CurrentThread.Name) - 1].Name = Thread.CurrentThread.Name;
            thCampo[Convert.ToInt32(Thread.CurrentThread.Name) - 1].Start(control);
            thCampo[Convert.ToInt32(Thread.CurrentThread.Name) - 1].Join();

            if (giocatoriResidui() > 0)
            {
                gestisciCorsia();
            }
        }

        private int giocatoriResidui()
        {
            int gioc = 0;
            for (int i = 0; i < giocatori.Count(); i++)
            {
                if (giocatori.ElementAt(i).Value == 1)
                {
                    gioc++;
                }
            }
            return gioc;
        }

        private void partita(object param)
        {
            Label lblGioc = (Label)(param as Control[])[0];
            Label lblPunti = (Label)(param as Control[])[1];
            PictureBox pic = (PictureBox)(param as Control[])[2];

            int codGioc = 0;
            while (giocatori.ElementAt(codGioc).Key != lblGioc.Text)
                codGioc++;

            for (int i = 0; i < TIRI; i++)
            {
                int posX = PALLA_INIZIO_X;
                do
                {
                    posX -= rnd.Next(5, 10);
                    setPos(pic, posX, pic.Location.Y);
                    Thread.Sleep(10);
                } while (posX > PALLA_FILE_X);
                int punteggio = rnd.Next(0, 10);
                puntiGiocatori[codGioc] += punteggio;
                setLabel(lblPunti, $"{puntiGiocatori[codGioc]} PUNTI");
                Thread.Sleep(100);
            }
            Thread.Sleep(500);
           
        }

        private void stampaPunteggio()
        {
            BeginInvoke((MethodInvoker) delegate
            {
                txtPunteggio.Text = "";

                for (int i = 0; i < giocatori.Count(); i++)
                {
                    if (giocatori.ElementAt(i).Value != 0)
                    {
                        txtPunteggio.Text += $"[{giocatori.ElementAt(i).Value}] {giocatori.ElementAt(i).Key} " +
                                                                        $"{puntiGiocatori[i].ToString()} punti" +
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
