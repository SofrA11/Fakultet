using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PJ_Priprema
{
    public abstract class Zaposleni
    {
        String _ime;
        String _prezime;
        String _plata;

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
        public String Plata
        {
            get { return _plata; }
            set { _plata = value; }
        }
        public abstract void PrikazPozicija();
        public abstract double GetBonus();

        public abstract void upis(BinaryWriter izlaz);
        public abstract void citanje(BinaryReader ulaz);


        public Zaposleni() { }
        public Zaposleni(String ime, String prezime, String plata)        {
            Ime = ime;
            Prezime = prezime;
            Plata = plata;
        }

    }
}
