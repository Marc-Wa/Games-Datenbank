namespace GamesDatenbankEntities;

[Flags]
public enum Genre
{
    None = 0,
    Action = 1,
    Fps = 2,
    Strategy = 4,
    Shooter = 8,
    Moba = 16,

    ActionFps = Action | Fps
}

