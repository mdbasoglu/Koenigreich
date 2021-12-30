using System;

namespace Uebung59_Koenigreich_pbbgh20aba
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            Koenig koenig = new Koenig(1000000);
            Adel adel = new Adel(30000);
            Adel adeliger = new Adel(150);
            Bauer bauer = new Bauer(2000);
            Leibeigener l1 = new Leibeigener(150);
            Leibeigener l2 = new Leibeigener(5);

            Einwohner[] einwohner = { koenig, adel, adeliger, bauer, l1, l2 };
            Finanzamt finanzamt = new Finanzamt(einwohner);

            Console.WriteLine(einwohner);
            Console.WriteLine(koenig);
            Console.WriteLine(adel);
            Console.WriteLine(adeliger);
            Console.WriteLine(bauer);
            Console.WriteLine(l1);
            Console.WriteLine(l2);
            Console.WriteLine("Steuereinnahmen-> " + Finanzamt.BerechneSteuerEinnahmen(einwohner) + "Taler");





            Koenig k = new Koenig(1000000);
            Adel aReich = new Adel(30000);
            Adel bReich = new Adel(150);
            Bauer b = new Bauer(2000);

        }
    }
}
