namespace MeteoStanice;

class HistoryDisplay : IObserver, IDisplayElement
{
    private int minTlak;
    private int maxTlak;

    private int minTeplota;
    private int maxTeplota;

    private int minVlhkost;
    private int maxVlhkost;

    private bool poprve = true;

    public void Update(int teplota, int tlak, int vlhkost)
    {
        Console.WriteLine("Statistika dostala hodnoty");
        if (poprve)
        {
            poprve = false;
            minTeplota = maxTeplota = teplota;
            minTlak = maxTlak = tlak;
            minVlhkost = maxVlhkost = vlhkost;
            return;
        }

        minTeplota = Math.Min(teplota, minTeplota);
        maxTeplota = Math.Max(teplota, maxTeplota);

        minTlak = Math.Min(tlak, minTlak);
        maxTlak = Math.Max(tlak, maxTlak);

        minVlhkost = Math.Min(vlhkost, minVlhkost);
        maxVlhkost = Math.Max(vlhkost, maxVlhkost);
    }

    public void DisplayData()
    {
        Console.WriteLine("Informace z historickeho view");
        Console.WriteLine("Minima:");
        Console.WriteLine("   Teplota: " + minTeplota);
        Console.WriteLine("   Tlak:    " + minTlak);
        Console.WriteLine("   Vlhkost: " + minVlhkost);
        Console.WriteLine("Maxima:");
        Console.WriteLine("   Teplota: " + maxTeplota);
        Console.WriteLine("   Tlak:    " + maxTlak);
        Console.WriteLine("   Vlhkost: " + maxVlhkost);
        Console.WriteLine();
    }
}