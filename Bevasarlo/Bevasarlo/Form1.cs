using Bevasarlo.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bevasarlo
{
    public partial class Form1 : Form
    {
        Termek termek = new Termek();


        public Form1()
        {
            InitializeComponent();
            var tipusok = new[] { "Péktermék",
                                  "Tejtermék",
                                  "Zöldség, gyümölcs",
                                  "Csomagolt élelmiszer",
                                  "Tisztítószer, háztartási kellék"};

            comboBox1.DataSource = tipusok;
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (cbVegan.Checked == true)
            {
                termek.Vegan = true;
            }
            if (cbGluten.Checked == true)
            {
                termek.Glutenmentes = true;
            }
            if (tbEgyeb != null)
            {
                termek.Egyeb = tbEgyeb.Text;
            }

            Termek.termekek.Add(termek);
            var elem = termek.ListahozAd();
            listBoxTermekek.Items.Add(elem);

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            cbGluten.Checked = false;
            cbVegan.Checked = false;
            tbEgyeb.Text = "";
            switch (comboBox1.SelectedIndex)
            {
                case (int)Tipusok.Pektermek:
                    cbTermek.DataSource = Termek.pektermekek;
                    break;
                case (int)Tipusok.Tejtermek:
                    cbTermek.DataSource = Termek.tejtermekek;
                    break;
                case (int)Tipusok.ZoldsegGyumolcs:
                    break;
                case (int)Tipusok.Csomagolt:
                    break;
                case (int)Tipusok.Tisztitoszer:
                    break;
            }
        }

        private void cbTermek_SelectedIndexChanged(object sender, EventArgs e)
        {
            //Termek termek = new Termek();
            switch (comboBox1.SelectedIndex)
            {
                case (int)Tipusok.Pektermek:
                    Pektermek pektermek = new Pektermek(cbTermek.Text);
                    termek = pektermek;
                    cbTermek.DataSource = Termek.pektermekek;
                    break;
                case (int)Tipusok.Tejtermek:
                    Tejtermek tejtermek = new Tejtermek(cbTermek.Text);
                    termek = tejtermek;
                    cbTermek.DataSource = Termek.tejtermekek;
                    break;
                case (int)Tipusok.ZoldsegGyumolcs:
                    ZoldsegGyumolcs zcs = new ZoldsegGyumolcs(cbTermek.Text);
                    termek = zcs;
                    cbTermek.DataSource = Termek.zoldsegGyumolcs;
                    break;
                case (int)Tipusok.Csomagolt:
                    break;
                case (int)Tipusok.Tisztitoszer:
                    break;
            }

            tbMennyi.Text = termek.Mennyiseg.ToString();
            label6.Text = termek.Mertekegyseg;
        }

        private void btnPlus_Click(object sender, EventArgs e)
        {
            termek.Hozzad();
        }

        private void btnMinus_Click(object sender, EventArgs e)
        {
            termek.Kivon();
        }
    }
}
