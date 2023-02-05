namespace JenJeden;

/// <summary>
/// Class Singleton4 - elegantní, bez lock sekce, ale není lazy
/// </summary>
public sealed class Singleton4
{
    private static readonly Singleton4 instance = new Singleton4();

    // Explicit static constructor to tell C# compiler
    // not to mark type as beforefieldinit
    static Singleton4()
    {
    }

    private Singleton4()
    {
    }

    public static Singleton4 Instance => instance;
    
}