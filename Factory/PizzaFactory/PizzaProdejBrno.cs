using PizzaBase;

namespace PizzaFactory;

public class PizzaProdejBrno : PizzaProdej
{
    protected override Pizza? VratPizzu(string nazev)
    {
        return nazev switch
        {
            "Klasik" => new KlasikPizzaBRQ(),
            "Hawai" => new HawaiiPizzaBRQ(),
            "Syrova" => new SyrovaPizzaBRQ(),
            _ => null
        };
    }
}