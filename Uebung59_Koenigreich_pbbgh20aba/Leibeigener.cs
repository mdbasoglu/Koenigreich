using System;
namespace Uebung59_Koenigreich_pbbgh20aba
{
    class Leibeigener : Bauer
    {
        public Leibeigener(int einkommen) : base(einkommen)
        {
        }


        public override int ZuVersteuerndesEinkommen()
        {
            if (Einkommen < 12)
            {
                return 0;
            }

            return Einkommen - 12;
        }


        public override string ToString()
        {
            return $"Leibeigener [ Einkommen={Einkommen:N}; zuVersteuerendesEinkommen={ZuVersteuerndesEinkommen():N}; steuer={Steuer():N}]";
        }
    }
}
