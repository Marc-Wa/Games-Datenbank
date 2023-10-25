namespace GamesDatenbankEntities;

public class AllgemeineDetails
{
    public int GameID { get; set; }
    public Genre Genre { get; set; }
    public Platform PlattformRelease { get; set; }
    public DateTime? Erscheinungsjahr { get; set; }
    public int? Bewertung { get; set; }
    public int? Verkaufszahlen { get; set; }
    public int? SpielerzahlenAktuell { get; set; }

    public virtual ICollection<Game> Games { get; set; } = new List<Game>();
}

