using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net.Configuration;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _09_TorneoCalcio
{
    public partial class FrmMain : Form
    {
        public volatile object lock_campo = new object();

        volatile Random rnd;
        volatile int squadreLette; // Totale delle squadre partecipanti

        // Ad ogni girone associo una lettera ed il numero di partite da effettuare
        Dictionary<int, string> associazioni = new Dictionary<int, string>();
        // Thread principale (dopo il Main_thread) => Gestisce l'intero torneo
        Thread t_arbitro;
        // Vettore di thread, ogni partita verrà avviata da un specifico thread
        Thread[] t_partite; 
        public FrmMain()
        {
            InitializeComponent();
            associazioni.Add(0, "V"); // Vincitore => 0 partite
            associazioni.Add(1, "F"); // Finale => 1 partita - 2 squadre
            associazioni.Add(2, "S"); // Semifinali => 2 partite - 4 squadre
            associazioni.Add(4, "Q"); // Quarti => 4 partite - 8 squadre
            associazioni.Add(8, "O"); // {NO IMPL.} Ottavi => 8 partite - 16 squadre
            associazioni.Add(16, "X"); // {NO IMPL.} Eliminazioni => 16 partite - 32 squadre
        }

        private void FrmMain_Load(object sender, EventArgs e)
        {
            string line;
            int i = 1;
            // txtQ1, txtQ2, txtQ3...
            StreamReader sr = new StreamReader("squadre.txt");
          
            while(!sr.EndOfStream)
            {
                line = sr.ReadLine();
                Controls["txtQ" + (i++).ToString()].Text = line;
            }
            sr.Close();
            squadreLette = i - 1; 
        }

        private void btnAvvia_Click(object sender, EventArgs e)
        {
            rnd = new Random();
            t_arbitro = new Thread(arbitroThread);
            t_arbitro.Start();
            //arbitroThread();
            /* Disimpegno il main thread */
        }

        private void arbitroThread()
        {
            /*
             Il compito dell'arbitro è quello di mandare in campo due squadre alla volta,
            attendere il termine della partita e valutare chi è il vincitore per posizionarlo
            al turno successivo
             */
            while(squadreLette > 0)
            {
                // Inizio del girone
                eseguiTurno(squadreLette / 2);
                squadreLette = squadreLette / 2;
            }
        }

        private void eseguiTurno(int totalePartite)
        {
            int nPartita;
            TextBox[] txtAus;
            t_partite = new Thread[totalePartite];

            //0 - 2 - 4 - 6...
            for(int i = 0; i < (2 * totalePartite); i += 2)
            {
                nPartita = i / 2; // 0 1 2 3 

                txtAus = new TextBox[3];
                txtAus[0] = (TextBox)Controls["txt" + associazioni[totalePartite] + (i + 1).ToString() ];
                txtAus[1] = (TextBox)Controls["txt" + associazioni[totalePartite] + (i + 2).ToString()];
                txtAus[2] = (TextBox)Controls["txt" + associazioni[totalePartite/2] + (nPartita+1).ToString()];

                t_partite[nPartita] = new Thread(avviaPartita);
                t_partite[nPartita].Start(txtAus);
            }
            // L'arbitro, per concludere, attende che tutte le partite del girone
            // siano terminate! 
            // Altrimenti, passiamo al GIRONE SUCCESSIVO senza avere ancora gli esiti
            for (int i = 0; i < totalePartite; i++)
                t_partite[i].Join(); 
        }
        private void avviaPartita(object parametri)
        {
            TextBox txtSQ1 = (parametri as TextBox[])[0];
            TextBox txtSQ2 = (parametri as TextBox[])[1];
            TextBox txtWinner = (parametri as TextBox[])[2];

            string sq1 = txtSQ1.Text;
            string sq2 = txtSQ2.Text;
            string winner = "";

            int goal1, goal2;
            int tempoMin = 0; // Tempo esecuzione ciascuna partita 
            int tempoPerGoal; // Tempo di esecuzione per una rete
            // txt*1, txt*3, txt*5...
            switch(txtSQ1.Name[3])
            { // Da fare ALTRI TURNI 
                case 'Q':
                    tempoMin = 10000;
                    break;
                case 'S':
                    tempoMin = 15000;
                    break;
                case 'F':
                    tempoMin = 20000;
                    break;
            }

            Thread.Sleep(rnd.Next(100, 1000));
            goal1 = 0; goal2 = 0;
            // Avvio partita : Discesa in campo 

            // SEZIONE CRITICA: Solo un partita per volta 
            lock(lock_campo)
            {
                setCampo(sq1, sq2);
                // Simulazione partita
                while (tempoMin > 0 || goal1 == goal2)
                {
                    tempoPerGoal = rnd.Next(4000, 6000);
                    Thread.Sleep(tempoPerGoal);
                    tempoMin -= tempoPerGoal;
                    if (tempoPerGoal % 2 == 0)
                    {
                        goal2++;
                    }
                    else
                    {
                        goal1++;
                    }

                    // Aggiorno l'attuale punteggio della partita in corso
                    setCampo(sq1 + " - " + goal1.ToString(), sq2 + " - " + goal2.ToString());
                } // FINE PARTITA
                Thread.Sleep(250);
                setCampo("", "");

            }
            // FINE SEZIONE CRITICA 
            winner = (goal1 > goal2) ? sq1 : sq2;
            BeginInvoke((MethodInvoker)delegate ()
            {
                txtStatus.Text += sq1 + " (" + goal1 + "-" + goal2 + ") " + sq2 + Environment.NewLine;
                txtWinner.Text = winner;
            });

        }

        private void setCampo(string sq1, string sq2)
        {

            BeginInvoke((MethodInvoker)delegate () // BeginInvoke mi serve per cambiare la grafica, visto che e diverso dal mainTHread devo perforza fare la beginInvoke se no mi da errore di crossThread se lo faccio nel thread arbitro o nel thread principale, pero nel thread principale si èuo sempre leggere i nomi della variabile
            {
                lblSQ1.Text = sq1;
                lblSQ2.Text = sq2;
            });
        }
    }
}
