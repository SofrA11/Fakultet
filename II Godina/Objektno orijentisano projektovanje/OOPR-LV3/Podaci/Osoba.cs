using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Podaci
{
    public  class Osoba
    {
        #region Atributes

        String _ime;
        String _prezime;
        String _broj;
        String _adresa;
        DateTime _datum;

        #endregion
        #region Properties

        public String Ime
        {
            get { return _ime; }
            set { _ime = value; }
        }


        public String Prezime
        {
            get { return _prezime; }
            set { _prezime = value; }
        }

        public String Broj
        {
            get { return _broj; }
            set { _broj = value; }
        }
        public String Adresa
        {
            get { return _adresa; }
            set { _adresa = value; }
        }
        public DateTime Datum
        {
            get { return _datum; }
            set { _datum = value; }
        }
        public String ZaPrikaz
        {
            get
            {
                return _ime + " " + _prezime + ", rodjen " + _datum.ToString("dd/MM/yyyy") + ". Broj: " + _broj + ", adresa: " + _adresa;
            }
        }

        #endregion
        #region Constructors

        public Osoba()
        {
        }

        public Osoba(String ime, String prezime, String broj, String adresa, DateTime datum)
        {
            _ime = ime;
            _prezime = prezime;
            _broj = broj;
            _adresa = adresa;
            _datum = datum;
        }
        #endregion
    }
}
