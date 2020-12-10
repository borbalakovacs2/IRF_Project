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
            switch (comboBox1.SelectedIndex)
            {
                case (int)Tipusok.Pektermek:
                    break;
                case (int)Tipusok.Tejtermek:
                    break;
                case (int)Tipusok.ZoldsegGyumolcs:
                    break;
                case (int)Tipusok.Csomagolt:
                    break;
                case (int)Tipusok.Tisztitoszer:
                    break;


            }

        }
    }
}
