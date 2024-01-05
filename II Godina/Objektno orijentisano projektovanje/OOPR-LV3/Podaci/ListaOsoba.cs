using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;

namespace Podaci
{
    public  class ListaOsoba
    {
        public delegate int SortDelegate(Osoba x, Osoba y);

        #region Atributes

        private List<Osoba> _listaOsoba;
        private static ListaOsoba _instance = null;

        #endregion

        #region Properties
        public List<Osoba> ListaOsobaValues
        {
            get
            {
                return _listaOsoba;
            }
        }
        #endregion

        #region Constructors

        private ListaOsoba()
        {
            _listaOsoba = new List<Osoba>();
        }

        #endregion

        #region Methodes

        public bool DodajOsobu(Osoba o)
        {
            if (PostojiOsobaUListi(o))
                return false;

            _listaOsoba.Insert(0, o);          
            return true;
        }

        public bool ObrisiOsobu(Osoba o)
        {
            if (!PostojiOsobaUListi(o))
                return false;
            _listaOsoba.Remove(o);
            return true;
        }
        public bool ObrisiListu()
        {
            if (_listaOsoba.Count() == 0)
                return false;
           /* for (int i = _listaOsoba.Count - 1; i > 0; i--)
            {
                ObrisiOsobu(_listaOsoba[i]);
            }
           */
            _listaOsoba.Clear();
            return true;
        }
        public bool ObrisiOsobu(String Broj)
        {
            Osoba tmpOsoba = null;

            foreach (var v in _listaOsoba)
            {
                if (v.Broj == Broj)
                {
                    tmpOsoba = v;
                    break;
                }
            }

            if (tmpOsoba != null)
            {
                _listaOsoba.Remove(tmpOsoba);
                return true;
            }

            return false;
        }

        public bool PostojiOsobaUListi(Osoba o)
        {
            foreach (var v in _listaOsoba)
            {
                if (v.Prezime == o.Prezime && v.Ime == o.Ime && v.Datum == o.Datum && v.Broj == o.Broj && v.Adresa == o.Adresa)
                    return true;
            }

            return false;
        }
        public int GetIndex(Osoba o)
        {
            int i = 0;
            foreach (var v in _listaOsoba)
            {
                if (v.Prezime == o.Prezime && v.Ime == o.Ime && v.Datum == o.Datum && v.Broj == o.Broj && v.Adresa == o.Adresa)
                    return i;
                i++;
            }
            return 0;
        }
        public void AzurirajOsobu(int i,Osoba o)
        {
            _listaOsoba[i].Ime = o.Ime;
            _listaOsoba[i].Prezime = o.Prezime;
            _listaOsoba[i].Broj = o.Broj;
            _listaOsoba[i].Adresa = o.Adresa;
            _listaOsoba[i].Datum= o.Datum;
        }

        public Osoba GetOsoba(String Broj)
        {
            foreach (var v in _listaOsoba)
            {
                if (v.Broj == Broj)
                    return v;
            }

            return null;
        }
        #endregion

        public void Sortiraj(SortDelegate comparison)
        {
            _listaOsoba.Sort(new Comparison<Osoba>(comparison));
        }
        public static int PoredjenjePoImenu(Osoba x, Osoba y)
        {
            return x.Ime.CompareTo(y.Ime);
        }

        public static int PoredjenjePoPrezimenu(Osoba x, Osoba y)
        {
            return x.Prezime.CompareTo(y.Prezime);
        }

        public static int PoredjenjePoDatumuRodjenja(Osoba x, Osoba y)
        {
            return x.Datum.CompareTo(y.Datum);
        }


        public static ListaOsoba Instance
        {
            get
            {
                if (_instance == null)
                    _instance = new ListaOsoba();

                return _instance;
            }
        }
    }
}
