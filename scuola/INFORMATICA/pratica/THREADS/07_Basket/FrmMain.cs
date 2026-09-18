using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _07_Basket
{
    public partial class FrmMain : Form
    {
        volatile Random rnd = new Random();
        volatile object lock_campo = new object();

        Thread[] threadGiocatori;
        Thread arbitro;

        const int GIOCATORI = 2;
        const int TIRITOTALI = 10;
        const int POS_Y_FINALE = 400;

        int tiri = 1;

        int cont1 = 0, cont2 = 0;


        Dictionary<string, int> giocatori = new Dictionary<string, int>();
        public FrmMain()
        {
            InitializeComponent();
        }
        private void btnAvvia_Click(object sender, EventArgs e)
        {
            giocatori.Clear();
            giocatori.Add(txtG1.Text, 1);
            giocatori.Add(txtG2.Text, 2);
            tiri = 1;
            cont1 = 0;
            cont2 = 0;


            threadGiocatori = new Thread[GIOCATORI];
            arbitro = new Thread(avviaPartita);
            arbitro.Start();


        }

        private void avviaPartita()
        {
            BeginInvoke((MethodInvoker)delegate
            {
                lblStatus.Text = txtG1.Text + "(" + cont1.ToString() + " - " + cont2.ToString() + ")" + txtG2.Text;
                lblTiro.Text = tiri.ToString() + " TIRO";

            });

            int i = TIRITOTALI;
            
            while (i > 0)
            {
                i--;
                turnoGiocatore();
            }

            BeginInvoke((MethodInvoker) delegate
            {
                if (cont1 > cont2)
                {
                    lblGara.Text = "HA VINTO " + txtG1.Text;
                }
                else if (cont2 > cont1)
                {
                    lblGara.Text = "HA VINTO " + txtG2.Text;
                }
                else
                {
                    lblGara.Text = "PAREGGIO";
                }
            });
        }

        private void turnoGiocatore()
        {
            for (int i = 0; i < GIOCATORI; i++)
            {
                BeginInvoke((MethodInvoker)delegate
                {
                    lblControllo.Text = "TIRO IN CORSO...";
                    picBall.Location = new Point(picBall.Location.X, 50);
                    lblTiro.Text = tiri.ToString() + " TIRO";

                });
                Thread.Sleep(500);
                threadGiocatori[i] = new Thread(LancioPalla);
                threadGiocatori[i].Name = giocatori.ElementAt(i).Key;

                threadGiocatori[i].Start();
                threadGiocatori[i].Join();
            }
            tiri++;
        }

        private void LancioPalla()
        {
            bool uscita = (rnd.Next(1, 3) == 1) ? true : false;
            int posY = 50;

            string nome = Thread.CurrentThread.Name;
            BeginInvoke((MethodInvoker) delegate
            {
                lblGara.Text = "Tocca a " + nome;
            });

            while (posY < POS_Y_FINALE)
            {
                posY += 25;
                BeginInvoke((MethodInvoker) delegate
                {
                    picBall.Location = new Point(picBall.Location.X, posY);
                });
                
                Thread.Sleep(100);
            }


            lock (lock_campo)
            {
                BeginInvoke((MethodInvoker) delegate
                {
                    picBall.Location = new Point(picBall.Location.X, posY);
                    if (uscita)
                    {
                        lblControllo.Text = "FUORI";
                    }
                    else
                    {
                        lblControllo.Text = "CANESTRO";
                        if (nome == txtG1.Text)
                        {
                            cont1++;
                        }
                        else
                        {
                            cont2++;
                        }
                    }
                    lblStatus.Text = txtG1.Text + "(" + cont1.ToString() + " - " + cont2.ToString() + ")" + txtG2.Text;
                });

                Thread.Sleep(500);

            }
        }
    }
}
