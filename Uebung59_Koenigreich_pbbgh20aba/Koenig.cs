using System;
namespace Uebung59_Koenigreich_pbbgh20aba
{
    class Koenig : Einwohner
    {
        public Koenig(int einkommen) : base(einkommen)
        {
        }

        public override int Steuer()
        {
            return 0;
        }

        public override string ToString()
        {
            return $"Koenig [einkommen={Einkommen}; zuVersteurendesEinkommen={ZuVersteuerndesEinkommen()}, steuer={Steuer()}]";
        }
    }
}
