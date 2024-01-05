using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PJ_Priprema
{
    public class WebDeveloper : Zaposleni
    {
        List<String> _tehnologije;

        public List<String> Tehnologije
        {
            get { return _tehnologije; }
            set { _tehnologije = value; }
        }

        public WebDeveloper() {
            _tehnologije = new List<string>();
        }
        public WebDeveloper(String ime,String prezime, String plata, List<string> tehnologije)
            :base(ime,prezime,plata)
        {
            _tehnologije = tehnologije;
        }
        public override void PrikazPozicija()
        {
            foreach(String s in  _tehnologije)
            {
                Console.WriteLine(s);
            }
        }
        public override void citanje(BinaryReader ulaz)
        {
           Ime=ulaz.ReadString();
           Prezime=ulaz.ReadString();
           Plata=ulaz.ReadString();
            string s= ulaz.ReadString();
          _tehnologije.Add(s);
        }
        public override void upis(BinaryWriter izlaz)
        {
            izlaz.Write(Ime);
            izlaz.Write(Prezime);
            izlaz.Write(Plata);
            foreach(String s in _tehnologije)
            { izlaz.Write(s); }
        }

        public override double GetBonus()
        {
            if (_tehnologije.Count > 5)
            {
                return (double.Parse(Plata) * 0.2);
            }
            else
            {
                return (double.Parse(Plata) * 0.1);
            }
        }

    }
}
