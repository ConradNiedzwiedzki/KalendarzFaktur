using System;
using System.Collections.Generic;
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
            AktualizujFirmyWComboBoxDodawania();
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

        public void AktualizujFirmyWComboBoxDodawania()
        {
            var faktury = _kalendarzFaktur.PobierzAktywneFaktury();
            foreach (WyswietlFakture wyswFakt in faktury)
            {
                FirmaCombox.Items.Add(wyswFakt.Firma);
            }
        }

        private bool _canUpdate = true;

        private bool _needUpdate = false;

        private void FirmaCombobox_TextChanged(object sender, EventArgs e)
        {
            if (_needUpdate)
            {
                if (_canUpdate)
                {
                    _canUpdate = false;
                    UpdateData();
                }
                else
                {
                    RestartTimer();
                }
            }
        }

        private void UpdateData()
        {
            if (FirmaCombox.Text.Length > 1)
            {
                List<string> searchData = Search.GetData(FirmaCombox.Text);
                HandleTextChanged(searchData);
            }
        }

        //If an item was selected don't start new search
        private void combobox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            _needUpdate = false;
        }

        //Update data only when the user (not program) change something
        private void combobox1_TextUpdate(object sender, EventArgs e)
        {
            _needUpdate = true;
        }

        //While timer is running don't start search
        //timer1.Interval = 1500;
        private void RestartTimer()
        {
            timer1.Stop();
            _canUpdate = false;
            timer1.Start();
        }

        //Update data when timer stops
        private void timer1_Tick(object sender, EventArgs e)
        {
            _canUpdate = true;
            timer1.Stop();
            UpdateData();
        }

        //Update combobox with new data
        private void HandleTextChanged(List<string> dataSource)
        {
            var text = FirmaCombox.Text;

            if (dataSource.Count() > 0)
            {
                FirmaCombox.DataSource = dataSource;

                var sText = FirmaCombox.Items[0].ToString();
                FirmaCombox.SelectionStart = text.Length;
                FirmaCombox.SelectionLength = sText.Length - text.Length;
                FirmaCombox.DroppedDown = true;


                return;
            }
            else
            {
                FirmaCombox.DroppedDown = false;
                FirmaCombox.SelectionStart = text.Length;
            }
        }

    }
}