namespace SimpleCommand;

public class Svetlo
{
    public string Nazev { get; set; } = String.Empty;

    bool stav;

    public void ZmenStav()
    {
        stav = !stav;
        if (stav)
        {
            Console.WriteLine("Svetlo " + Nazev + " sviti");
        }
        else
        {
            Console.WriteLine("Svetlo " + Nazev + " nesviti");
        }
    }
}