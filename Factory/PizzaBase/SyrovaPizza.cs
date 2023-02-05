namespace PizzaBase;

public class SyrovaPizza : Pizza
{
    public SyrovaPizza()
    {
        Nazev = "Syrova pizza";
    }

    public override void Priprava()
    {
        this.KorpusZaklad = new TenkyKorpus();
        this.OmackaZaklad = new SladkaOmacka();
        this.SyrZaklad = new EidamSyr();

        base.Priprava();

    }
}