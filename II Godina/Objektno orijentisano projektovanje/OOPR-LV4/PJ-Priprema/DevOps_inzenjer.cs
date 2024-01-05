using System;
using System.Collections.Generic;
using System.Linq;
using System.IO;
using System.Text;
using System.Threading.Tasks;
using System.Reflection.PortableExecutable;

namespace PJ_Priprema
{
    internal class DevOps_inzenjer:Zaposleni
    {
        DateTime _zadnjiPregled;
        public override void PrikazPozicija()
        {
            Console.WriteLine(_zadnjiPregled);      
        }
        public override void citanje(BinaryReader ulaz)
        {
            Ime = ulaz.ReadString();
            Prezime = ulaz.ReadString();
            Plata = ulaz.ReadString();
            _zadnjiPregled = DateTime.Parse(ulaz.ReadString());
        }
        public override void upis(BinaryWriter izlaz)
        {
            izlaz.Write(Ime);
            izlaz.Write(Prezime);
            izlaz.Write(Plata);
            izlaz.Write(_zadnjiPregled.ToString());
        }
        public override double GetBonus()
        {
            DateTime now = System.DateTime.Now;
            TimeSpan razlika = now.Subtract(_zadnjiPregled);
            if (razlika.TotalDays>7)
            {
                return (double.Parse(Plata) * 0.15);
            }
            else
            {
                return (double.Parse(Plata) * 0.3);
            }
        }

    }
}
