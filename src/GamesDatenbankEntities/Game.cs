namespace GamesDatenbankEntities;

public class Game
{
    public int GameID { get; set; }
    public string Spieletitel { get; set; } = string.Empty;
    public virtual PrivateDetails PrivateDetails { get; set; } = new();
    public virtual AllgemeineDetails? AllgemeineDetails { get; set; }
    public virtual ICollection<Entwicklerstudio> Entwicklerstudios { get; set; } = new List<Entwicklerstudio>();
    public virtual Publisher? Publisher { get; set; }
}

