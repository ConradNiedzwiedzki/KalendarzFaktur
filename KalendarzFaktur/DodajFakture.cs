using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Windows.Forms;

namespace KalendarzFaktur
{
    public partial class DodajFakture : Form
    {
        const string _wpiszNazweFirmy = "Wpisz nazwę firmy...";

        readonly KalendarzFaktur _kalendarzFaktur;
        readonly KalendarzFakturWindow _kalendarzFakturForm;
        const string _sciezkaDoBazyPodpowiedziFirm = "firmy.json";
        readonly List<string> _firmy;

        public DodajFakture(KalendarzFaktur kalendarzFaktur, KalendarzFakturWindow kalendarzFakturForm)
        {
            InitializeComponent();
            _kalendarzFaktur = kalendarzFaktur;
            _kalendarzFakturForm = kalendarzFakturForm;
            firmaComboBox.Text = _wpiszNazweFirmy;
            if (File.Exists(_sciezkaDoBazyPodpowiedziFirm))
            {
                _firmy = WczytajFirmy();
            }
            else
            {
                _firmy = new List<string>();
            }
            AktualizujFirmyWComboBoxDodawania();
            this.ShowDialog();
        }

        void DodajFaktureButtonClicked(object sender, EventArgs e)
        {
            if (kwotaTextBox.Text == String.Empty)
            {
                MessageBox.Show("Zapomniałeś o wpisaniu kwoty!");
                kwotaTextBox.ResetText();
            }
            else if (!ZawieraTylkoCyfry(kwotaTextBox.Text))
            {
                MessageBox.Show("Kwota może zawierać tylko nieujemne cyfry i przecinek! (np. 123,45)");
                kwotaTextBox.ResetText();
            }
            else
            {
                if (Convert.ToDouble(kwotaTextBox.Text) < 0)
                {
                    MessageBox.Show("Kwota nie może być mniejsza od zera!");
                    kwotaTextBox.ResetText();
                }
                else if (firmaComboBox.Text == _wpiszNazweFirmy || firmaComboBox.Text == String.Empty)
                {
                    MessageBox.Show("Wpisz lub wybierz nazwę firmy!");
                    firmaComboBox.ResetText();
                }
                else
                {
                    var data = nowaDataFakturyPicker.Value;
                    double kwota = Convert.ToDouble(kwotaTextBox.Text);
                    var dateTimeFaktury = new DateTime(data.Year, data.Month, data.Day);

                    DopiszNowaFirmeDoBazy(firmaComboBox.Text);

                    _kalendarzFaktur.DodajFakture(firmaComboBox.Text, dateTimeFaktury, kwota);
                    _kalendarzFakturForm.Invoke(new Action(() => _kalendarzFakturForm.ZaktualizujTabeleKalendarzaFaktur(poleZedytowane: true)));
                    _kalendarzFakturForm.Invoke(new Action(_kalendarzFakturForm.AktualizujKalendarz));
                    this.Close();
                }
            }
        }

        bool ZawieraTylkoCyfry(string tekst)
        {
            foreach (char znak in tekst)
            {
                if (znak < '0' || znak > '9')
                {
                    if(znak != ',')
                        return false;
                }
            }
            return true;
        }

        public void AktualizujFirmyWComboBoxDodawania()
        {
            foreach(string f in _firmy)
            {
                firmaComboBox.Items.Add(f);
            }
        }

        void DopiszNowaFirmeDoBazy(string firma)
        {
            bool jestNowaFirma = true;
            foreach(string f in _firmy)
            {
                if (f == firma)
                    jestNowaFirma = false;
            }
            if (jestNowaFirma)
            {
                _firmy.Add(firma);
                var streamWriter = new StreamWriter(_sciezkaDoBazyPodpowiedziFirm);
                var serializowane = JsonConvert.SerializeObject(_firmy, Formatting.Indented);
                streamWriter.Write(serializowane);
                streamWriter.Close();
            }
        }

        List<string> WczytajFirmy()
        {
            var streamReader = new StreamReader(_sciezkaDoBazyPodpowiedziFirm);
            var daneFirmyString = streamReader.ReadToEnd();
            streamReader.Close();

            var zapisaneFirmy = JsonConvert.DeserializeObject<List<string>>(daneFirmyString);
            if (zapisaneFirmy != null)
            {
                return zapisaneFirmy;
            }
            return new List<string>();
        }
    }
}