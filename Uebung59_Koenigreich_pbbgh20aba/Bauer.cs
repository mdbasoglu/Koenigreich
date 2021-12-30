using System;
namespace Uebung59_Koenigreich_pbbgh20aba
{
    class Bauer : Einwohner
    {
        public Bauer(int einkommen) : base(einkommen)
        {
        }

        public override int Steuer()
        {
            int steuern = base.Steuer();
            if (base.Steuer() < 12)
            {
                return 0;
            }
            return steuern;
        }

        public override string ToString()
        {
            return $"Bauer [einkommen={Einkommen}; zuVersteurendesEinkommen={ZuVersteuerndesEinkommen()}, steuer={Steuer()}]";
        }
    }
}
