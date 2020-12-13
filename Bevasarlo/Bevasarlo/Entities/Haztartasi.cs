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
            this.Mennyiseg = 1;
            this.Mertekegyseg = "csomag";
            this.MennyisegEmelo = this.Mennyiseg;
        }
    }
}
