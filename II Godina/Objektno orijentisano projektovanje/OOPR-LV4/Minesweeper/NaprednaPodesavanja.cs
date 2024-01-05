using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Minesweeper
{
    public partial class NaprednaPodesavanja : Form
    {
        public NaprednaPodesavanja()
        {
            InitializeComponent();
            PovratnaVrednost = new List<String>();
        }
        List<String> PovratnaVrednost;
        public List<String> GetPodesavanja()
        {

            PovratnaVrednost.Insert(0,nudVrsta.Value.ToString());
            PovratnaVrednost.Insert(1,nudKolona.Value.ToString());
            PovratnaVrednost.Insert(2,nudMina.Value.ToString());
           return PovratnaVrednost;
        }
        private void NaprednaPodesavanja_Load(object sender, EventArgs e)
        {

        }

        private void btnUnesi_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.OK;
            Close();
        }

        private void btnPonisti_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void nudMina_ValueChanged(object sender, EventArgs e)
        {
            if(nudMina.Value >= nudVrsta.Value*nudKolona.Value)
            {
                MessageBox.Show("Unet broj mina mora biti manji od: "+(nudVrsta.Value * nudKolona.Value),
                               "Obavestenje",
                               MessageBoxButtons.OK,
                               MessageBoxIcon.Error);
                nudMina.Value = nudVrsta.Value * nudKolona.Value - 1;
            }
        }

        private void nudVrsta_ValueChanged(object sender, EventArgs e)
        {

        }
    }
}
