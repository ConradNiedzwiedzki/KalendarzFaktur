using System;
using System.Windows.Forms;

namespace KalendarzFaktur
{
    public partial class DodajFakture : Form
    {
        const string _wpiszNazweFirmy = "Wpisz nazwę firmy...";
        const string _wpiszDateZPrzyszlosci = "Musisz wpisać datę i musi być z przyszłości";

        readonly KalendarzFaktur _kalendarzFaktur;
        readonly KalendarzFakturWindow _kalendarzFakturForm;

        public DodajFakture(KalendarzFaktur kalendarzFaktur, KalendarzFakturWindow kalendarzFakturForm)
        {
            InitializeComponent();
            _kalendarzFaktur = kalendarzFaktur;
            _kalendarzFakturForm = kalendarzFakturForm;
            FirmaTextBox.Text = _wpiszNazweFirmy;
            NowaDataFakturyPicker.MinDate = DateTime.Now;

            this.ShowDialog();
        }

        void DodajFaktureButtonClicked(object sender, EventArgs e)
        {
            var data = NowaDataFakturyPicker.Value;
            var czas = NowyCzasFakturyPicker.Value;

            var dateTimeFaktury = new DateTime(data.Year, data.Month, data.Day, czas.Hour, czas.Minute, czas.Second);
            if (dateTimeFaktury < DateTime.Now)
            {
                MessageBox.Show(_wpiszDateZPrzyszlosci);
                return;
            }
            _kalendarzFaktur.DodajFakture(FirmaTextBox.Text, dateTimeFaktury);
            _kalendarzFakturForm.Invoke(new Action(() => _kalendarzFakturForm.ZaktualizujTabeleKalendarzaFaktur(poleZedytowane: true)));
            _kalendarzFakturForm.Invoke(new Action(_kalendarzFakturForm.AktualizujKalendarz));
            this.Close();
        }

        void TextBoxFirmyMouseDown(object sender, MouseEventArgs e)
        {
            if (FirmaTextBox.Text.Equals(_wpiszNazweFirmy))
            {
                FirmaTextBox.Text = "";
            }
        }

        void TextBoxFirmyTextChanged(object sender, EventArgs e)
        {
            if (!FirmaTextBox.Text.Equals(_wpiszNazweFirmy) && !FirmaTextBox.Text.Equals(""))
            {
                DodajFaktureButton.Enabled = true;
            }
            else
            {
                DodajFaktureButton.Enabled = false;
            }
        }
    }
}