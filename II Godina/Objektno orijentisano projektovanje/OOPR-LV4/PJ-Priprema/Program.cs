

namespace PJ_Priprema
{
    class Program
    {
        static void Main(string[] args)
        {
            Kompanija k=new Kompanija();
            Zaposleni Web = new WebDeveloper();
            Zaposleni Web2=new WebDeveloper();
            Kolekcija<Zaposleni> kol = new Kolekcija<Zaposleni>();

            try
            {
                using (BinaryReader ulza = new BinaryReader(new FileStream("E:\\Факс\\Семестар IV\\Програмски језици\\Вежбе\\C#\\Fajlovi\\izlaz.bin", FileMode.Open)))
                {
                    Web.citanje(ulza);
                    Web2.citanje(ulza);
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }
            kol.DodajElement(Web);
            kol.DodajElement(Web2);
            k.Kolekcijaa = kol;
            k.ProveriBonus();
            
            try
            {
                using (BinaryWriter izlaz = new BinaryWriter(new FileStream("E:\\Факс\\Семестар IV\\Програмски језици\\Вежбе\\C#\\Fajlovi\\izlaz1.bin", FileMode.Create)))
                {
                    k.Upis(izlaz);
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }

            





        }
    }
}