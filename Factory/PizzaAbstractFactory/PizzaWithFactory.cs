using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using PizzaBase;

namespace PizzaAbstractFactory
{
    public class PizzaWithFactory : Pizza
    {
        private IPizzaPrilohaFactory factory;
        
        public PizzaWithFactory(IPizzaPrilohaFactory factory)
        {
            this.factory = factory;
        }
        
        public override void Priprava()
        {
            KorpusZaklad = factory.VratKorpus();
            OmackaZaklad = factory.VratOmacku();
            SyrZaklad = factory.VratSyr();

            Console.WriteLine("Pripravuji " + Nazev);
            Console.WriteLine(this.KorpusZaklad.ToString());
            Console.WriteLine(this.OmackaZaklad.ToString());
            Console.WriteLine(this.SyrZaklad.ToString());
        }
    }
}