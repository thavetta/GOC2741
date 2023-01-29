namespace MeteoStanice;

class ActualDisplay : IObserver, IDisplayElement
{
    private int teplota;
    private int tlak;
    private int vlhkost;
    public void Update(int teplota, int tlak, int vlhkost)
    {
        Console.WriteLine("Aktual dostal hodnoty");
        this.teplota = teplota;
        this.tlak = tlak;
        this.vlhkost = vlhkost;
    }

    public void DisplayData()
    {
        Console.WriteLine("Informace z aktual view");
        Console.WriteLine("Aktualni data:");
        Console.WriteLine("   Teplota: " + teplota);
        Console.WriteLine("   Tlak:    " + tlak);
        Console.WriteLine("   Vlhkost: " + vlhkost);
        Console.WriteLine();
    }
}