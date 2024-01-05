using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Kalkulator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void mODToolStripMenuItem1_Click(object sender, EventArgs e)
        {

        }

        private void Racunaj_Click(object sender, EventArgs e)
        {
            if(ckbCeliBrojevi.Checked)
            {
                int c, d;
                int.TryParse(tb1.Text,out c);
                int.TryParse(tb2.Text,out d);
                lbRezultat.Items.Add(tb1.Text + " mod " + tb2.Text + " = " + c%d);
                return;
            }
            double a;
            double b;
            string s = tb1.Text;
            s = s.Replace(',', '.'); // ispravka: zameni zarez sa tackom u stringu s
            double.TryParse(s, out a);
            s = tb2.Text;
            s = s.Replace(',', '.'); // ispravka: zameni zarez sa tackom u stringu s
            double.TryParse(s, out b);
            double rez = a / b;
            rez = rez % 1;
            rez = rez * b;
            Math.Round(rez, 2);
            lbRezultat.Items.Add(tb1.Text + " mod " + tb2.Text + " = " + rez.ToString());
        }

        private void decBinToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DTB aaa = new DTB();
            DialogResult dlg = aaa.ShowDialog();
        }
    }
}
