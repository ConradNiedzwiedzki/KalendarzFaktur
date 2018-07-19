using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace KalendarzFaktur
{
    public partial class DodajFakture : Form
    {
        const string _wpiszNazweFirmy = "Wpisz nazwę firmy...";

        readonly KalendarzFaktur _kalendarzFaktur;
        readonly KalendarzFakturWindow _kalendarzFakturForm;

        public DodajFakture(KalendarzFaktur kalendarzFaktur, KalendarzFakturWindow kalendarzFakturForm)
        {
            InitializeComponent();
            _kalendarzFaktur = kalendarzFaktur;
            _kalendarzFakturForm = kalendarzFakturForm;
            FirmaCombox.Text = _wpiszNazweFirmy;
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
                else if (FirmaCombox.Text == _wpiszNazweFirmy || FirmaCombox.Text == String.Empty)
                {
                    MessageBox.Show("Wpisz lub wybierz nazwę firmy!");
                    FirmaCombox.ResetText();
                }
                else
                {
                    var data = NowaDataFakturyPicker.Value;
                    double kwota = Convert.ToDouble(kwotaTextBox.Text);
                    var dateTimeFaktury = new DateTime(data.Year, data.Month, data.Day);
                    _kalendarzFaktur.DodajFakture(FirmaCombox.Text, dateTimeFaktury, kwota);
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

        public void AktualizujFirmyWComboBoxDodawania()
        {
            var faktury = _kalendarzFaktur.PobierzAktywneFaktury();
            foreach (WyswietlFakture wyswFakt in faktury)
            {
                FirmaCombox.Items.Add(wyswFakt.Firma);
            }
        }

        private void kwotaTextBox_TextChanged(object sender, EventArgs e)
        {

        }
    }
}