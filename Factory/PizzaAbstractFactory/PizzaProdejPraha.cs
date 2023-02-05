using PizzaBase;

namespace PizzaAbstractFactory;

public class PizzaProdejPraha : PizzaProdej
{
    public PizzaProdejPraha()
    {
        this.factory = new PizzaPrilohaFactoryPraha();
    }

    protected override Pizza VytvorPizzu(string nazev)
    {
        switch (nazev)
        {
            case "Klasik":
                return new PizzaWithFactory(factory) { Nazev = "Prazska Klasik pizza" };
            case "Hawai":
                return new PizzaWithFactory(factory) { Nazev = "Prazska Hawai pizza" };
            case "Syrova":
                return new PizzaWithFactory(factory) { Nazev = "Prazska Syrova pizza" };
            default:
                return null;
        }
    }
}