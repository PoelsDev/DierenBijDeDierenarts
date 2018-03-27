using System;

namespace DierenBijDeDierenarts
{
    class Program
    {
        static void Main(string[] args)
        {
            Dier p = new Paard();
            Dier v = new Varken();
            Dier k = new Koe();

            p.Gewicht = 102.2;
            p.MaakGeluid();
            Console.WriteLine(p.Gewicht);

            v.Gewicht = 67.3;
            v.MaakGeluid();
            Console.WriteLine(v.Gewicht);
        }
    }
}
