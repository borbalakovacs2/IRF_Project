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
            switch (nev)
            {
                case "Tej":
                    this.Mertekegyseg = "l";
                    break;
                case "Sajt":
                    this.Mertekegyseg = "dkg";
                    this.Mennyiseg = 25;
                    break;
                default:
                    this.Mertekegyseg = "g";
                    this.Mennyiseg = 100;
                    break;
            }
            this.MennyisegEmelo = this.Mennyiseg;
        }
    }
}
