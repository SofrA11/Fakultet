using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PJ_Priprema
{
    public class Kompanija
    {
        private const double maxBonus = 1500;
        private double trenutniBonus;
        Kolekcija<Zaposleni> _kolekcija;

        public void ProveriBonus()
        {
           trenutniBonus = _kolekcija.GetMaxBonus();
            if(trenutniBonus > maxBonus)
            {
                throw new Exception("PREVELIKII BONUS");
            }
        }
       public double TrenutniBonus
        {
            get { return trenutniBonus; }
            set { trenutniBonus = value; }
        }
        public Kolekcija<Zaposleni> Kolekcijaa
        {
            get { return _kolekcija;}
            set { _kolekcija = value;}
        }
        public void Upis(BinaryWriter Izlaz)
        {
            Izlaz.Write(TrenutniBonus);
            _kolekcija.Upis(Izlaz);
        }
        public void Citanje(BinaryReader Ulaz)
        {
            TrenutniBonus=Ulaz.ReadDouble();
            _kolekcija.Citanje(Ulaz);
        }
        public Kompanija()
        {
            _kolekcija = new Kolekcija<Zaposleni>();
        }
       public Kompanija(Kolekcija<Zaposleni> kolekcija)
        {
            TrenutniBonus = 0;
            _kolekcija = kolekcija;
        }
    }
}
