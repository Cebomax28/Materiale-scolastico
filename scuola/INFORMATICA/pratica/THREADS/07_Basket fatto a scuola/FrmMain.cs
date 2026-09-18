using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _07_Basket
{

    public partial class FrmMain : Form
    {
        volatile object lock_campo = new object();
        volatile Random rnd;

        Thread arbitro;
        Thread[] gioc;

        // Tiri disponibili
        const int TOTALE_TIRI = 10;
        const int PALLONE_X = 330;
        const int PALLONE_Y = 59;
        const int PALLONE_CENTRO_X = 369;
        const int PALLONE_CENTRO_Y = 247;
        const int PALLONE_CANESTRO_Y = 247;
        const int PALLONE_CANESTRO_X = 412;

        int cont1 = 0;
        int cont2 = 0;

        Dictionary<string, int> giocatori = new Dictionary<string, int>();

        public FrmMain()
        {
            InitializeComponent();
        }
        private void btnAvvia_Click(object sender, EventArgs e)
        {
            rnd = new Random();
            giocatori.Add(txtG1.Text, 1);
            giocatori.Add(txtG2.Text, 2);

            setPic(picBall, PALLONE_CANESTRO_X, PALLONE_CANESTRO_Y);

            arbitro = new Thread(arbitroThread);
            arbitro.Start();
        }

        private void arbitroThread()
        {
            int tiri = 0;

            setLabel(lblStatus, $"{txtG1.Text} (0 - 0) {txtG2.Text}");
            
            while (tiri < TOTALE_TIRI)
            {
                tiri++;
                setLabel(lblTiro, tiri.ToString() + " TIRO");
                eseguiTiro();
            }

            if (giocatori.ElementAt(0).Value < giocatori.ElementAt(1).Value)
            {
                setLabel(lblGara, "HA VINTO " + txtG1.Text);
            }
            else if (giocatori.ElementAt(0).Value > giocatori.ElementAt(1).Value)
            {
                setLabel(lblGara, "HA VINTO " + txtG2.Text);
            }
            else
            {
                setLabel(lblGara, "PAREGGIO");
            }
        }

        private void eseguiTiro()
        {
            gioc = new Thread[2];

            for (int i = 0; i < gioc.Length; i++)
            {
                gioc[i] = new Thread(giocaTurno);
                gioc[i].Name = giocatori.ElementAt(i).Key;
                setLabel(lblControllo, "TIRO IN CORSO...");
                gioc[i].Start();
                gioc[i].Join();
            }
        }

        private void giocaTurno()
        {
            lock (lock_campo)
            {
                string nome = "";
                if (Thread.CurrentThread.Name == txtG1.Text)
                {
                    nome = txtG1.Text;
                }
                else
                {
                    nome = txtG2.Text;
                }
                setLabel(lblGara, "TOCCA A " + nome);
                bool uscita = rnd.Next(1, 3) == 1 ? true : false;
                int posY = PALLONE_Y;

                while (posY < PALLONE_CENTRO_Y)
                {
                    posY += 30;
                    setPic(picBall, PALLONE_CANESTRO_X, posY);
                    Thread.Sleep(200);
                }
                if (uscita)
                {
                    setLabel(lblControllo, "FUORI");
                    Thread.Sleep(500);
                }
                else
                {
                    setLabel(lblControllo, "CANESTRO");
                    if (Thread.CurrentThread.Name == txtG1.Text)
                    {
                        cont1++;
                        setLabel(lblStatus, $"{txtG1.Text} ({cont1.ToString()} - {cont2.ToString()}) {txtG2.Text}");
                    }
                    else
                    {
                        cont2++;
                        setLabel(lblStatus, $"{txtG1.Text} ({cont1.ToString()} - {cont2.ToString()}) {txtG2.Text}");
                    }
                    Thread.Sleep(500);

                }
            }
        }

        private void setLabel(Label lbl, string msg)
        {
            BeginInvoke((MethodInvoker)delegate
            {
                lbl.Text = msg;
            });
        }

        private void setPic(PictureBox pic, int x, int y)
        {
            BeginInvoke((MethodInvoker)delegate
            {
                pic.Location = new Point(x, y);
            });
        }
    }
}
