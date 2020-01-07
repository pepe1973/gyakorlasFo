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
        public Fiu(int mag, int test, string szul, bool szem) : base(mag, test, szul)
        {
            this.szemelyiSzamEgyesE = szem;
        }

        
    }
}
