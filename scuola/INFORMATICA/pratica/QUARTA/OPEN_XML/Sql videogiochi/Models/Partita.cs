using System;

public class Partita
{
    public int IdPartita { get; set; }
    public int IdGiocatore { get; set; }
    public int IdGioco { get; set; }
    public DateTime DataPartita { get; set; }
    public int Punteggio { get; set; }

    //-------
    public string NicknameGiocatore { get; set; }
    public string TitoloGioco { get; set; }
}
