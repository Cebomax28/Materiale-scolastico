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
using System.Windows.Forms.Design;

namespace Gara_di_nuoto
{
    public partial class frmMain : Form
    {
        public volatile object lock_campo = new object();
        volatile int atletiLetti;
        volatile Random rnd = new Random();

        const int BATTERIE = 4;
        const int INIZIO_Y = 20;
        const int INIZIO_CORSIA_Y = 53;
        const int FINE_CORSIA_Y = 648;

        volatile Dictionary<string, int> atleti = new Dictionary<string, int>();

        Thread arbitro;
        Thread[] atlBatterie;

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
            while (!sr.EndOfStream)
            {
                atleti.Add(sr.ReadLine(), 1);
                atletiLetti++;
            }
            sr.Close();

            StampaAtletiPartecipanti();
            setLbl(lblEliminati, "");
            setLbl(lblEsito, "");
            setLbl(lblStatus, "");
            setLbl(lblTurno, "");
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
            atlBatterie = new Thread[BATTERIE];
            arbitro = new Thread(avviaTorneo);
            arbitro.Start();
        }

        private void avviaTorneo()
        {
            StampaAtletiPartecipanti();

            while (atletiLetti > 0)
            {
                eseguiEliminatiore(0);
                atletiLetti -= 4;
                StampaAtletiPartecipanti();
            }
            StampaAtletiPartecipanti();

            eseguiEliminatiore(1);
        }

        private void eseguiEliminatiore(int a)
        {
            if (a == 1)
            {
                setLbl(lblTurno, "FINALE ");
            }
            else
            {
                setLbl(lblTurno, "TURNO " + (++turno).ToString());
            }
            setLbl(lblStatus, "PRONTI..");
            Thread.Sleep(rnd.Next(1000, 2000));
            setLbl(lblStatus, "VIA");


            primoArrivato = 0;
            for (int i = 0; i < BATTERIE; i++)
            {
                int codGioc = 0;
                TextBox txt;
                if (a == 0)
                {
                    do
                    {
                        codGioc = rnd.Next(0, atleti.Count());
                    } while (atleti[atleti.ElementAt(codGioc).Key] != 1);
                    atleti[atleti.ElementAt(codGioc).Key] = 0;
                }
                else
                {
                    do
                    {
                        codGioc = rnd.Next(0, atleti.Count());
                    } while (atleti[atleti.ElementAt(codGioc).Key] != 2);
                    atleti[atleti.ElementAt(codGioc).Key] = 3;
                }
                

                txt = (this.Controls["txtA" + (i + 1).ToString()] as TextBox);
                BeginInvoke((MethodInvoker) delegate
                {
                    txt.Text = atleti.ElementAt(codGioc).Key;
                    txt.BringToFront();
                });

                atlBatterie[i] = new Thread(gara);
                atlBatterie[i].Name = codGioc.ToString();

                atlBatterie[i].Start(txt);

            }

            for (int i = 0; i < BATTERIE; i++)
            {
                atlBatterie[i].Join();
            }
        }

        private void gara(object parametro)
        {

            TextBox txt = parametro as TextBox;
            setPos(txt, txt.Location.X, INIZIO_CORSIA_Y);
            int posY = INIZIO_CORSIA_Y;


            do
            {
                posY += rnd.Next(2, 10);
                Thread.Sleep(25);
                setPos(txt, txt.Location.X, posY);
            } while (posY < FINE_CORSIA_Y);


            do
            {
                posY -= rnd.Next(2, 10);
                Thread.Sleep(25);
                setPos(txt, txt.Location.X, posY);
            } while (posY > INIZIO_CORSIA_Y);

            lock (lock_campo)
            {
                if (primoArrivato == 0)
                {
                    primoArrivato = 1;
                    setValore(lblEsito, atleti.ElementAt(Convert.ToInt32(Thread.CurrentThread.Name)).Key);
                    atleti[atleti.ElementAt(Convert.ToInt32(Thread.CurrentThread.Name)).Key] = 2;
                }
                else
                {
                    setValore(lblEliminati, atleti.ElementAt(Convert.ToInt32(Thread.CurrentThread.Name)).Key);
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

        private void setValore(Label lbl, string msg)
        {
            BeginInvoke((MethodInvoker)delegate ()
            {
                lbl.Text += msg + Environment.NewLine;
            });
        }

        private void setLbl(Label lbl, string msg)
        {
            BeginInvoke((MethodInvoker)delegate ()
            {
                lbl.Text = msg;
            });
        }
    }
}