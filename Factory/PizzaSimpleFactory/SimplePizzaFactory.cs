using PizzaBase;

namespace PizzaSimpleFactory;

public class SimplePizzaFactory
{
    public static Pizza? VratPizzu(string nazev)
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