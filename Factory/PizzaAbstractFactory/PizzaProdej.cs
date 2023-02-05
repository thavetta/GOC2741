using PizzaBase;

namespace PizzaAbstractFactory;

public abstract class PizzaProdej
{
    protected IPizzaPrilohaFactory factory;
    public Pizza? ResObjednavku(string nazev)
    {

        Pizza? pizza = VytvorPizzu(nazev); 

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

    protected abstract Pizza? VytvorPizzu(string nazev);
        
}