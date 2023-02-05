using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Napoje
{
    public class Soja : NapojDekorator
    {
        public Soja(Napoj zaklad)
        {
            this.Zaklad = zaklad;
            Popis = "Soja 5";
        }
        public override int Cena()
        {
            return 5 + Zaklad.Cena();
        }
    }
}