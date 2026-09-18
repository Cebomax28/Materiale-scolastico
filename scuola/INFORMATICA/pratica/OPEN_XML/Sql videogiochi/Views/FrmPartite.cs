using SQLServer_Videogiochi.Controllers;
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
    public partial class FrmPartite : Form
    {
        ClsSQLServer _db = new ClsSQLServer();
        int IdGiocatore;
        int IdGioco;

        string[] Nicknames = {
            "ArcadeBoy", "ChibiStar", "DragonSlayer", "Elizor",
            "FastPulse", "FireStrike", "GhostBlade", "LunaCode",
            "MaryWhite", "MoonFury", "NeoByte", "NightCat",
            "PixelQueen", "ShadowKing", "SkyBurst", "XStorm"
        };

        string[] titoli = {
            "Minecraft", "Fortnite", "League of Legends", "Valorant", "Rocket League",
            "Overwatch", "Among Us", "Call of Duty: Warzone", "FIFA 23", "Genshin Impact",
            "Apex Legends", "Terraria", "CS: GO", "The Sims 4", "Roblox",
            "Assassin’s Creed Valhalla", "Hollow Knight", "Cyberpunk 2077", "PUBG",
            "Brawl Stars", "Mario Kart 8 Deluxe", "Zelda: Breath of the Wild",
            "Splatoon 3", "Clash Royale", "Elden Ring", "Fall Guys", "It Takes Two",
            "Red Dead Redemption 2", "The Witcher 3", "Resident Evil 4", "Hades",
            "Doom Eternal", "F1 23", "Stardew Valley", "FIFA 22", "Little Nightmares II",
            "Left 4 Dead 2", "Plants vs. Zombies", "NBA 2K24", "Titanfall 2",
            "Super Mario Odyssey", "NBA 2K21", "Metro Exodus", "Tetris Effect",
            "Borderlands 3", "Crash Team Racing Nitro-Fueled", "Monster Hunter: World",
            "Diablo IV", "Hitman 3", "Sonic Frontiers", "Dead by Daylight", "Paladins",
            "Need for Speed Heat", "Age of Empires IV", "Cuphead", "ARK: Survival Evolved",
            "Far Cry 6", "Slay the Spire", "Skyrim", "Just Dance 2024"
        };
        PartitaController pContr = new PartitaController();

        public FrmPartite()
        {
            InitializeComponent();
        }

        private void btnFiltra_Click(object sender, EventArgs e)
        {
            string giocatore = cmbFiltGiocatore.Text;
            string gioco = cmbFiltGioco.Text;
            dgvPartite.DataSource = pContr.GetByGiocatore(giocatore, gioco);
        }

        private void btnTop10_Click(object sender, EventArgs e)
        {
            dgvPartite.DataSource = pContr.Top10Punteggi();
        }

        private void btnTutte_Click(object sender, EventArgs e)
        {
            dgvPartite.DataSource = pContr.GetAll();
        }

        private void btnSalvaPartita_Click(object sender, EventArgs e)
        {
            string sqlIdGiocatore = $"SELECT g.IdGiocatore FROM Giocatori g JOIN Partite p ON p.IdGiocatore = g.IdGiocatore WHERE Nickname = '{cmbNPGiocatore.Text}';";
            string sqlIdGioco = $"SELECT j.IdGioco FROM Giochi j JOIN Partite p ON p.IdGioco = j.IdGioco WHERE j.Titolo = '{cmbNPGioco.Text}';";
            int IdGiocatore = Convert.ToInt32(_db.ExecuteScalar(sqlIdGiocatore));
            int IdGioco = Convert.ToInt32(_db.ExecuteScalar(sqlIdGioco));
            if (MessageBox.Show("Confermare l'inserimento di un nuovo giocatore?", "Conferma",
                                MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                Partita p = new Partita
                {
                    IdGiocatore = IdGiocatore,
                    IdGioco = IdGioco,
                    DataPartita = (DateTime)dtpNPData.Value,
                    Punteggio = Convert.ToInt32(numNPPunteggio.Value),
                    NicknameGiocatore = cmbNPGiocatore.Text,
                    TitoloGioco = cmbNPGioco.Text
                };

                if (pContr.Insert(p))
                {
                    dgvPartite.DataSource = pContr.GetAll();
                    MessageBox.Show("Partita inserita con successo");
                }
                else
                    MessageBox.Show(pContr.Errore.ToString());
            }
        }



        private void FrmPartite_Load(object sender, EventArgs e)
        {
            foreach (var item in Nicknames)
            {
                cmbNPGiocatore.Items.Add(item);
                cmbFiltGiocatore.Items.Add(item);
            }

            foreach (var item in titoli)
            {
                cmbFiltGioco.Items.Add(item);
                cmbNPGioco.Items.Add(item);
            }
            dgvPartite.DataSource = pContr.GetAll();
        }

        private void cmbNPGiocatore_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void cmbNPGioco_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void dtpNPData_ValueChanged(object sender, EventArgs e)
        {

        }

        private void numNPPunteggio_ValueChanged(object sender, EventArgs e)
        {

        }
    }
}
