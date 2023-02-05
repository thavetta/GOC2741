using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Napoje
{
    public class Mleko : NapojDekorator
    {
        public Mleko(Napoj zaklad)
        {
            this.Zaklad = zaklad;
            Popis = "Mleko 5";
        }
        public override int Cena()
        {
            return 5 + Zaklad.Cena();
        }
    }
}