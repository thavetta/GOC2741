using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Napoje
{
    public class Slehacka : NapojDekorator
    {
        public Slehacka(Napoj zaklad)
        {
            this.Zaklad = zaklad;
            Popis = "Slehacka 10";
        }
        public override int Cena()
        {
            return 10 + Zaklad.Cena();
        }
    }
}