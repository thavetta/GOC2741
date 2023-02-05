namespace PizzaBase;

public class KlasikPizzaBRQ : Pizza
{
    public KlasikPizzaBRQ()
    {
        Nazev = "Klasik pizza Brno edition";
    }

    public override void Priprava()
    {
        this.KorpusZaklad = new TlustyKorpus();
        this.OmackaZaklad = new OstraOmacka();
        this.SyrZaklad = new MozarellaSyr();
        base.Priprava();
    }
}