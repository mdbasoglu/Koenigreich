using System;
namespace Uebung59_Koenigreich_pbbgh20aba
{
    class Finanzamt
    {
        public static int BerechneSteuerEinnahmen(Einwohner[] einwohner)
        {
            int steuereinnahmen = 0;
            for (int i = 0; i < einwohner.Length; i++)
            {
                steuereinnahmen += einwohner[i].Steuer();
            }
            return steuereinnahmen;
        }
    }
}
