using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Napoje
{
    public abstract class NapojDekorator : Napoj
    {
        protected Napoj Zaklad { get; set; }
    }
}