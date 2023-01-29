namespace PripravaNapoje;

public class Kava : Napoj
{
    protected override void PripravZaklad()
    {
        Console.WriteLine("Pripravuji kavu");
    }

    protected override void PridejPrilohy()
    {
        Console.WriteLine("Pridavam mleko a cukr");
    }

    protected override bool DotazNaPrilohu()
    {
        Console.WriteLine("Chcete prilohu?");
        var klavesa = Console.ReadKey(true).Key;

        return klavesa == ConsoleKey.A;
    }
}