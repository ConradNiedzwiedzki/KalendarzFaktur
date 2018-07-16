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

        public bool OdswiezAktywneFaktury()
        {
            bool fakturySiePrzedawnily = false;
            foreach (var fkt in _faktury)
            {
                if (fkt.StracilaWaznosc)
                    continue;

                var teraz = DateTime.Now;
                if (fkt.Data < teraz)
                {
                    fkt.StracilaWaznosc = true;
                    fakturySiePrzedawnily = true;
                }
            }
            return fakturySiePrzedawnily;
        }

        public List<WyswietlFakture> PobierzAktywneFaktury()
        {
            var aktywneFaktury = _faktury.Where(e => !e.StracilaWaznosc && !e.Anulowana).ToArray();
            var wyswietlFaktury = new List<WyswietlFakture>(aktywneFaktury.Length);
            foreach (var @faktura in aktywneFaktury)
            {
                var wyswietlFakture = new WyswietlFakture();
                wyswietlFakture.Firma = @faktura.Firma;

                wyswietlFakture.Kwota = PobierzLadnyCzas(@faktura.Data);
                wyswietlFakture.Data = PobierzLadnaDate(@faktura.Data);

                var czasDoPrzedawnienia = @faktura.Data - DateTime.Now;
                var czasDoPrzedawnieniaString = PobierzLadnaRozniceCzasu(czasDoPrzedawnienia);
                wyswietlFakture.CzasDoPrzedawnienia = czasDoPrzedawnieniaString;
                wyswietlFakture.DateTimeFaktury = @faktura.Data;

                wyswietlFaktury.Add(wyswietlFakture);
            }
            return wyswietlFaktury;
        }

        string PobierzLadnaDate(DateTime data)
        {
            return data.Month + "/" + data.Day + "/" + (data.Year - 2000);
        }

        string PobierzLadnyCzas(DateTime czas)
        {
            var godzina = czas.ToString("hh");
            var minuta = czas.ToString("mm");
            var brzask = czas.ToString("tt");
            return godzina + ":" + minuta + " " + brzask;
        }

        string PobierzLadnaRozniceCzasu(TimeSpan roznica)
        {
            var wynik = "";
            if (roznica.Days > 0){
                wynik += roznica.Days + "d ";
            }
            if (roznica.Hours > 0){
                wynik += roznica.Hours + "h ";
            }
            if (roznica.Minutes > 0){
                wynik += roznica.Minutes + "m ";
            }
            wynik += roznica.Seconds + "s";
            return wynik;
        }

        public void DodajFakture(string firma, DateTime czasNaFakturze)
        {
            if (czasNaFakturze < DateTime.Now)
            {
                throw new Exception("Zrobiłeś coś głupiego, a mi nie chce się tego łapać");
            }
            var nowaFaktura = new Faktura();
            nowaFaktura.Firma = firma;
            nowaFaktura.Data = czasNaFakturze;
            nowaFaktura.StracilaWaznosc = false;
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

        public void EdytujFakture(string obecnaFirma, DateTime obecnyCzas, string nowaFirma, DateTime nowyCzas)
        {
            bool znalezionoFakture = false;
            foreach (var @faktura in _faktury)
            {
                if (@faktura.Firma.Equals(obecnaFirma) && @faktura.Data == obecnyCzas)
                {
                    @faktura.Firma = nowaFirma;
                    @faktura.Data = nowyCzas;
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