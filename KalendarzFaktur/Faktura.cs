using System;

namespace KalendarzFaktur
{
    public class Faktura
    {
        public string Firma;
        public DateTime Data;
        public bool StracilaWaznosc;
        public bool Anulowana;
    }

    public class WyswietlFakture : IEquatable<WyswietlFakture>
    {
        public string Data;
        public string Firma;
        public DateTime DateTimeFaktury;
        public string Kwota;
        public string CzasDoPrzedawnienia;

        public bool Equals(WyswietlFakture druga)
        {
            if (this.DateTimeFaktury == druga.DateTimeFaktury)
                return true;
            return false;
        }
    }
}