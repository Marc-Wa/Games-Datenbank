using System.CodeDom.Compiler;
using System.Dynamic;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.FileIO;

namespace GamesDatenbankEntities;

public class PrivateDetails
{
    public int GameID { get; set; }
    public TimeSpan? Spielzeit { get; set; }
    public Platform PlattformBesitz { get; set; }

    public virtual ICollection<Game> Games { get; set; } = new List<Game>();
}

