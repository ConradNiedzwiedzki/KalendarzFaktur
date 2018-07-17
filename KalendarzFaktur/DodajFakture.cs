using System;
using System.Windows.Forms;

namespace KalendarzFaktur
{
    public partial class DodajFakture : Form
    {
        const string _wpiszNazweFirmy = "Wpisz nazwę firmy...";
        const string _wpiszPoprawnaKwote = "Musisz wpisać poprawną kwotę (w formacie 'XXXXX,XX', bez zer i większą od zera)";

        readonly KalendarzFaktur _kalendarzFaktur;
        readonly KalendarzFakturWindow _kalendarzFakturForm;

        public DodajFakture(KalendarzFaktur kalendarzFaktur, KalendarzFakturWindow kalendarzFakturForm)
        {
            InitializeComponent();
            _kalendarzFaktur = kalendarzFaktur;
            _kalendarzFakturForm = kalendarzFakturForm;
            FirmaCombox.Text = _wpiszNazweFirmy;
            this.ShowDialog();
        }

        void DodajFaktureButtonClicked(object sender, EventArgs e)
        {
            var data = NowaDataFakturyPicker.Value;
            double kwota = Convert.ToDouble(kwotaTextBox.Text);
            if(Convert.ToDouble(kwotaTextBox.Text) < 0)
            {
                MessageBox.Show(_wpiszPoprawnaKwote);
            }

            var dateTimeFaktury = new DateTime(data.Year, data.Month, data.Day);
            _kalendarzFaktur.DodajFakture(FirmaCombox.Text, dateTimeFaktury, kwota);
            _kalendarzFakturForm.Invoke(new Action(() => _kalendarzFakturForm.ZaktualizujTabeleKalendarzaFaktur(poleZedytowane: true)));
            _kalendarzFakturForm.Invoke(new Action(_kalendarzFakturForm.AktualizujKalendarz));
            this.Close();
        }

        void TextBoxFirmyMouseDown(object sender, MouseEventArgs e)
        {
            if (FirmaCombox.Text.Equals(_wpiszNazweFirmy))
            {
                FirmaCombox.Text = "";
            }
        }

        void TextBoxFirmyTextChanged(object sender, EventArgs e)
        {
            if (!FirmaCombox.Text.Equals(_wpiszNazweFirmy) && !FirmaCombox.Text.Equals(""))
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