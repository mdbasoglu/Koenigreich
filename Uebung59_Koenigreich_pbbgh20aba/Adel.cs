using System;
namespace Uebung59_Koenigreich_pbbgh20aba
{
    class Adel : Einwohner
    {
        public Adel(int einkommen) : base(einkommen)
        {
        }

        public override int Steuer()
        {
            int steuern = base.Steuer();

            if (steuern < 20)
            {
                return 20;
            }
            return steuern;
        }

        public override string ToString()
        {
            return $"Adel[ Einkommen={Einkommen:N}; zuVersteuerendesEinkommen={ZuVersteuerndesEinkommen():N}; steuer={Steuer():N}]";
        }
    }
}
