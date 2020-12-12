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
using Excel = Microsoft.Office.Interop.Excel;
using System.Reflection;

namespace Bevasarlo
{
    public partial class Form1 : Form
    {
        Excel.Application xlApp;
        Excel.Workbook xlWB;
        Excel.Worksheet xlSheet;

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

        private void btnListahoz_Click(object sender, EventArgs e)
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

            Termek newTermek = new Termek();
            termek = newTermek; 
            cbTipus_SelectedIndexChanged(sender, e); //need to trigger so the new object is set
            cbTermek_SelectedIndexChanged(sender, e);
            termek.ListahozAd();
            listBoxTermekek.DataSource = null;
            listBoxTermekek.DataSource = Termek.termekek;
            listBoxTermekek.DisplayMember = "DisplayMember";
            listBoxTermekek.ValueMember = "ID";

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
            Termek termek = new Termek();
            List<Termek> toRemove = new List<Termek>();
            int[] currentSelectedValue = new int[this.listBoxTermekek.CheckedItems.Count];
            for (int i = 0; i < listBoxTermekek.CheckedItems.Count; i++)
            {
                termek = (Termek)listBoxTermekek.CheckedItems[i];
                Console.WriteLine(termek.ID.ToString());
            }
            //for (int i = listBoxTermekek.Items.Count - 1; i >= 0; i--)
            //{
            //    if (listBoxTermekek.GetItemChecked(i))
            //    {
            //        listBoxTermekek.Items.Remove(listBoxTermekek.Items[i]);
            //    }
            //}

        }


        private void btnMentes_Click(object sender, EventArgs e)
        {
            if (listBoxTermekek.CheckedItems.Count == 0)
            {
                MessageBox.Show("Válaszd ki a termékeket!");
                return;
            }

            CreateExcel();

            //List<string> lista = new List<string>();
            //SaveFileDialog sfd = new SaveFileDialog();
            //sfd.InitialDirectory = System.Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
            //sfd.Filter = "Comma Separated Values (*.csv)|*.csv";
            //sfd.FileName = "bevasarlolista.csv";
            //sfd.DefaultExt = "csv";
            //sfd.AddExtension = true;
            //if (sfd.ShowDialog() == DialogResult.OK)
            //{
            //    try
            //    {
            //        foreach (var item in listBoxTermekek.CheckedItems)
            //        {
            //            lista.Add(item.ToString());
            //        }
            //        File.WriteAllLines(sfd.FileName, lista, Encoding.UTF8);
            //        MessageBox.Show("Sikeres mentés");
            //    }
            //    catch (Exception ex)
            //    {
            //        MessageBox.Show("Error: " + ex.Message);
            //    }
            //}
        }
        private void CreateExcel()
        {
            try
            {
                xlApp = new Excel.Application();
                xlWB = xlApp.Workbooks.Add(Missing.Value);
                xlSheet = xlWB.ActiveSheet;
                CreateTable();
                xlApp.Visible = true;
                xlApp.UserControl = true;
            }
            catch (Exception ex)
            {
                string errMsg = string.Format("Error: {0}\nLine: {1}", ex.Message, ex.Source);
                MessageBox.Show(errMsg, "Error");

                xlWB.Close(false, Type.Missing, Type.Missing);
                xlApp.Quit();
                xlWB = null;
                xlApp = null;
            }
        }
        private void CreateTable()
        {
            string[] header = new string[] {
                    "Termék neve",
                    "Mennyiség",
                    "Mértékegység",
                    "Vegán",
                    "Gluténmentes"
                };

            for (int i = 0; i < header.Length; i++)
            {
                xlSheet.Cells[1, i + 1] = header[i];
            }

            object[,] values = new object[listBoxTermekek.CheckedItems.Count, header.Length];
            int counter = 0;
            foreach (var item in Termek.termekek)
            {
                values[counter, 0] = item.Nev;
                values[counter, 1] = item.Mennyiseg.ToString();
                values[counter, 2] = item.Mertekegyseg;
                values[counter, 3] = item.Vegan;
                values[counter, 4] = item.Glutenmentes;
                values[counter, 5] = item.Egyeb;
                counter++;
            }
            xlSheet.get_Range(
                GetCell(2, 1),
                GetCell(1 + values.GetLength(0), values.GetLength(1))).Value2 = values;
        }

        private string GetCell(int x, int y)
        {
            string ExcelCoordinate = "";
            int dividend = y;
            int modulo;

            while (dividend > 0)
            {
                modulo = (dividend - 1) % 26;
                ExcelCoordinate = Convert.ToChar(65 + modulo).ToString() + ExcelCoordinate;
                dividend = (int)((dividend - modulo) / 26);
            }
            ExcelCoordinate += x.ToString();

            return ExcelCoordinate;


        }



        private void btnRecept_Click(object sender, EventArgs e)
        {

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
                                    if (values[3] == "igen" || values[3] == "Igen")
                                    {
                                        termek.Vegan = true;
                                    }
                                    else
                                    {
                                        termek.Vegan = false;
                                    }
                                    if (values[4] == "igen" || values[4] == "Igen")
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

                                    termek.ListahozAd();
                                    listBoxTermekek.DataSource = null;
                                    listBoxTermekek.DataSource = Termek.termekek;
                                    listBoxTermekek.DisplayMember = "DisplayMember";
                                    listBoxTermekek.ValueMember = "ID";
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
        }
    }
}

