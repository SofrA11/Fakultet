using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PJ_Priprema
{
    public class Kolekcija<T> where T : Zaposleni
    {
        List<T> _lista;

        public void DodajElement(T el)
        {
            _lista.Add(el);
        }    
        public static Kolekcija<T> operator +(Kolekcija<T> kolekcija, T zaposleni)
        {
            kolekcija.DodajElement(zaposleni);
            return kolekcija;
        }
        public double GetMaxBonus()
        {
            double maxBonus = 0;
            foreach(T t in _lista)
            {
                maxBonus+=t.GetBonus();
            }
            return maxBonus;
        }
        public void Upis(BinaryWriter Izlaz)
        {
            foreach(T var in _lista)
            {
                var.upis(Izlaz);
            }
        }
        public void Citanje(BinaryReader Ulaz)
        {
            foreach (T var in _lista)
            {
                var.citanje(Ulaz);
            }
        }
        public Kolekcija()
        { _lista = new List<T>(); }
    }
}
