namespace JenJeden;
/// <summary>
/// Class Singleton2 - NEPOUŽÍVAT!!!!!
/// Teď už tu není chyba, ale je to pomalé. Proč???
/// </summary>
public sealed class Singleton2
{
    private static Singleton2? instance = null;
    private static readonly object padlock = new object();

    private Singleton2()
    {
    }

    public static Singleton2 Instance
    {
        get
        {
            lock (padlock)
            {
                return instance ??= new Singleton2();
            }
        }
    }
}