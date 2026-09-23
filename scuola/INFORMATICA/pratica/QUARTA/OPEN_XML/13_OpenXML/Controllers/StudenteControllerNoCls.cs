using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Data.SqlClient;
using System.Windows.Forms;
using System.IO;
using System.Data;
using DocumentFormat.OpenXml.Wordprocessing;

internal class StudenteControllerNoCls
{
    static Random rnd = new Random();
    private SqlConnection _sqlConnection; // Gestione Connessione
    private SqlCommand _sqlCommand; // Gestione comandi 
    private SqlDataReader _sqlDataReader; // Gestione esito

    private string _dbPath = Application.StartupPath + @"\vallauridb.mdf";
    public string Errore { get; set; } // Gestione errori

    private string _strConn = "";
    public List<Studente> _lstStudenti;
    private void connetti()
    {
        _strConn = @"Data Source=(LocalDB)\MSSQLLocalDB;";
        _strConn += @"AttachDbFilename=" + _dbPath +";";
        _strConn += @"Integrated Security=True;Connect Timeout=30";

        _sqlConnection = new SqlConnection(_strConn);
        _sqlConnection.Open();
    }
    private void disconnetti()
    {
        _sqlConnection.Close();
    }

    public StudenteControllerNoCls()
    {
        string sql = "SELECT * FROM alunni;";
        Studente stu; 
        try
        {
            connetti();
            _sqlCommand = new SqlCommand();
            _sqlCommand.Connection = _sqlConnection;
            _sqlCommand.CommandType = System.Data.CommandType.Text;
            _sqlCommand.CommandText = sql;

            _lstStudenti = new List<Studente>();

            _sqlDataReader = _sqlCommand.ExecuteReader();

            while(_sqlDataReader.Read())
            {
                stu = new Studente();
                stu.Matricola = _sqlDataReader["matricola"].ToString();
                stu.CodClasse = (int) _sqlDataReader["codClasse"];
                stu.Cognome = _sqlDataReader["cognome"].ToString();
                stu.Nome = _sqlDataReader["nome"].ToString();
                stu.DataN = (DateTime)_sqlDataReader["dataN"];
                stu.CittaN = _sqlDataReader["cittaN"].ToString();
                stu.CittaR = _sqlDataReader["cittaR"].ToString();
                stu.IndirizzoR = _sqlDataReader["indirizzoR"].ToString();

                _lstStudenti.Add(stu);
            }
        }
        catch(Exception ex)
        {
            Errore = ex.Message;
        }
        finally
        {
            disconnetti();
        }
    }
    internal DataTable GetClassi()
    {
        string sql = "SELECT id, CONCAT(numero, '^', sezione) as 'valore' ";
                sql += "FROM classi;";
        DataTable dt = new DataTable();

        try
        {
            connetti();
            _sqlCommand = new SqlCommand();
            _sqlCommand.Connection = _sqlConnection;
            _sqlCommand.CommandType = System.Data.CommandType.Text;
            _sqlCommand.CommandText = sql;
            
            using (_sqlDataReader = _sqlCommand.ExecuteReader())
            {
                dt.Load(_sqlDataReader);
            }
        }
        catch(Exception ex)
        {
            Errore = ex.Message;
        }
        finally
        {
            disconnetti();
        }
        return dt;
    }
    internal void addStudente(Studente stu)
    {
        string sql;
        _lstStudenti.Add(stu);

        try
        {
            //sql = "INSERT INTO alunni " +
            //"(matricola, codClasse, cognome, nome, dataN, cittaN, " +
            //"cittaR, indirizzoR) " +
            //"VALUES('" + stu.Matricola + "', " + stu.CodClasse +
            //", '" + stu.Cognome + "', '" + stu.Nome + "', '" + stu.DataN + "', " +
            //"'" + stu.CittaN + "', '" + stu.CittaR + "', '" + stu.IndirizzoR + "');";

            sql = "INSERT INTO alunni(matricola, codClasse, cognome, nome, dataN, cittaN, cittaR, indirizzoR) ";
            sql += "VALUES(";
            sql += "@Matr, @CodC, @Cognome, @Nome, @DataN, @CittaN, @CittaR, @IndirizzoR";
            sql += ");";

            connetti();
            _sqlCommand = new SqlCommand();
            _sqlCommand.Connection = _sqlConnection;
            _sqlCommand.CommandType = System.Data.CommandType.Text;
            _sqlCommand.CommandText = sql;
            _sqlCommand.Parameters.AddWithValue("@Matr", stu.Matricola);
            _sqlCommand.Parameters.AddWithValue("@CodC", stu.CodClasse);
            _sqlCommand.Parameters.AddWithValue("@Cognome", stu.Cognome);
            _sqlCommand.Parameters.AddWithValue("@Nome", stu.Nome);
            _sqlCommand.Parameters.AddWithValue("@CittaN", stu.CittaN);
            _sqlCommand.Parameters.AddWithValue("@CittaR", stu.CittaR);
            _sqlCommand.Parameters.AddWithValue("@DataN", stu.DataN);
            _sqlCommand.Parameters.AddWithValue("@IndirizzoR", stu.IndirizzoR);

            _sqlCommand.ExecuteNonQuery();
        }
        catch(Exception ex)
        {
            Errore = ex.Message;
        }
        finally
        {
            disconnetti();
        }
    }

    internal string GetMatricolaRnd()
    {
        // AA00AA
        string lettere = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";
        string numeri = "0123456789";
        string matr;

        matr = lettere[rnd.Next(0, lettere.Length)] + "" + lettere[rnd.Next(0, lettere.Length)];
        matr += numeri[rnd.Next(0, numeri.Length)] + "" + numeri[rnd.Next(0, numeri.Length)];
        matr += lettere[rnd.Next(0, lettere.Length)] + "" + lettere[rnd.Next(0, lettere.Length)];

        return matr; 
    }

    internal object GetClassByCod(int codClasse)
    {
        string classe = "";

        try
        {
            connetti();
            _sqlCommand = new SqlCommand();
            _sqlCommand.Connection = _sqlConnection;
            _sqlCommand.CommandType = CommandType.Text;
            _sqlCommand.CommandText = "SELECT CONCAT(numero, '^', sezione) " +
                                        " FROM classi WHERE id = @codClasse;";
            _sqlCommand.Parameters.AddWithValue("@codClasse", codClasse);
            classe = _sqlCommand.ExecuteScalar().ToString();
        }
        catch(Exception ex)
        {
            Errore = ex.Message;
        }
        finally
        {
            disconnetti();
        }
        return classe;
    }

    internal void stampaPagelle(string folderPath)
    {
        string sql, docxPath;
        int[] voti = new int[12];

        sql = "SELECT alunni.matricola, cognome, nome, cittaN, cittaR, indirizzoR, " +
              "FORMAT(alunni.dataN, 'dd/MM/yyyy') AS dataN, " +
              "CONCAT(classi.numero, classi.sezione) AS classe " +
              "FROM alunni, classi " +
              "WHERE alunni.codClasse = classi.id " +
              "ORDER BY alunni.codClasse";

        try
        {
            connetti();
            _sqlCommand = new SqlCommand();
            _sqlCommand.Connection = _sqlConnection;
            _sqlCommand.CommandType = CommandType.Text;
            _sqlCommand.CommandText = sql;

            _sqlDataReader = _sqlCommand.ExecuteReader();
            while (_sqlDataReader.Read())
            {
                if (!Directory.Exists(folderPath + "\\" + _sqlDataReader["classe"].ToString()))
                {
                    Directory.CreateDirectory(folderPath + "\\" + _sqlDataReader["classe"].ToString());
                }
                docxPath = folderPath + "\\" + _sqlDataReader["classe"].ToString();
                docxPath += "\\" + _sqlDataReader["nome"].ToString().Trim() + "_" + _sqlDataReader["cognome"].ToString().Trim() + "_" + _sqlDataReader["matricola"].ToString().Trim() + ".docx";
                File.Copy(folderPath + "\\template.docx", docxPath);
            }
        }
        catch(Exception ex)
        {
            this.Errore = ex.Message;
        }
        finally
        {
            disconnetti();
        }

    }
}
