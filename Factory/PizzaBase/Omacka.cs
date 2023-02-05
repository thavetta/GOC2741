namespace PizzaBase;

public abstract class Omacka
{
}

public class OstraOmacka : Omacka
{
    public override string ToString()
    {
        return "Ostra omacka";
    }
}

public class SladkaOmacka : Omacka
{
    public override string ToString()
    {
        return "Sladka omacka";
    }
}