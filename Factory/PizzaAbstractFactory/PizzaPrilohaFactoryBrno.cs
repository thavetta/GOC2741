using PizzaBase;

namespace PizzaAbstractFactory;

public class PizzaPrilohaFactoryBrno : IPizzaPrilohaFactory
{
    public Korpus VratKorpus()
    {
        return new TlustyKorpus();
    }

    public Omacka VratOmacku()
    {
        return new OstraOmacka();
    }

    public Syr VratSyr()
    {
        return new MozarellaSyr();
    }
}