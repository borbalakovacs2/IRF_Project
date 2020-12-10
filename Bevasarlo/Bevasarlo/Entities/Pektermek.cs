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
            if (nev == "Kenyér")
            {
                this.Mertekegyseg = "kg";
            }
            else
            {
                this.Mertekegyseg = "db";
            }
        }
    }
}
