namespace GamesDatenbankEntities;

public class Publisher
{
    public int PublisherID { get; set; }
    public string Name { get; set; } = string.Empty;
    public string? Standort { get; set; }
    public int? AnzahlMitarbeiter { get; set; }
    public int? FirmenWert { get; set; }
    public virtual ICollection<Game> Games { get; set; } = new List<Game>();
}

