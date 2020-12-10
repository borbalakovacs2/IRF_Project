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
            else
            {
                termek.Vegan = false;
            }
            if (cbGluten.Checked == true)
            {
                termek.Glutenmentes = true;
            }
            else
            {
                termek.Glutenmentes = false;
            }
            termek.Egyeb = tbEgyeb.Text;

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
                    cbTermek.DataSource = Termek.zoldsegGyumolcs;
                    break;
                case (int)Tipusok.Csomagolt:
                    cbTermek.DataSource = Termek.csomagolt;
                    break;
                case (int)Tipusok.Tisztitoszer:
                    cbTermek.DataSource = Termek.haztartasi;
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
                    break;
                case (int)Tipusok.Tejtermek:
                    Tejtermek tejtermek = new Tejtermek(cbTermek.Text);
                    termek = tejtermek;
                    break;
                case (int)Tipusok.ZoldsegGyumolcs:
                    ZoldsegGyumolcs zcs = new ZoldsegGyumolcs(cbTermek.Text);
                    termek = zcs;
                    break;
                case (int)Tipusok.Csomagolt:
                    Csomagolt csomagolt = new Csomagolt(cbTermek.Text);
                    termek = csomagolt;
                    break;
                case (int)Tipusok.Tisztitoszer:
                    Haztartasi haztartasi = new Haztartasi(cbTermek.Text);
                    termek = haztartasi;
                    break;
            }

            tbMennyi.Text = termek.Mennyiseg.ToString();
            label6.Text = termek.Mertekegyseg;
        }

        private void btnPlus_Click(object sender, EventArgs e)
        {
            termek.Hozzad();
            tbMennyi.Text = termek.Mennyiseg.ToString();
        }

        private void btnMinus_Click(object sender, EventArgs e)
        {
            termek.Kivon();
            tbMennyi.Text = termek.Mennyiseg.ToString();
        }

        private void checkBox6_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox6.Checked == true)
            {
                for (int i = 0; i < listBoxTermekek.Items.Count; i++)
                {
                    listBoxTermekek.SetItemChecked(i, true);
                }
            }
            else
            {
                for (int i = 0; i < listBoxTermekek.Items.Count; i++)
                {
                    listBoxTermekek.SetItemChecked(i, false);
                }
            }
        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox2.Checked == true)
            {
                checkItems("vegán");

            }

            else
            {
                uncheck();
            }
        }
        private void checkItems(string toCheck)
        {

            for (int i = 0; i < listBoxTermekek.Items.Count; i++)
            {
                string value = listBoxTermekek.Items[i].ToString();
                if (value.Contains(toCheck))
                {
                    listBoxTermekek.SetItemChecked(i, true);
                }
            }
        }
        private void uncheck()
        {

            for (int i = 0; i < listBoxTermekek.Items.Count; i++)
            {
                listBoxTermekek.SetItemChecked(i, false);
            }
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked == true)
            {
                checkItems("gluténmentes");

            }

            else
            {
                uncheck();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //        ???
            //        ???
            //        ???
        }
}
}

