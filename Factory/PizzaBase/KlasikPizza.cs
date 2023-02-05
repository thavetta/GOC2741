namespace PizzaBase;

public class KlasikPizza : Pizza
{
    public KlasikPizza()
    {
        Nazev = "Klasik pizza";
    }

    public override void Priprava()
    {
        this.KorpusZaklad = new TenkyKorpus();
        this.OmackaZaklad = new SladkaOmacka();
        this.SyrZaklad = new EidamSyr();
        base.Priprava();
    }
}