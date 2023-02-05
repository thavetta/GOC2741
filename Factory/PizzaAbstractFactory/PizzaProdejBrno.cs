using PizzaBase;

namespace PizzaAbstractFactory;

public class PizzaProdejBrno : PizzaProdej
{
    public PizzaProdejBrno()
    {
        this.factory = new PizzaPrilohaFactoryBrno();
    }

    protected override Pizza? VytvorPizzu(string nazev)
    {
        return nazev switch
        {
            "Klasik" => new PizzaWithFactory(factory) { Nazev = "Brnenska Klasik pizza" },
            "Hawai" => new PizzaWithFactory(factory) { Nazev = "Brnenska Hawai pizza" },
            "Syrova" => new PizzaWithFactory(factory) { Nazev = "Brnenska Syrova pizza" },
            _ => null
        };
    }
}