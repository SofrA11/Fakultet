using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Drawing;
using System.Threading.Tasks;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TaskbarClock;
using System.Collections;
using System.Windows.Forms;

namespace SeparatorDupliranihSlika
{
    public class ListaSlika : IEnumerable<Slika>
    {
        #region Atributes
        List<Slika> _lista;
        #endregion
        #region Propertys
        public List<Slika> Listaa
        {
            get { return _lista; }
            set { _lista = value; }
        }
        #endregion

        #region Metods
        public bool UcitajSlikeIzDirektorijuma(String direktorijum)
        {
            if (!Directory.Exists(direktorijum))
            {
               MessageBox.Show("Direktorijum ne postoji.");
                return false;
            }
            String[] fajlovi = Directory.GetFiles(direktorijum, "*.*", SearchOption.TopDirectoryOnly)
                                        .Where(s => s.EndsWith(".jpg") || s.EndsWith(".JPG") || s.EndsWith(".png") || s.EndsWith(".bmp") || s.EndsWith(".jpeg"))
                                        .ToArray();
            foreach(String fajl in fajlovi)
            {
                Image image = Image.FromFile(fajl);
                String imeSlike = Path.GetFileName(fajl);
                DateTime datumKreiranja = File.GetCreationTime(fajl);
                String velicina = new FileInfo(fajl).Length.ToString();
                String tip = Path.GetExtension(fajl);
                String putanja = fajl;

                Slika novaSlika = new Slika(image, imeSlike, datumKreiranja, velicina, tip, putanja);            
                _lista.Add(novaSlika);
            }
            return true;
        }
        public void Izvezi(String dup, String uni)
        {
            string destinationPath;
            foreach (Slika s in _lista)
            {
                if (s.Duplikat == true)
                {
                    destinationPath = Path.Combine(dup, s.Ime + s.Tip);
                }
                else
                {
                    destinationPath = Path.Combine(uni, s.Ime + s.Tip);
                }
                if (!File.Exists(destinationPath))
                    File.Copy(s.Putanja, destinationPath);
            }
        }
        public IEnumerator<Slika> GetEnumerator()
        {
            return _lista.GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
        public void DodajSliku(Slika s)
        {
            _lista.Add(s);
        }
        public void ObrisiSliku(Slika s)
        {
            _lista.Remove(s);
        }
        public void odrediDuplikate(ListaSlika L1)
        {
            foreach(Slika S1 in L1)
            {
                isInList(S1);
            }
        }
        public bool isInList(Slika s)
        {
            foreach(Slika s1 in _lista)
            {
                if(s1.Equals(s))
                    return true;
            }
                return false;
        }
        #endregion

        #region Constructors
        public ListaSlika() {
        _lista = new List<Slika>();
        }
        #endregion
    }
}
