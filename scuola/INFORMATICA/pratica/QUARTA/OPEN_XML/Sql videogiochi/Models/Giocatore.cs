using System;


public class Giocatore
{
    public int IdGiocatore { get; set; }
    public string Nome { get; set; }
    public string Cognome { get; set; }
    public string Nickname { get; set; }
    public string Email { get; set; }
    public DateTime DataNascita { get; set; }

    public override string ToString()
    {
        return $"{Nickname} ({Nome} {Cognome})";
    }
}