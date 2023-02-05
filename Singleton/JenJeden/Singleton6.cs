namespace JenJeden;

/// <summary>
/// Class Singleton6 - využití třídy Lazy&lt;T&gt pro vytvoření instance až bude potřebná
/// Synchronizaci řeší samotná třída Lazy&lt;T&gt
/// </summary>
public sealed class Singleton6
{
    private static readonly Lazy<Singleton6> lazy =
        new Lazy<Singleton6>(() => new Singleton6());

    public static Singleton6 Instance => lazy.Value;

    private Singleton6()
    {
    }
}