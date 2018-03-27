using System;
using System.Collections.Generic;
using System.Text;

namespace DierenBijDeDierenarts
{
    class Varken : Dier
    {
        public double Gewicht { get; set; }

        public override void MaakGeluid()
        {
            Console.WriteLine("knor knor");
        }

    }
}
