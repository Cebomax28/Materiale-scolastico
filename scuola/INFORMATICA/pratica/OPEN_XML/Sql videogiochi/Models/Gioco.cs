using System;

public class Gioco
{
    public int IdGioco { get; set; }
    public string Titolo { get; set; }
    public string Categoria { get; set; }
    public string CasaProduttrice { get; set; }
    public int AnnoUscita { get; set; }

    public override string ToString()
    {
        return Titolo; 
    }
}
