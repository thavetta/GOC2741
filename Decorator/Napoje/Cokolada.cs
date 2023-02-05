using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Napoje
{
    public class Cokolada : NapojDekorator
    {
        public Cokolada(Napoj zaklad)
        {
            this.Zaklad = zaklad;
            Popis = "Cokolada 7";
        }
        public override int Cena()
        {
            return 7 + Zaklad.Cena();
        }
    }
}