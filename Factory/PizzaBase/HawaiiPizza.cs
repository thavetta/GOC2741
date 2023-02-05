namespace PizzaBase;

public class HawaiiPizza : Pizza
{
    public HawaiiPizza()
    {
        Nazev = "Hawai pizza";
    }

    public override void Priprava()
    {
        this.KorpusZaklad = new TenkyKorpus();
        this.OmackaZaklad = new SladkaOmacka();
        this.SyrZaklad = new EidamSyr();
        base.Priprava();
    }
}