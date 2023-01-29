namespace PripravaNapoje;

public class Caj : Napoj
{
    protected override void PripravZaklad()
    {
        Console.WriteLine("Pripravuji caj");
    }

    protected override void PridejPrilohy()
    {
        Console.WriteLine("Pridavam citron a med");
    }
}