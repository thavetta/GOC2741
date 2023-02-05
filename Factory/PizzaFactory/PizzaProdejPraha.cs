using PizzaBase;

namespace PizzaFactory;

public class PizzaProdejPraha : PizzaProdej
{
    protected override Pizza? VratPizzu(string nazev)
    {
        return nazev switch
        {
            "Klasik" => new KlasikPizza(),
            "Hawai" => new HawaiiPizza(),
            "Syrova" => new SyrovaPizza(),
            _ => null
        };
    }
}