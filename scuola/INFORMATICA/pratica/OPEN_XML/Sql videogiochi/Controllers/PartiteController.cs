using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

internal class PartiteController
{
    private ClsSQLServer _db;

    public string Errore { get; set; }

    public PartiteController()
    {
        _db = new ClsSQLServer();
    }

    // Recupera tutte le partite con i dettagli di giocatore e gioco.
    // ordinate per gioco e punteggio decrescente (CLASSIFICA)
    public List<Partita> GetPartiteConDettagli()
    {
        List<Partita> lista = new List<Partita>();

        try
        {
            string sql = "SELECT P.IdPartita, P.IdGiocatore, P.IdGioco, P.DataPartita, P.Punteggio, G.Nickname,J.Titolo FROM Partite p JOIN Giocatori g ON P.IdGiocatore = G.IdGiocatore JOIN Giochi J ON P.IdGioco = J.IdGioco ORDER BY J.Titolo, P.Punteggio DESC;";
            var dt = _db.ExecuteQuery(sql);
            foreach (DataRow row in dt.Rows)
            {
                lista.Add(MapRow(row));
            }

        }
        catch (Exception ex)
        {
            Errore = ex.Message;
        }
        
        return lista;
    }

    private Partita MapRow(DataRow row)
    {
        return new Partita
        {
            IdPartita = (int)row["IdPartita"],
            IdGioco = (int)row["IdGioco"],
            IdGiocatore = (int)row["IdGiocatore"],
            DataPartita = (DateTime)row["DataPartita"],
            Punteggio = (int)row["Punteggio"],
            NicknameGiocatore = row["NickName"].ToString(),
            TitoloGioco = row["Titolo"].ToString(),
        };
    }
}
