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
        public static string[] haztartasi = { "Mosópor", "Öblítő", "WC papír", "Tisztítószer", "Papírzsebkendő" };
        public static List<Termek> termekek = new List<Termek>();

        public int ID { get; set; }
        public string Nev { get; set; }
        public int Mennyiseg { get; set; }
        public string Mertekegyseg { get; set; }
        public int MennyisegEmelo { get; set; }
        public bool Vegan { get; set; }
        public bool Glutenmentes { get; set; }
        public string Egyeb { get; set; }
        public string DisplayMember { get; set; }

        public void Hozzad()
        {
            this.Mennyiseg += this.MennyisegEmelo;
        }
        public void Kivon()
        {
            this.Mennyiseg -= this.MennyisegEmelo;
        }
        public void ListahozAd()
        {
            string mennyiseg;
            if (this.Mennyiseg == 0)
            {
                mennyiseg = "";
            }
            else
            {
                mennyiseg = ", " + this.Mennyiseg.ToString() + " ";
            }

            this.ID = termekek.Count;
            string elem = this.Nev + mennyiseg + this.Mertekegyseg;
            if (this.Vegan == true)
            {
                elem = elem + ", vegán";
            }
            if (this.Glutenmentes == true)
            {
                elem = elem + ", gluténmentes";
            }
            if (this.Egyeb != null && this.Egyeb != "")
            {
                elem = elem + ", " + this.Egyeb;
            }
            this.DisplayMember = elem;
            termekek.Add(this);

        }
    }
}

