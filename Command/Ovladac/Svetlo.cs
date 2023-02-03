namespace Ovladac;

public class Svetlo
{
    public string Nazev { get; set; }

    private bool stav;

    public void Zapni()
    {
        stav = true;
        VypisStav();
    }

    public void Vypni()
    {
        stav = false;
        VypisStav();
    }

    private void VypisStav()
    {
        string text = stav ? " sviti" : " nesviti";
        Console.WriteLine("Svetlo " + Nazev + text);
    }
}