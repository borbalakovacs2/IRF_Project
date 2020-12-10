using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bevasarlo.Entities
{
    class Haztartasi : Termek
    {
        public Haztartasi(string nev)
        {
            this.Nev = nev;
            this.Mertekegyseg = "csomag";
        }
    }
}
