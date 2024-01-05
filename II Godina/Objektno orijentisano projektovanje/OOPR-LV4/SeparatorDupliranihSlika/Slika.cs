using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Xml.Linq;
using System.Windows.Forms;

namespace SeparatorDupliranihSlika
{
    public class Slika
    {

        #region Atributi
        private Image _slika;
        private String _ime;
        private DateTime _datumKreiranja;
        private String _velicina;
        private String _tip;
        private String _putanja;
        private bool _duplikat=false;
        #endregion

        #region Propertys
        public Image Slikaa
        {
            get { return _slika; }
            set { _slika = value; }
        }
        public String Ime
        {
            get { return _ime; }
            set { _ime=value; }
        }
        public DateTime DatumKreiranja
        {
            get { return _datumKreiranja; }
            set { _datumKreiranja = value; }
        }
        public String Velicina
        {
            get { return _velicina; }
            set { _velicina = value; }
        }
        public String Tip
        {
            get { return _tip; }
            set { _tip = value; }   
        }
        public String Putanja
        {
            get { return _putanja; }
            set { _putanja = value; }
        }
        public bool Duplikat
        {
            get { return _duplikat; }
            set { _duplikat = value; }
        }

        public override bool Equals(object obj)
        {
            Slika pomS = obj as Slika;
            if (pomS.Ime == _ime && pomS.Velicina == _velicina && pomS.Tip == _tip)
            {
                if (pomS.DatumKreiranja == _datumKreiranja)
                {
                    _duplikat = true;
                    return true;
                }
                DialogResult dlg= MessageBox.Show("Izgleda da je slika: "+pomS.Ime+", sa putanje "+pomS.Putanja+", i slika: "+_ime+", sa putanje "+_putanja+
                    " Iste slike, ali im se razlikuje datum kreiranja. Ukoliko zelite da ih smatrate istom slikom, kliknite YES, u suprotnom kliknite NO!",
                               "Obavestenje",
                               MessageBoxButtons.YesNo,
                               MessageBoxIcon.Error);
                if(dlg == DialogResult.Yes)
                {
                    _duplikat = true;
                    return true;
                }
                if(dlg == DialogResult.No)
                {
                    _duplikat = false;
                    return false;
                }
            }
            
            return false;
        }
        public override int GetHashCode()
        {
            // Generate a hash code based on the properties used in the Equals method
            unchecked
            {
                int hash = 17;
                hash = hash * 23 + Putanja.GetHashCode();
                hash = hash * 23 + (Ime != null ? Ime.GetHashCode() : 0);
                return hash;
            }
        }
        #endregion

        #region Constructors
        public Slika()
        { }

       public Slika(Image slika, String ime, DateTime datumKreiranja, String velicina,String tip, String putanja)
        {
            _slika = slika;
            _ime = ime;
            _datumKreiranja = datumKreiranja;
            _velicina = velicina;
            _tip = tip;
            _putanja = putanja;
        }


        #endregion
    }
}
