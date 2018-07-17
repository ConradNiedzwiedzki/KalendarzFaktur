using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KalendarzFaktur
{
    public partial class KalendarzFakturWindow : Form
    {
        const int _wysokoscRzeduTabeliFaktur = 22;
        readonly Dictionary<int, Tuple<string, DateTime, double>> _przyciskDoWyszukiwaniaFaktur;
        readonly DataGridViewCellStyle _stylDomyslny;
        readonly KalendarzFaktur _kalendarzFaktur;
        readonly DataGridViewCellStyle _stylPilny;
        readonly DataGridViewCellStyle _stylOstrzezenia;
        DodajFakture _dodajFaktureForm;
        Task _taskAktulizacjiPola;
        bool _zabijtaskAktualizacjiPola;

        public KalendarzFakturWindow()
        {
            _przyciskDoWyszukiwaniaFaktur = new Dictionary<int, Tuple<string, DateTime, double>>();
            _kalendarzFaktur = new KalendarzFaktur();

            InitializeComponent();
            this.MaximizeBox = false;
            this.FormBorderStyle = FormBorderStyle.FixedSingle;

            ZaktualizujTabeleKalendarzaFaktur(poleZedytowane: true);
            AktualizujKalendarz();
            AktualizujFirmyWComboBoxEdycji();

            WyczyscSzczegolyFaktury();

            _stylPilny = new DataGridViewCellStyle();
            _stylPilny.BackColor = Color.LightPink;
            _stylPilny.SelectionBackColor = Color.LightPink;
            _stylOstrzezenia = new DataGridViewCellStyle();
            _stylOstrzezenia.BackColor = Color.LightYellow;
            _stylOstrzezenia.SelectionBackColor = Color.LightYellow;
            _stylDomyslny = new DataGridViewCellStyle();
            _stylDomyslny.BackColor = Color.LightGreen;
            _stylDomyslny.SelectionBackColor = Color.LightGreen;
            TabelaFaktur.ClearSelection();

        }

        protected override void OnShown(EventArgs e)
        {
            this.TabelaFaktur.Focus();
            base.OnShown(e);
        }

        public void AktualizujKalendarz()
        {
            kalendarzMiesiac.RemoveAllBoldedDates();
            var faktury = _kalendarzFaktur.PobierzAktywneFaktury();
            foreach (WyswietlFakture wyswFakt in faktury)
            {
                kalendarzMiesiac.AddBoldedDate(wyswFakt.DateTimeFaktury);
            }
            kalendarzMiesiac.UpdateBoldedDates();
        }
        public void AktualizujFirmyWComboBoxEdycji()
        {
            var faktury = _kalendarzFaktur.PobierzAktywneFaktury();
            foreach (WyswietlFakture wyswFakt in faktury)
            {
                EdytujFirme.Items.Add(wyswFakt.Firma);
            }
        }


        public void ZaktualizujTabeleKalendarzaFaktur(bool poleZedytowane)
        {
            int liczbaPoprzednichFaktur = TabelaFaktur.RowCount;
            var faktury = _kalendarzFaktur.PobierzAktywneFaktury();
            var posortowane = faktury.OrderBy(fkt => fkt.DateTimeFaktury).ToArray();
            TabelaFaktur.RowCount = posortowane.Length;
            for (int i = 0; i < posortowane.Length; i++)
            {
                var daysRemaining = (posortowane[i].DateTimeFaktury - DateTime.Now).Days;

                if (daysRemaining >= 7)
                {
                    TabelaFaktur[0, i].Style = _stylDomyslny;
                    TabelaFaktur[1, i].Style = _stylDomyslny;
                    TabelaFaktur[2, i].Style = _stylDomyslny;
                }
                if (daysRemaining < 7 && daysRemaining >= 1)
                {
                    TabelaFaktur[0, i].Style = _stylOstrzezenia;
                    TabelaFaktur[1, i].Style = _stylOstrzezenia;
                    TabelaFaktur[2, i].Style = _stylOstrzezenia;
                }
                if (daysRemaining < 1)
                {
                    TabelaFaktur[0, i].Style = _stylPilny;
                    TabelaFaktur[1, i].Style = _stylPilny;
                    TabelaFaktur[2, i].Style = _stylPilny;
                }
                TabelaFaktur[0, i].Value = posortowane[i].Firma;
                TabelaFaktur[1, i].Value = posortowane[i].Data;
                TabelaFaktur[2, i].Value = posortowane[i].Kwota;
            }

            if (poleZedytowane)
            {
                WyczyscSzczegolyFaktury();
                TabelaFaktur.ClearSelection();
                TabelaFaktur.Height = TabelaFaktur.RowCount * _wysokoscRzeduTabeliFaktur;
                _przyciskDoWyszukiwaniaFaktur.Clear();
                for (int i = 0; i < posortowane.Length; i++)
                {
                    TabelaFaktur[0, i].Tag = i;
                    _przyciskDoWyszukiwaniaFaktur.Add(i, new Tuple<string, DateTime, double>(posortowane[i].Firma, posortowane[i].DateTimeFaktury, Convert.ToDouble(posortowane[i].Kwota)));
                }
            }
        }

        void petlaAktualizacjiPol()
        {
            while (true)
            {
                Thread.Sleep(50);
                if (_zabijtaskAktualizacjiPola)
                {
                    break;
                }
                this.BeginInvoke((Action)(() => ZaktualizujTabeleKalendarzaFaktur(poleZedytowane: false)));
            }
        }

        void ClickWKomorkeTabeliFaktur(object sender, DataGridViewCellEventArgs e)
        {
            var wybraneKomorki = TabelaFaktur.SelectedCells;
            var tag = (int) wybraneKomorki[0].Tag;
            var szczegoly = _przyciskDoWyszukiwaniaFaktur[tag];
            var firma = szczegoly.Item1;
            var dateTime = szczegoly.Item2;
            var kwota = szczegoly.Item3;
            EdytujFirme.Text = firma;
            EdycjaDatyPicker.Value = dateTime;
            EdycjaKwotyTextBox.Text = kwota.ToString();
            WlaczPolaSzczegolowFaktury();
            WylaczPolaEdycji();
        }

        void WlaczPolaSzczegolowFaktury()
        {
            EdytujFirme.Visible = true;
            EdycjaDatyPicker.Visible = true;
            EdycjaKwotyTextBox.Visible = true;
            EdytujFaktureButton.Visible = true;
            UsunFaktureButton.Visible = true;
            EdytujFaktureButton.Enabled = true;
            UsunFaktureButton.Enabled = true;
        }

        void WylaczPolaSzczegolowFaktury()
        {
            UsunFaktureButton.Enabled = false;
            EdytujFaktureButton.Enabled = false;
            EdytujFirme.Visible = false;
            EdycjaDatyPicker.Visible = false;
            EdycjaKwotyTextBox.Visible = false;
            EdytujFaktureButton.Visible = false;
            UsunFaktureButton.Visible = false;
        }

        void WlaczPolaEdycji()
        {
            EdytujFaktureButton.Visible = false;
            AnulujEdycjeButton.Visible = true;
            ZapiszZmianyButton.Visible = true;
            UsunFaktureButton.Enabled = false;
            EdycjaDatyPicker.Enabled = true;
            EdycjaKwotyTextBox.Enabled = true;
            EdytujFirme.Enabled = true;
        }

        void WylaczPolaEdycji()
        {
            EdytujFaktureButton.Visible = true;
            AnulujEdycjeButton.Visible = false;
            ZapiszZmianyButton.Visible = false;
            UsunFaktureButton.Enabled = true;
            EdycjaDatyPicker.Enabled = false;
            EdycjaKwotyTextBox.Enabled = false;
            EdytujFirme.Enabled = false;
        }

        void WyczyscSzczegolyFaktury()
        {
            EdytujFirme.Text = "";
            WylaczPolaEdycji();
            WylaczPolaSzczegolowFaktury();
        }

        void EdytujFaktureButtonClick(object sender, EventArgs e)
        {
            WlaczPolaEdycji();
        }

        void UsunFaktureButtonClick(object sender, EventArgs e)
        {
            var firmaFaktury = EdytujFirme.Text;
            var dataFaktury = EdycjaDatyPicker.Value;
            var wynik = MessageBox.Show("Czy jesteś pewien, że chcesz anulować fakturę z " + firmaFaktury + "?!", "", MessageBoxButtons.YesNo);
            if (wynik == DialogResult.Yes)
            {
                _kalendarzFaktur.AnulujFakture(firmaFaktury, dataFaktury);
                ZaktualizujTabeleKalendarzaFaktur(poleZedytowane: true);
                AktualizujKalendarz();
                TabelaFaktur.ClearSelection();
                WyczyscSzczegolyFaktury();
            }
        }

        void SaveChangesButtonClick(object sender, EventArgs e)
        {
            var data = EdycjaDatyPicker.Value;
            var nowaKwota = Convert.ToDouble(EdycjaKwotyTextBox.Text);
            var nowaFirma = EdytujFirme.Text;

            var dateTimeFaktury = new DateTime(data.Year, data.Month, data.Day);
            var tag = (int)TabelaFaktur.SelectedCells[0].Tag;
            var poprzedniaFirma = _przyciskDoWyszukiwaniaFaktur[tag].Item1;
            var poprzedniCzas = _przyciskDoWyszukiwaniaFaktur[tag].Item2;
            var poprzedniaKwota = _przyciskDoWyszukiwaniaFaktur[tag].Item3;
            _kalendarzFaktur.EdytujFakture(poprzedniaFirma, poprzedniCzas, poprzedniaKwota, nowaFirma, dateTimeFaktury, nowaKwota);
            WylaczPolaEdycji();
            ZaktualizujTabeleKalendarzaFaktur(poleZedytowane: true);
            AktualizujKalendarz();
        }

        void AnulujEdycjeButtonClick(object sender, EventArgs e)
        {
            var tag = (int)TabelaFaktur.SelectedCells[0].Tag;
            var daneFaktury = _przyciskDoWyszukiwaniaFaktur[tag];
            EdytujFirme.Text = daneFaktury.Item1;
            EdycjaDatyPicker.Value = daneFaktury.Item2;
            EdycjaKwotyTextBox.Text = daneFaktury.Item3.ToString();
            WylaczPolaEdycji();
        }

        void AktywacjaOknaKalendarzaFaktur(object sender, EventArgs e)
        {
            ZaktualizujTabeleKalendarzaFaktur(poleZedytowane: true);
            _taskAktulizacjiPola = new Task(petlaAktualizacjiPol);
            _zabijtaskAktualizacjiPola = false;
            _taskAktulizacjiPola.Start();
        }

        void DeaktywacjaOknaKalendarzaFaktur(object sender, EventArgs e)
        {
            _zabijtaskAktualizacjiPola = true;
            _taskAktulizacjiPola.Wait();
        }

        void ZamykanieFormKalendarzaFaktur(object sender, FormClosingEventArgs e)
        {
            _zabijtaskAktualizacjiPola = true;
            _taskAktulizacjiPola.Wait();
        }

        void ResizeOknaKalendarzaFaktur(object sender, EventArgs e)
        {
            if (FormWindowState.Minimized == this.WindowState)
            {
                this.Hide();
            }
            else if (FormWindowState.Normal == this.WindowState)
            {
                TabelaFaktur.ClearSelection();
                WyczyscSzczegolyFaktury();
                ZaktualizujTabeleKalendarzaFaktur(poleZedytowane: false);
                AktualizujKalendarz();
            }
        }

        private void EksprotujFaktury()
        {
            MessageBox.Show("Ta funkcjonalność nie jest jeszcze dostępna!");
        }

        void ClickPanelaFaktur(object sender, EventArgs e)
        {
            TabelaFaktur.ClearSelection();
            WyczyscSzczegolyFaktury();
        }

        void ClickOknaKalendarzaFaktur(object sender, EventArgs e)
        {
            TabelaFaktur.ClearSelection();
            WyczyscSzczegolyFaktury();
        }

        void MenuStrip1Click(object sender, EventArgs e)
        {
            TabelaFaktur.ClearSelection();
            WyczyscSzczegolyFaktury();
        }

        void AddEventToolStripMenuItemClick(object sender, EventArgs e)
        {
            _dodajFaktureForm = new DodajFakture(_kalendarzFaktur, this);
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void eksprotujFakturyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            EksprotujFaktury();
        }
    }
}