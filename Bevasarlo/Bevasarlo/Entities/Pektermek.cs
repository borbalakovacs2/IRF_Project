using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bevasarlo.Entities
{
    class Pektermek : Termek
    {
        public Pektermek(string nev)
        {
            this.Nev = nev;
            switch (nev)
            {
                case "Kenyér":
                    this.Mertekegyseg = "kg";
                    break;
                default:
                    this.Mertekegyseg = "db";
                    break;
            }
            this.MennyisegEmelo = this.Mennyiseg;
        }
    }
}
