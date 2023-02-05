namespace PizzaBase;

public class SyrovaPizzaBRQ : Pizza
{
    public SyrovaPizzaBRQ()
    {
        Nazev = "Syrova pizza Brno edition";
    }

    public override void Priprava()
    {
        this.KorpusZaklad = new TlustyKorpus();
        this.OmackaZaklad = new OstraOmacka();
        this.SyrZaklad = new MozarellaSyr();
        base.Priprava();
    }
}