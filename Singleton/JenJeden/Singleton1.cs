namespace JenJeden;

/// <summary>
/// Singleton class - NEPOUŽÍVAT!!!!!
/// Najděte zásadní problém s tímto řešením.
/// </summary>
public sealed class Singleton1
{
    private static Singleton1? instance = null;

    private Singleton1()
    {
    }

    public static Singleton1 Instance => instance ??= new Singleton1();
    
}