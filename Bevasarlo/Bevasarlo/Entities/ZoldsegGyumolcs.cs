using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bevasarlo.Entities
{
    class ZoldsegGyumolcs : Termek
    {
        public ZoldsegGyumolcs(string nev)
        {
            this.Nev = nev;
            if (nev == "Kígyóuborka" || nev == "Citrom" || nev == "Saláta" || nev == "Hagyma" || nev == "Paradicsom")
            {
                this.Mertekegyseg = "db";
            }
            else
            {
                this.Mertekegyseg = "kg";
            }
        }
    }
}
