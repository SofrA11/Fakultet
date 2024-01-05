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
using System.Xml.Serialization;

namespace Minesweeper
{
    public partial class MineSweeper : Form
    {
        static int brojVrsta = 9;
        static int brojKolona = 9;
        static int brojMina = 10;
        static int velicinaDugmeta = 25;
        Button[,] _matrica;
        public MineSweeper()
        {
            InitializeComponent();
            btnPokreni.Height = 50;
            btnPokreni.Width = 50;
            btnPokreni.Left= (this.ClientSize.Width - 50) / 2;
            btnPokreni.Top = (ClientSize.Height-(ClientSize.Height- brojVrsta*velicinaDugmeta))/2;
            flpPodloga.Left= (this.ClientSize.Width - velicinaDugmeta * brojKolona) / 2;
        }

        private void MineSweeper_Load(object sender, EventArgs e)
        {
        }  
        Button btn(int i,int j)
        {
            Button b = new Button();
            b.Name = $"btn{i}_{j}";
            b.Text = "";
            b.BackColor = Color.White;
            b.Width = 25;
            b.Height = 25;
            b.FlatStyle = FlatStyle.Flat;
            b.Margin = new Padding(0);
            b.Click += b_Click;
            return b;
        }

        void b_Click(object sender,EventArgs e)
        {
            Button b = (Button)sender;
            string[] btnName = b.Name.Split('_');
            int row = int.Parse(btnName[0].Substring(3));
            int col = int.Parse(btnName[1]);
        }
        
        private void naprednoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            NaprednaPodesavanja np = new NaprednaPodesavanja();
            DialogResult dialogResult = np.ShowDialog();
            if (dialogResult == DialogResult.OK)
            {
                List<String> list = new List<String>();
                list = np.GetPodesavanja();
                brojVrsta = int.Parse(list[0]);
                brojKolona = int.Parse(list[1]);
                brojMina = int.Parse(list[2]);
                if (brojMina >= brojKolona * brojVrsta)
                    MessageBox.Show("Broj mina mora biti manji od ukuppnog broja polja" + brojKolona * brojVrsta,
                                "Obavestenje",
                                 MessageBoxButtons.OK,
                                 MessageBoxIcon.Error);
            }

        }

        private void MineSweeper_Shown(object sender, EventArgs e)
        {
            this.ActiveControl = null;
        }

        private void btnPokreni_Click_1(object sender, EventArgs e)
        {
            _matrica = new Button[brojVrsta, brojKolona]; // Inicijalizacija matrice _matricai
            flpPodloga.Controls.Clear();
            flpPodloga.Height = velicinaDugmeta * brojVrsta;
            flpPodloga.Width = velicinaDugmeta * brojKolona;
            this.Width = velicinaDugmeta * brojKolona + 100;
            this.Height = velicinaDugmeta * brojVrsta + 100;
            btnPokreni.Height = 50;
            btnPokreni.Width = 50;
            btnPokreni.Left = (this.ClientSize.Width - 50) / 2;         
            flpPodloga.Left = (this.ClientSize.Width - velicinaDugmeta * brojKolona) / 2;      
            for (int i = 0; i < brojVrsta; i++)
            {
                for (int j = 0; j < brojKolona; j++)
                {
                    _matrica[i, j] = btn(i, j); // Kreiranje dugmeta i postavljanje u matricu
                    _matrica[i, j].Click += b_Click;
                    flpPodloga.Controls.Add(_matrica[i, j]); // Dodavanje dugmeta u FlowLayoutPanel
                }
            }
        }

        private void flpPodloga_Paint(object sender, PaintEventArgs e)
        {

        }
    }

}
