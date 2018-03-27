using System;
using System.Collections.Generic;
using System.Text;

namespace DierenBijDeDierenarts
{
    abstract class Dier
    {
        public double Gewicht { get; set; }

        public abstract void MaakGeluid();        
    }
}
