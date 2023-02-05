namespace JenJeden;

/// <summary>
/// Class Singleton3 - použitelné, ale...
/// </summary>
internal class Singleton3
{
    private static Singleton3? instance = null;
    private static readonly object padlock = new object();

    Singleton3()
    {
    }

    public static Singleton3 Instance
    {
        get
        {
            if (instance is not null) return instance;
            
            lock (padlock)
            {
                instance ??= new Singleton3();
            }
            
            return instance;
        }
    }
}