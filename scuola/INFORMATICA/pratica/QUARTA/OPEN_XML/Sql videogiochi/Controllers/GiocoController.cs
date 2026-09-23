using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

internal class GiocoController
{
    private ClsSQLServer _db;

    public string Errore { get; set; }

    public GiocoController()
    {
        _db = new ClsSQLServer();
    }

    public List<Gioco> GetAll()
    {
        List<Gioco> list = new List<Gioco>();

        try
        {
            string sql = "SELECT * FROM Giochi ORDER BY Titolo;";

            var dt = _db.ExecuteQuery(sql);

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

    public List<Gioco> GetByTitolo(string titolo)
    {
        List<Gioco> list = new List<Gioco>();

        try
        {
            Dictionary<string, object> param = new Dictionary<string, object>
            {
                { "@Titolo", titolo }
            };

            string sql = "SELECT * FROM Giochi WHERE Titolo LIKE @Titolo;";

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

    public List<Gioco> GetByCategoria(string categoria)
    {
        List<Gioco> list = new List<Gioco>();

        try
        {
            Dictionary<string, object> param = new Dictionary<string, object>
            {
                { "@categoria",  categoria }
            };

            string sql = "SELECT * FROM Giochi WHERE Categoria LIKE @categoria ORDER BY Titolo;";

            DataTable dt = _db.ExecuteQuery(sql, param);

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

    public bool Insert(Gioco g)
    {
        try
        {
            Dictionary<string, object> param = new Dictionary<string, object>
            {
                { "@Titolo", g.Titolo},
                { "@Categoria", g.Categoria},
                { "@CasaProduttrice", g.CasaProduttrice},
                { "@AnnoUscita", g.AnnoUscita}
            };
            string sql = "INSERT INTO Giochi(Titolo, Categoria, CasaProduttrice, AnnoUscita) VALUES(@Titolo, @Categoria, @CasaProduttrice, @AnnoUscita);";
            _db.ExecuteNonQuery(sql, param);

            return true;
        }
        catch(Exception ex)
        {
            Errore = ex.Message;
            return false;
        }
    }

    private Gioco MapRow(DataRow row)
    {
        return new Gioco
        {
            IdGioco = (int)row["IdGioco"],
            Titolo = row["Titolo"].ToString(),
            Categoria = row["Categoria"].ToString(),
            CasaProduttrice = row["CasaProduttrice"].ToString(),
            AnnoUscita = (int)row["AnnoUscita"]
        };
    }
}
