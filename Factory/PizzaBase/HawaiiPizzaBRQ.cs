namespace PizzaBase;

public class HawaiiPizzaBRQ : Pizza
{
    public HawaiiPizzaBRQ()
    {
        Nazev = "Hawai pizza Brno edition";
    }

    public override void Priprava()
    {
        this.KorpusZaklad = new TlustyKorpus();
        this.OmackaZaklad = new OstraOmacka();
        this.SyrZaklad = new MozarellaSyr();
        base.Priprava();
    }
}