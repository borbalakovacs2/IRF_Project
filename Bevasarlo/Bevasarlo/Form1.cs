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

        string[] header = new string[] {
                    "Termék neve",
                    "Mennyiség",
                    "Mértékegység",
                    "Vegán",
                    "Gluténmentes",
                    "Egyéb"};

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
            Termek newTermek = new Termek();
            termek = newTermek;
            cbTermek_SelectedIndexChanged(sender, e);  //need to trigger so the new object is set
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


            termek.ListahozAd();
            RefreshData();

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
            //Termek termek = new Termek();
            List<Termek> toRemove = new List<Termek>();
            int[] currentSelectedValue = new int[this.listBoxTermekek.CheckedItems.Count];
            for (int i = 0; i < listBoxTermekek.CheckedItems.Count; i++)
            {
                termek = (Termek)listBoxTermekek.CheckedItems[i];
                Termek.termekek.RemoveAt(termek.ID);
                for (int j = 0; j < Termek.termekek.Count; j++)
                {
                    Termek.termekek[j].ID = j;
                }
            }
            RefreshData();
        }


        private void btnMentes_Click(object sender, EventArgs e)
        {
            if (Termek.termekek.Count == 0)
            {
                MessageBox.Show("Adj hozzá termékeket!");
            }
            else
            {
                CreateExcel();
                CreateTable();
                FormatTable();
            }

        }
        private void CreateExcel()
        {
            try
            {
                xlApp = new Excel.Application();
                xlWB = xlApp.Workbooks.Add(Missing.Value);
                xlSheet = xlWB.ActiveSheet;
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


            for (int i = 0; i < header.Length; i++)
            {
                xlSheet.Cells[1, i + 1] = header[i];
            }

            object[,] values = new object[Termek.termekek.Count, header.Length];
            int counter = 0;
            foreach (var item in Termek.termekek)
            {
                values[counter, 0] = item.Nev;
                values[counter, 1] = item.Mennyiseg.ToString();
                values[counter, 2] = item.Mertekegyseg;
                if (item.Vegan == true)
                {
                    values[counter, 3] = "Igen";
                }
                else
                {
                    values[counter, 3] = "Nem";
                }
                if (item.Vegan == true)
                {
                    values[counter, 4] = "Igen";
                }
                else
                {
                    values[counter, 4] = "Nem";
                }
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
        private void FormatTable()
        {
            Excel.Range headerRange = xlSheet.get_Range(GetCell(1, 1), GetCell(1, header.Length));
            headerRange.Font.Bold = true;
            headerRange.VerticalAlignment = Excel.XlVAlign.xlVAlignCenter;
            headerRange.HorizontalAlignment = Excel.XlHAlign.xlHAlignCenter;
            headerRange.EntireColumn.AutoFit();
            headerRange.RowHeight = 40;
            headerRange.Interior.Color = Color.LightSalmon;
            headerRange.BorderAround2(Excel.XlLineStyle.xlContinuous, Excel.XlBorderWeight.xlThick);

            int lastRowID = xlSheet.UsedRange.Rows.Count;
            int lastColumnID = xlSheet.UsedRange.Columns.Count;
            Excel.Range dataRange = xlSheet.get_Range(GetCell(2, 1), GetCell(lastRowID, lastColumnID));
            dataRange.Cells.Borders.LineStyle = Excel.XlLineStyle.xlContinuous;
            dataRange.BorderAround2(Excel.XlLineStyle.xlContinuous);

            Excel.Range firstColumn = xlSheet.get_Range(GetCell(2, 1), GetCell(lastRowID, 1));
            firstColumn.Font.Bold = true;
            firstColumn.Interior.Color = Color.LightBlue;
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

                            Termek newTermek = new Termek();
                            termek = newTermek;

                            try
                            {
                                var line = reader.ReadLine();
                                if (index != 0)
                                {
                                    string[] values = line.Split(',');
                                    newTermek.Nev = values[0];
                                    if (values[1] != "")
                                    {
                                        newTermek.Mennyiseg = int.Parse(values[1]);
                                    }
                                    newTermek.Mertekegyseg = values[2];
                                    if (values[3] == "igen" || values[3] == "Igen")
                                    {
                                        newTermek.Vegan = true;
                                    }
                                    else
                                    {
                                        newTermek.Vegan = false;
                                    }
                                    if (values[4] == "igen" || values[4] == "Igen")
                                    {
                                        newTermek.Glutenmentes = true;
                                    }
                                    else
                                    {
                                        newTermek.Glutenmentes = false;
                                    }
                                    if (values[5] != null)
                                    {
                                        newTermek.Egyeb = values[5];
                                    }
                                    else
                                    {
                                        newTermek.Egyeb = "";
                                    }

                                    termek = newTermek;
                                    termek.ListahozAd();
                                    RefreshData();
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

        private void RefreshData()
        {
            listBoxTermekek.DataSource = null;
            listBoxTermekek.DataSource = Termek.termekek;
            listBoxTermekek.DisplayMember = "DisplayMember";
            listBoxTermekek.ValueMember = "ID";
        }
    }
}

