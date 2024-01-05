using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PJ_Priprema
{
    internal class QA_inzenjer:Zaposleni
    {
        double _brojTestova;

        public double BrojTestova
        {
            get { return _brojTestova; }
            set { _brojTestova = value;}
        }
        QA_inzenjer() { }
        QA_inzenjer(String ime, String prezime, String plata, double brojTestova) :base(ime,prezime,plata)
        {
            _brojTestova = brojTestova;
        }
        public override void citanje(BinaryReader ulaz)
        {
            Ime = ulaz.ReadString();
            Prezime = ulaz.ReadString();
            Plata = ulaz.ReadString();
            _brojTestova = ulaz.ReadDouble();  
        }
        public override void upis(BinaryWriter izlaz)
        {
            izlaz.Write(Ime);
            izlaz.Write(Prezime);
            izlaz.Write(Plata);
            izlaz.Write(_brojTestova);
        }
        public override void PrikazPozicija()
        {
            Console.WriteLine(_brojTestova);
        }
        public override double GetBonus()
        {
            if (_brojTestova > 10)
            {
                return (double.Parse(Plata) * 0.1);
            }
            else
            {
                return (double.Parse(Plata) * 0.05);
            }
        }
    }
}
