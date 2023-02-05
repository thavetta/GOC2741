namespace PizzaBase;

public abstract class Syr
{
}

public class EidamSyr : Syr
{
    public override string ToString()
    {
        return "Syr Eidam";
    }
}

public class MozarellaSyr : Syr
{
    public override string ToString()
    {
        return "Syr Mozarella";
    }
}