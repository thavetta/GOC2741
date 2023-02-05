namespace PizzaBase;

public abstract class Pizza
{
    public string Nazev { get; set; }
    public Syr SyrZaklad { get; set; }
    public Korpus KorpusZaklad { get; set; }
    public Omacka OmackaZaklad { get; set; }
        
    public virtual void Priprava()
    {
        Console.WriteLine("Pripravuji " + Nazev);
        Console.WriteLine(this.KorpusZaklad.ToString());
        Console.WriteLine(this.OmackaZaklad.ToString());
        Console.WriteLine(this.SyrZaklad.ToString());
    }

    public virtual void Peceni()
    {
        Console.WriteLine("Pecu pizzu na 150 stupnu 15 minut");
    }

    public virtual void Krajeni()
    {
        Console.WriteLine("Nakrajim pizzu na 8 casti");
    }

    public virtual void Baleni()
    {
        Console.WriteLine("Zabalim pizzu do boxu");
    }
}