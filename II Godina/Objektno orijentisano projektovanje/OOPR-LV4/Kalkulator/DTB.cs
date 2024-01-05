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
    public partial class DTB : Form
    {
        List<String> list = new List<String>();

        public DTB()
        {
            InitializeComponent();
            list.Add("Dekadni");
            list.Add("Binarni");
            list.Add("Heksadekadni");
            list.Add("Oktalni");
        }

        private void DTB_Load(object sender, EventArgs e)
        {

        }

        private void cmb1_SelectedValueChanged(object sender, EventArgs e)
        {
           
          String s=cmb1.SelectedItem.ToString();
          cmb2.Items.Clear();
          foreach(String pom in list)
            {
                if(!pom.Equals(s))
                {
                    cmb2.Items.Add(pom);
                }
            }
        }

        private void cmb2_SelectedIndexChanged(object sender, EventArgs e)
        {
            String s = cmb2.SelectedItem.ToString();
            cmb1.Items.Clear();
            foreach (String pom in list)
            {
                if (!pom.Equals(s))
                {
                    cmb1.Items.Add(pom);
                }
            }
        }

        private void tb1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (cmb1.SelectedItem.ToString() == "Binarni")
            {
                if (e.KeyChar != '0' && e.KeyChar!='1')
                {
                    e.Handled = true;
                }
            }
        }
    }
}
