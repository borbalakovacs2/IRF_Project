using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bevasarlo
{


    class Termek
    {
        public static string[] zoldsegGyumolcs = { "Paradicsom", "Kígyóuborka", "Saláta", "Burgonya", "Hagyma", "Alma", "Banán", "Körte", "Citrom", "Narancs" };
        public static string[] tejtermekek = { "Tej", "Sajt", "Joghurt", "Tejföl", "Vaj" };
        public static string[] pektermekek = { "Kenyér", "Zsemle", "Kifli", "Pogácsa", "Kakaós csiga" };
        public static string[] csomagolt = { "Sonka", "Tojás", "Sör", "Nógrádi ropi", "Fagyasztott zöldség", "Csokoládé" };
        public static string[] haztartasi = { "Mosópor", "Öblítő", "WC papír", "Tisztítószer", "Papírzsebkendő"};
        public static List<Termek> termekek = new List<Termek>();

        public string Nev { get; set; }
        public int Mennyiseg { get; set; }
        public string Mertekegyseg { get; set; }
        public int MennyisegEmelo { get; set; }
        public bool Vegan { get; set; }
        public bool Glutenmentes { get; set; }
        public string Egyeb { get; set; }

        public Termek()
        {
            this.Mennyiseg = 1;
            this.MennyisegEmelo = this.Mennyiseg;
        }

        public void Hozzad()
        {
            this.Mennyiseg += this.MennyisegEmelo;
        }
        public void Kivon()
        {
            this.Mennyiseg -= this.MennyisegEmelo;
        }
        public string ListahozAd()
        {
                string elem = this.Nev + ' ' + this.Mennyiseg + ' ' + this.Mertekegyseg;
                if (this.Vegan == true)
                {
                    elem = elem + ", vegán";
                }
                if (this.Glutenmentes == true)
                {
                    elem = elem + ", gluténmentes";
                }
                if (this.Egyeb != "")
                {
                    elem = elem + ", " + this.Egyeb;
                }
            return elem;
        }
    }
}

