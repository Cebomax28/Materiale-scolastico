using System;
using System.Collections.Generic;
using System.Data;

class GiocatoriController
{
    private readonly ClsSQLServer _db;

    public string Errore { get; set; }

    public GiocatoriController()
    {
        _db = new ClsSQLServer();
    }

    // Recupera tutti i giocatori ordinati per cognome e nome
    public List<Giocatore> GetAll()
    {
        List<Giocatore> list = new List<Giocatore>();

        try
        {
            string sql = "SELECT * FROM Giocatori ORDER BY Cognome, Nome;";
            DataTable dt = _db.ExecuteQuery(sql);

            foreach(DataRow row in dt.Rows)
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
    // Carca giocatori per nickname 
    public List<Giocatore> GetByNickname(string nickname)
    {
        List<Giocatore> list = new List<Giocatore>();
        try
        {
            var param = new Dictionary<string, object>
            {
                { "@nick", "%" + nickname + "%"}
            };
            string sql = "SELECT * FROM Giocatori WHERE Nickname LIKE @nick ORDER BY Nickname;";
            var dt = _db.ExecuteQuery(sql, param);
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
    
    // Inserisce un nuovo giocatore, restituisce true se 
    // l'operazione va a buon fine 
    public bool Insert(Giocatore g)
    {
        try
        {
            var param = new Dictionary<string, object>
            {
                {"@Nome", g.Nome },
                {"@Cognome", g.Cognome },
                {"@Nickname", g.Nickname },
                {"@Email", g.Email },
                {"@DataNascita", g.DataNascita }
            };

            _db.ExecuteNonQuery("" +
                "INSERT INTO Giocatori(Nome, Cognome, Nickname," +
                "Email, DataNascita) VALUES(" +
                "@Nome, @Cognome, @Nickname, @Email, @DataNascita);", param);
            return true;
        }   
        catch(Exception ex)
        {
            Errore = ex.Message;
            return false;
        }
    }

    // Aggiorna nickname ed email di un giocatore
    // identificato dal suo ID. Restituisce true se l'op. va a buon fine
    public bool Update(Giocatore g)
    {
       try
        {
            Dictionary<string, object> param = new Dictionary<string, object>
            {
                { "@IdGiocatore", g.IdGiocatore},
                { "@Nickname", g.Nickname}
            };
            string sql = "UPDATE Giocatori SET Nickname = @Nickname WHERE IdGiocatore = @IdGiocatore";

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

    // Elimina un giocatore dal db tramite il suo ID.
    // Restituisce true se l'operazione va a buon fine 
    public bool Delete(int idGiocatore)
    {
        try
        {
            var param = new Dictionary<string, object> 
            {
                { "@Id", idGiocatore }
            };
            _db.ExecuteNonQuery("DELETE FROM Giocatori WHERE IdGiocatore=@Id;", param);
            return true;
        }
        catch (Exception ex)
        {
            Errore = ex.Message;
            return false;
        }
    }
    private Giocatore MapRow(DataRow row)
    {
        return new Giocatore
        {
            IdGiocatore = (int)row["IdGiocatore"],
            Nome = row["Nome"].ToString(),
            Cognome = row["Cognome"].ToString(),
            Nickname = row["Nickname"].ToString(),
            Email = row["Email"].ToString(),
            DataNascita = (DateTime)row["DataNascita"]
        };
    }
}
