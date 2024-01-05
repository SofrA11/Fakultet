using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ekstenzije
{
    public static class KlasaEkstenzija
    {
        public static string TrenutnoVreme(this DateTime dateTime)
        {
            return dateTime.ToString("dd.MM.yyyy. HH:mm");
        }
    }
}
