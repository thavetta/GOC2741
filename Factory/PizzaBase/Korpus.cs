namespace PizzaBase;

public abstract class Korpus
{

}

public class TenkyKorpus : Korpus
{
    public override string ToString()
    {
        return "Tenky korpus";
    }
}

public class TlustyKorpus : Korpus
{
    public override string ToString()
    {
        return "Tlusty korpus";
    }
}