using System;
namespace Uebung59_Koenigreich_pbbgh20aba
{
    class Einwohner
    {
        private int einkommen;
        public int Einkommen
        {
            get => einkommen;
            set => einkommen = value;
        }

        public Einwohner(int einkommen)
        {
            Einkommen = einkommen;
        }

        public virtual int ZuVersteuerndesEinkommen()
        {
            return Einkommen;
        }

        public virtual int Steuer()
        {
            int steuern = ZuVersteuerndesEinkommen() / 10;
            if (steuern < 1)
            {
                steuern = 1;
            }
            return steuern;
        }

        public override string ToString()
        {
            return $" [einkommen={Einkommen}; zuVersteurendesEinkommen={ZuVersteuerndesEinkommen()}, steuer={Steuer()}]";
        }
    }
}
