using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Napoje
{
    public class Turek : Napoj
    {
        public Turek()
        {
            Popis = "Turek 25";
        }
        public override int Cena()
        {
            return 25;
        }
    }
}