using PizzaBase;

namespace PizzaAbstractFactory;

public class PizzaPrilohaFactoryPraha : IPizzaPrilohaFactory
{
    public Korpus VratKorpus()
    {
        return new TenkyKorpus();
    }

    public Omacka VratOmacku()
    {
        return new SladkaOmacka();
    }

    public Syr VratSyr()
    {
        return new EidamSyr();
    }
}