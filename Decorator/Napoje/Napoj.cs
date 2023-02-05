using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Napoje
{
    public abstract class Napoj
    {
        public string Popis { get; protected set; }

        public abstract int Cena();
    }
}