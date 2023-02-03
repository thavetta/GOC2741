namespace Ovladac;

public class HiFiVez
{
    public void Zapni()
    {
        Console.WriteLine("Zapnul jsem HiFi");
    }

    public void Vypni()
    {
        Console.WriteLine("Vypnul jsem HiFi");
    }

    public void SetCD()
    {
        Console.WriteLine("Nastavil jsem na HiFi CD");
    }

    public void SetRadio()
    {
        Console.WriteLine("Nastavil jsem na HiFi Radio");
    }

    public void SetHlasitost(int uroven)
    {
        Console.WriteLine("Nastavil jsem hlasitost na uroven " + uroven);
    }
}