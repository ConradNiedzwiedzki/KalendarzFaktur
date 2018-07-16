using System;

namespace KalendarzFaktur
{
    public class Faktura
    {
        public string Firma;
        public DateTime Data;
        public bool Anulowana;
        public double Kwota;
    }

    public class WyswietlFakture : IEquatable<WyswietlFakture>
    {
        public string Data;
        public string Firma;
        public DateTime DateTimeFaktury;
        public string Kwota;

        public bool Equals(WyswietlFakture druga)
        {
            if (this.DateTimeFaktury == druga.DateTimeFaktury)
                return true;
            return false;
        }
    }
}