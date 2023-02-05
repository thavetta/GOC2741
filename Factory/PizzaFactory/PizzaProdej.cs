using PizzaBase;

namespace PizzaFactory;

public abstract class PizzaProdej
{
    public Pizza? ResObjednavku(string nazev)
    {
        Pizza? pizza = VratPizzu(nazev);

        if (pizza == null)
        {
            throw new ArgumentOutOfRangeException("Nepodporovany nazev typu pizzy");
        }

        pizza.Priprava();
        pizza.Peceni();
        pizza.Krajeni();
        pizza.Baleni();

        return pizza;

    }

    protected abstract Pizza? VratPizzu(string nazev);
}