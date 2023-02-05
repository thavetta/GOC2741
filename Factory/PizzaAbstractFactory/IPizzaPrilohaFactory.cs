using PizzaBase;

namespace PizzaAbstractFactory;

public interface IPizzaPrilohaFactory
{
    Korpus VratKorpus();

    Syr VratSyr();

    Omacka VratOmacku();
}