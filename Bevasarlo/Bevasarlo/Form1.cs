using Bevasarlo.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bevasarlo
{
    public partial class Form1 : Form
    {
        Termek termek = new Termek();
        List<string> recept = new List<string>();

        public Form1()
        {
            InitializeComponent();
            var tipusok = new[] { "Péktermék",
                                  "Tejtermék",
                                  "Zöldség, gyümölcs",
                                  "Csomagolt élelmiszer",
                                  "Tisztítószer, háztartási kellék"};

            cbTipus.DataSource = tipusok;

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

        private void cbTipus_SelectedIndexChanged(object sender, EventArgs e)
        {
            cbGluten.Checked = false;
            cbVegan.Checked = false;
            tbEgyeb.Text = "";
            switch (cbTipus.SelectedIndex)
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
            switch (cbTipus.SelectedIndex)
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

        private void cbMind_CheckedChanged(object sender, EventArgs e)
        {
            if (cbMind.Checked == true)
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

        private void cbVeganSelect_CheckedChanged(object sender, EventArgs e)
        {
            if (cbVeganSelect.Checked == true)
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

        private void cbGlutenSelect_CheckedChanged(object sender, EventArgs e)
        {
            if (cbGlutenSelect.Checked == true)
            {
                checkItems("gluténmentes");

            }

            else
            {
                uncheck();
            }
        }

        private void btnTorles_Click(object sender, EventArgs e)
        {
            for (int i = listBoxTermekek.Items.Count - 1; i >= 0; i--)
            {
                if (listBoxTermekek.GetItemChecked(i))
                {
                    listBoxTermekek.Items.Remove(listBoxTermekek.Items[i]);
                }
            }

        }

        private void button3_Click(object sender, EventArgs e)
        {
            var documentPath = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.InitialDirectory = documentPath;
            ofd.Filter = "csv files (*.csv)|*.csv|All files (*.*)|*.*";

            if (ofd.ShowDialog() == DialogResult.OK)
            {
                var filePath = ofd.FileName;
                var fileStream = ofd.OpenFile();
                using (StreamReader reader = new StreamReader(fileStream))
                {
                    int index = 0;
                    while (!reader.EndOfStream)
                    {

                        try
                        {
                            var line = reader.ReadLine();
                            if (index != 0)
                            {
                                string[] values = line.Split(',');
                                termek.Nev = values[0];
                                termek.Mennyiseg = int.Parse(values[1]);
                                termek.Mertekegyseg = values[2];
                                if (values[3] == "igen")
                                {
                                    termek.Vegan = true;
                                }
                                else
                                {
                                    termek.Vegan = false;
                                }
                                if (values[4] == "igen")
                                {
                                    termek.Glutenmentes = true;
                                }
                                else
                                {
                                    termek.Glutenmentes = false;
                                }
                                if (values[5] != null)
                                {
                                    termek.Egyeb = values[5];
                                }
                                else
                                {
                                    termek.Egyeb = "";
                                }
                                Termek.termekek.Add(termek);
                                listBoxTermekek.Items.Add(termek.ListahozAd());
                            }
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show(ex.ToString());
                        }
                        index++;
                    }
                }

            }
            
        }

        private void btnMentes_Click(object sender, EventArgs e)
        {
            if (listBoxTermekek.CheckedItems.Count == 0)
            {
                MessageBox.Show("Válaszd ki a termékeket!");
                return;
            }
            List<string> lista = new List<string>();
            SaveFileDialog sfd = new SaveFileDialog();
            sfd.InitialDirectory = System.Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
            sfd.Filter = "Comma Separated Values (*.csv)|*.csv";
            sfd.FileName = "bevasarlolista.csv";
            sfd.DefaultExt = "csv";
            sfd.AddExtension = true;
            if (sfd.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    foreach (var item in listBoxTermekek.CheckedItems)
                    {
                        lista.Add(item.ToString());
                    }
                    File.WriteAllLines(sfd.FileName, lista, Encoding.UTF8);
                    MessageBox.Show("Sikeres mentés");
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Hiba :" + ex.Message);
                }
            }
        }
    }
}

