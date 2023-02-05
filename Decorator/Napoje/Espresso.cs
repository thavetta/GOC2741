using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Napoje
{
    public class Espresso : Napoj
    {
        public Espresso()
        {
            Popis = "Espresso 45";
        }
        public override int Cena()
        {
            return 45;
        }
    }
}