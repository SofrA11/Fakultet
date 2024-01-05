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

namespace SeparatorDupliranihSlika
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnUnos_Click(object sender, EventArgs e)
        {
            /*
            string pthFolder1 = @"C:\Users\Mihajlo\Desktop\TEST SLIKE\Folder1";
            string pthFolder2 = @"C:\Users\Mihajlo\Desktop\TEST SLIKE\Folder2";
            */
            string pthFolder1 = @tbPrviFolder.Text;
            string pthFolder2 = @tbDrugiFolder.Text;
            string pthFolderDuplikat = @tbDest.Text;
            string pthFolderUnikat=@tbDest.Text;
            pthFolderDuplikat =pthFolderDuplikat+ @"\Razdvojene Slike";
            Directory.CreateDirectory(pthFolderDuplikat);
            pthFolderUnikat = pthFolderDuplikat;

            pthFolderDuplikat =pthFolderDuplikat+ @"\Duplikat";//@"C:\Users\Mihajlo\Desktop\TEST SLIKE\Duplikat";

            pthFolderUnikat = pthFolderUnikat + @"\Unikat";//@"C:\Users\Mihajlo\Desktop\TEST SLIKE\Unikat";

            // Kreiranje foldera za "duplikat" slike ako ne postoji
            Directory.CreateDirectory(pthFolderDuplikat);

            // Kreiranje foldera za "unikat" slike ako ne postoji
            Directory.CreateDirectory(pthFolderUnikat);

            // Učitavanje svih slika iz prvog foldera

            ListaSlika listaFolder1= new ListaSlika();
            listaFolder1.UcitajSlikeIzDirektorijuma(pthFolder1);
            ListaSlika listaFoledr2 = new ListaSlika();
            listaFoledr2.UcitajSlikeIzDirektorijuma(pthFolder2);

            listaFolder1.odrediDuplikate(listaFoledr2);
            listaFoledr2.odrediDuplikate(listaFolder1);

            listaFolder1.Izvezi(pthFolderDuplikat, pthFolderUnikat);
            listaFoledr2.Izvezi(pthFolderDuplikat, pthFolderUnikat);

           // Izvezi(listaFolder1, pthFolderDuplikat, pthFolderUnikat);
           // Izvezi(listaFoledr2, pthFolderDuplikat, pthFolderUnikat);

            lblPath.Text ="Folder sa duplikatima: " + pthFolderDuplikat + "Folder sa unikatima: " + pthFolderUnikat;

        }
        public void Izvezi(ListaSlika L, String dup, String uni)
        {
            string destinationPath;
            foreach (Slika s in L)
            {
                if (s.Duplikat == true)
                {
                    destinationPath = Path.Combine(dup, s.Ime + s.Tip);
                }
                else
                {
                    destinationPath = Path.Combine(uni, s.Ime + s.Tip);
                }
                if(!File.Exists(destinationPath))
                File.Copy(s.Putanja, destinationPath);
            }

        }
        public bool check=false;
        public void ckbUnikati_CheckedChanged(object sender, EventArgs e)
        {
            check = !check;
        }
    }
}
