using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bevasarlo.Entities
{
    class Tejtermek : Termek 
    {
        public Tejtermek(string nev)
        {
            this.Nev = nev;
            if (nev == "Tej")
            {
                this.Mertekegyseg = "l";
                this.Mennyiseg = 1;
            }
            else
            {
                this.Mertekegyseg = "g";
                this.Mennyiseg = 100;
            }
            this.MennyisegEmelo = this.Mennyiseg;
        }
    }
}
