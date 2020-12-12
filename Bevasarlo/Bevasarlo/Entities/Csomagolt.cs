using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bevasarlo.Entities
{
    class Csomagolt : Termek
    {
        public Csomagolt(string nev)
        {

            this.Mennyiseg = 1;
            this.Nev = nev;
            if (nev == "Tojás" || nev == "Sör")
            {
                this.Mertekegyseg = "doboz";
            }
            else if (nev == "Csokoládé")
            {
                this.Mertekegyseg = "tábla";
            }
            else
            {
                this.Mertekegyseg = "csomag";
            }
        }
    }
}
