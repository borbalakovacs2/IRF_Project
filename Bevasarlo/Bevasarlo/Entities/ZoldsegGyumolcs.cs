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
            switch (nev)
            {
                case "Kígyóuborka":
                    this.Mertekegyseg = "db";
                    break;
                case "Citrom":
                    this.Mertekegyseg = "db";
                    break;
                case "Saláta":
                    this.Mertekegyseg = "db";
                    break;
                case "Hagyma":
                    this.Mertekegyseg = "db";
                    break;
                default:
                    this.Mertekegyseg = "kg";
                    break;
            }
            this.MennyisegEmelo = this.Mennyiseg;
        }
    }
}
