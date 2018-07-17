using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using Newtonsoft.Json;

namespace KalendarzFaktur
{
    public class KalendarzFaktur
    {
        const string _sciezkaDoZapisanychFaktur = "faktury.json";
        readonly List<Faktura> _faktury;

        public KalendarzFaktur()
        {
            if (File.Exists(_sciezkaDoZapisanychFaktur))
            {
                _faktury = WczytajFaktury();
            }
            else
            {
                _faktury = new List<Faktura>();
            }
        }

        public List<WyswietlFakture> PobierzAktywneFaktury()
        {
            var aktywneFaktury = _faktury.Where(e => !e.Anulowana).ToArray();
            var wyswietlFaktury = new List<WyswietlFakture>(aktywneFaktury.Length);
            foreach (var @faktura in aktywneFaktury)
            {
                var wyswietlFakture = new WyswietlFakture();
                wyswietlFakture.Firma = @faktura.Firma;

                wyswietlFakture.Kwota = PobierzLadnaKwote(@faktura.Kwota);
                wyswietlFakture.Data = PobierzLadnaDate(@faktura.Data);

                wyswietlFakture.DateTimeFaktury = @faktura.Data;

                wyswietlFaktury.Add(wyswietlFakture);
            }
            return wyswietlFaktury;
        }


        string PobierzLadnaDate(DateTime data)
        {
            return data.Day + "/" + data.Month + "/" + data.Year;
        }

        string PobierzLadnaKwote(double kwota)
        {
            string wynik = kwota.ToString();
            return wynik;
        }

        public void DodajFakture(string firma, DateTime czasNaFakturze, double kwota)
        {
            var nowaFaktura = new Faktura();
            nowaFaktura.Firma = firma;
            nowaFaktura.Data = czasNaFakturze;
            nowaFaktura.Kwota = kwota;
            nowaFaktura.Anulowana = false;
            _faktury.Add(nowaFaktura);
            ZapiszFaktury();
        }

        public void AnulujFakture(string firma, DateTime czas)
        {
            bool znalezionoFakture = false;
            foreach (var @faktura in _faktury)
            {
                if (@faktura.Firma.Equals(firma) && @faktura.Data == czas)
                {
                    @faktura.Anulowana = true;
                    znalezionoFakture = true;
                }
            }
            Debug.Assert(znalezionoFakture);
            ZapiszFaktury();
        }

        public void EdytujFakture(string obecnaFirma, DateTime obecnyCzas, double obecnaKwota, string nowaFirma, DateTime nowyCzas, double nowaKwota)
        {
            bool znalezionoFakture = false;
            foreach (var @faktura in _faktury)
            {
                if (@faktura.Firma.Equals(obecnaFirma) && @faktura.Data == obecnyCzas && @faktura.Kwota.Equals(obecnaKwota))
                {
                    @faktura.Firma = nowaFirma;
                    @faktura.Data = nowyCzas;
                    @faktura.Kwota = nowaKwota;
                    znalezionoFakture = true;
                }
            }
            Debug.Assert(znalezionoFakture);
            ZapiszFaktury();
        }

        void ZapiszFaktury()
        {
            var streamWriter = new StreamWriter(_sciezkaDoZapisanychFaktur);
            var serializowane = JsonConvert.SerializeObject(_faktury, Formatting.Indented);
            streamWriter.Write(serializowane);
            streamWriter.Close();
        }

        List<Faktura> WczytajFaktury()
        {
            var streamReader = new StreamReader(_sciezkaDoZapisanychFaktur);
            var daneFakturyString = streamReader.ReadToEnd();
            streamReader.Close();

            var zapisaneFaktury = JsonConvert.DeserializeObject<List<Faktura>>(daneFakturyString);
            if (zapisaneFaktury != null)
            {
                return zapisaneFaktury;
            }
            return new List<Faktura>();
        }
    }
}