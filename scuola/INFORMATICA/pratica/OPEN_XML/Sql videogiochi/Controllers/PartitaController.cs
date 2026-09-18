using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Rebar;

namespace SQLServer_Videogiochi.Controllers
{
    internal class PartitaController
    {
        ClsSQLServer _db = new ClsSQLServer();

        public string Errore { get; set; }


        public List<Partita> GetAll()
        {
            List<Partita> list = new List<Partita>();

            try
            {
                string sql = "" +
                    "SELECT p.IdPartita, p.IdGiocatore, p.IdGioco, p.DataPartita, p.Punteggio, g.Nickname, j.Titolo " +
                    "FROM Partite p " +
                    "JOIN Giocatori g ON g.IdGiocatore = p.IdGiocatore " +
                    "JOIN Giochi j ON j.IdGioco = p.IdGioco " +
                    "ORDER BY Punteggio;";

                DataTable dt = _db.ExecuteQuery(sql);

                foreach (DataRow row in dt.Rows)
                {
                    list.Add(MapRow(row));
                }
            }
            catch(Exception ex)
            {
                Errore = ex.Message;
            }


            return list;
        }

        public List<Partita> GetByGiocatore(string giocatore, string gioco)
        {
            List<Partita> list = new List<Partita>();
            
            try
            {
                Dictionary<string, object> param = new Dictionary<string, object>
                {
                    { "@giocatore",  giocatore },
                    { "@gioco",  gioco }
                };
                string sql = "SELECT p.IdPartita, p.IdGiocatore, p.IdGioco, p.DataPartita, p.Punteggio, g.Nickname, j.Titolo" +
                    " FROM Partite p" +
                    " JOIN Giocatori g ON g.IdGiocatore = p.IdGiocatore" +
                    " JOIN Giochi j ON j.IdGioco = p.IdGioco" +
                    " WHERE g.Nickname LIKE @giocatore AND" +
                    " j.Titolo LIKE @gioco" +
                    " ORDER BY p.Punteggio ASC;";

                DataTable dt = _db.ExecuteQuery(sql, param);

                foreach (DataRow row in dt.Rows)
                {
                    list.Add(MapRow(row));
                }
            }
            catch(Exception ex)
            {
                Errore = ex.Message;
            }

            return list;
        }

        public List<Partita> GetByGioco(string gioco)
        {
            List<Partita> list = new List<Partita>();

            try
            {
                Dictionary<string, object> param = new Dictionary<string, object>
                {
                    { "@gioco",  gioco }
                };

                string sql = "SELECT p.IdPartita, p.IdGiocatore, p.IdGioco, p.DataPartita, p.Punteggio, g.Nickname, j.Titolo " +
                    "FROM Partite p " +
                    "JOIN Giocatori g ON g.IdGiocatore = p.IdGiocatore " +
                    "JOIN Giochi j ON j.IdGioco = p.IdGioco " +
                    "WHERE j.titolo LIKE @gioco" +
                    "ORDER BY Punteggio";
                DataTable dt = _db.ExecuteQuery(sql, param);

                foreach (DataRow row in dt.Rows)
                {
                    list.Add(MapRow(row));
                }
            }
            catch (Exception ex)
            {
                Errore = ex.Message;
            }

            return list;
        }

        public List<Partita> Top10Punteggi()
        {
            List<Partita> list = new List<Partita>();

            try
            {
                string sql = "SELECT TOP 10 p.IdPartita, g.IdGiocatore, j.IdGioco, p.DataPartita, p.Punteggio, g.Nickname, j.Titolo \r\nFROM Partite p\r\nJOIN Giocatori g ON g.IdGiocatore = p.IdGiocatore\r\nJOIN Giochi j ON j.IdGioco = p.IdGioco\r\nORDER BY p.Punteggio DESC;";

                DataTable dt = _db.ExecuteQuery(sql);

                foreach (DataRow row in dt.Rows)
                {
                    list.Add(MapRow(row));
                }
            }
            catch (Exception ex)
            {
                Errore = ex.Message;
                return null;
            }

            return list;
        }

        public bool Insert(Partita p)
        {
            try
            {
               

                Dictionary<string, object> param = new Dictionary<string, object>
                {
                    { "@IdGiocatore", p.IdGiocatore},
                    { "@IdGioco", p.IdGioco},
                    { "@dataPartita", p.DataPartita},
                    { "@punteggio", p.Punteggio},
                    { "@nickname", p.NicknameGiocatore},
                    { "@titolo", p.TitoloGioco}
                };
                string sql = "INSERT INTO Partite(IdGiocatore, IdGioco, DataPartita, Punteggio) VALUES(@IdGiocatore, @IdGioco, @dataPartita, @punteggio);";

                int rows = _db.ExecuteNonQuery(sql, param);

                if (rows == 0)
                    return false;

                return true;
            }
            catch (Exception ex)
            {
                Errore = ex.Message;
                return false;
            }

        }

        public bool UpdatePunteggio(int idPartita, int nuovoPunteggio)
        {
            try
            {
                Dictionary<string, object> param = new Dictionary<string, object>
                {
                    { "@IdPartita", idPartita },
                    { "@Punteggio", nuovoPunteggio }
                };
                string sql = "UPDATE Partite SET Punteggio = @Punteggio WHERE IdPartita = @IdPartita;";
                int rows = _db.ExecuteNonQuery(sql, param);

                if (rows == 0)
                    return false;

                return true;

            }
            catch (Exception ex)
            {
                Errore = ex.Message;
                return false;
            }
        }

        private Partita MapRow(DataRow row)
        {
            return new Partita
            {
                
                IdPartita = Convert.ToInt32(row["IdPartita"]),
                IdGiocatore = Convert.ToInt32(row["IdGiocatore"]),
                IdGioco = Convert.ToInt32(row["IdGioco"]),
                DataPartita = (DateTime)row["DataPartita"],
                Punteggio = Convert.ToInt32(row["Punteggio"]),
                NicknameGiocatore = row["NickName"].ToString(),
                TitoloGioco = row["Titolo"].ToString()
            };
        }
    }
}
