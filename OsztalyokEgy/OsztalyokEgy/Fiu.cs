using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OsztalyokEgy
{
    class Fiu : Ember
    {
        private bool szemelyiSzamEgyesE;

        public bool SzemelyiSzamEgyesE
        {
            get { return szemelyiSzamEgyesE; }
            set { this.szemelyiSzamEgyesE = value; }
        }

        public Fiu(int magassag, int testsuly, string szuletesiEv, bool szem) : base(magassag, testsuly, szuletesiEv)
        {
            this.szemelyiSzamEgyesE = szem;
        } 
    }
}
