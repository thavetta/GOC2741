namespace GenericCommand;

public class Svetlo
{
    public string Nazev { get; set; } = String.Empty;

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