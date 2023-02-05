using PizzaBase;

namespace PizzaSimpleFactory;

class PizzaProdej
{
    public Pizza? ResObjednavku(string nazev)
    {
        Pizza? pizza = SimplePizzaFactory.VratPizzu(nazev);

        if (pizza is null)
        {
            throw new ArgumentOutOfRangeException("Nepodporovany nazev typu pizzy");
        }

        pizza.Priprava();
        pizza.Peceni();
        pizza.Krajeni();
        pizza.Baleni();

        return pizza;

    }
}