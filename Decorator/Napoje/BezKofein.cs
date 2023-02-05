using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Napoje
{
    public class BezKofein : Napoj
    {
        public BezKofein()
        {
            Popis = "Kava bez kofeinu 35";
        }

        public override int Cena()
        {
            return 35;
        }
    }
}