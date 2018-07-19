using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
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
        readonly DataGridViewCellStyle _stylWygaszenia;
        DodajFakture _dodajFaktureForm;
        UsunFirme _usunFirmeForm;
        Task _taskAktulizacjiPola;
        bool _zabijtaskAktualizacjiPola;
        const string _sciezkaDoBazyPodpowiedziFirm = "firmy.json";

        public KalendarzFakturWindow()
        {
            _przyciskDoWyszukiwaniaFaktur = new Dictionary<int, Tuple<string, DateTime, double>>();
            _kalendarzFaktur = new KalendarzFaktur();

            InitializeComponent();
            this.MaximizeBox = false;
            this.FormBorderStyle = FormBorderStyle.FixedSingle;

            ZaktualizujTabeleKalendarzaFaktur(poleZedytowane: true);
            AktualizujKalendarz();

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
            _stylWygaszenia = new DataGridViewCellStyle();
            _stylWygaszenia.BackColor = Color.LightGray;
            _stylWygaszenia.SelectionBackColor = Color.LightGray;
            tabelaFaktur.ClearSelection();

        }

        protected override void OnShown(EventArgs e)
        {
            this.tabelaFaktur.Focus();
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

        public void ZaktualizujTabeleKalendarzaFaktur(bool poleZedytowane)
        {
            int liczbaPoprzednichFaktur = tabelaFaktur.RowCount;
            var faktury = _kalendarzFaktur.PobierzAktywneFaktury();
            var posortowane = faktury.OrderBy(fkt => fkt.DateTimeFaktury).ToArray();
            tabelaFaktur.RowCount = posortowane.Length;
            for (int i = 0; i < posortowane.Length; i++)
            {
                var daysRemaining = (posortowane[i].DateTimeFaktury - DateTime.Now).Days;

                if (daysRemaining >= 7)
                {
                    tabelaFaktur[0, i].Style = _stylDomyslny;
                    tabelaFaktur[1, i].Style = _stylDomyslny;
                    tabelaFaktur[2, i].Style = _stylDomyslny;
                }
                if (daysRemaining < 7 && daysRemaining >= 1)
                {
                    tabelaFaktur[0, i].Style = _stylOstrzezenia;
                    tabelaFaktur[1, i].Style = _stylOstrzezenia;
                    tabelaFaktur[2, i].Style = _stylOstrzezenia;
                }
                if (daysRemaining < 1)
                {
                    tabelaFaktur[0, i].Style = _stylPilny;
                    tabelaFaktur[1, i].Style = _stylPilny;
                    tabelaFaktur[2, i].Style = _stylPilny;
                }

                if (daysRemaining < 0)
                {
                    tabelaFaktur[0, i].Style = _stylWygaszenia;
                    tabelaFaktur[1, i].Style = _stylWygaszenia;
                    tabelaFaktur[2, i].Style = _stylWygaszenia;
                }

                tabelaFaktur[0, i].Value = posortowane[i].Firma;
                tabelaFaktur[1, i].Value = posortowane[i].Data;
                tabelaFaktur[2, i].Value = posortowane[i].Kwota;
            }

            if (poleZedytowane)
            {
                WyczyscSzczegolyFaktury();
                tabelaFaktur.ClearSelection();
                tabelaFaktur.Height = tabelaFaktur.RowCount * _wysokoscRzeduTabeliFaktur;
                _przyciskDoWyszukiwaniaFaktur.Clear();
                for (int i = 0; i < posortowane.Length; i++)
                {
                    tabelaFaktur[0, i].Tag = i;
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
            var wybraneKomorki = tabelaFaktur.SelectedCells;
            var tag = (int) wybraneKomorki[0].Tag;
            var szczegoly = _przyciskDoWyszukiwaniaFaktur[tag];
            var firma = szczegoly.Item1;
            var dateTime = szczegoly.Item2;
            var kwota = szczegoly.Item3;
            edytujFirme.Text = firma;
            edycjaDatyPicker.Value = dateTime;
            edycjaKwotyTextBox.Text = kwota.ToString();
            WlaczPolaSzczegolowFaktury();
            WylaczPolaEdycji();
        }

        void WlaczPolaSzczegolowFaktury()
        {
            edytujFirme.Visible = true;
            edycjaDatyPicker.Visible = true;
            edycjaKwotyTextBox.Visible = true;
            edytujFaktureButton.Visible = true;
            usunFaktureButton.Visible = true;
            edytujFaktureButton.Enabled = true;
            usunFaktureButton.Enabled = true;
        }

        void WylaczPolaSzczegolowFaktury()
        {
            usunFaktureButton.Enabled = false;
            edytujFaktureButton.Enabled = false;
            edytujFirme.Visible = false;
            edycjaDatyPicker.Visible = false;
            edycjaKwotyTextBox.Visible = false;
            edytujFaktureButton.Visible = false;
            usunFaktureButton.Visible = false;
        }

        void WlaczPolaEdycji()
        {
            edytujFaktureButton.Visible = false;
            anulujEdycjeButton.Visible = true;
            zapiszZmianyButton.Visible = true;
            usunFaktureButton.Enabled = false;
            edycjaDatyPicker.Enabled = true;
            edycjaKwotyTextBox.Enabled = true;
            edytujFirme.Enabled = true;
        }

        void WylaczPolaEdycji()
        {
            edytujFaktureButton.Visible = true;
            anulujEdycjeButton.Visible = false;
            zapiszZmianyButton.Visible = false;
            usunFaktureButton.Enabled = true;
            edycjaDatyPicker.Enabled = false;
            edycjaKwotyTextBox.Enabled = false;
            edytujFirme.Enabled = false;
        }

        void WyczyscSzczegolyFaktury()
        {
            edytujFirme.Text = "";
            WylaczPolaEdycji();
            WylaczPolaSzczegolowFaktury();
        }

        void EdytujFaktureButtonClick(object sender, EventArgs e)
        {
            WlaczPolaEdycji();
        }

        void UsunFaktureButtonClick(object sender, EventArgs e)
        {
            var firmaFaktury = edytujFirme.Text;
            var dataFaktury = edycjaDatyPicker.Value;
            var wynik = MessageBox.Show("Czy jesteś pewien, że chcesz usunąć fakturę z " + firmaFaktury + "?!", "", MessageBoxButtons.YesNo);
            if (wynik == DialogResult.Yes)
            {
                _kalendarzFaktur.UsunFakture(firmaFaktury, dataFaktury);
                ZaktualizujTabeleKalendarzaFaktur(poleZedytowane: true);
                AktualizujKalendarz();
                tabelaFaktur.ClearSelection();
                WyczyscSzczegolyFaktury();
            }
        }

        void ZapiszZmianyButtonClick(object sender, EventArgs e)
        {
            if (edycjaKwotyTextBox.Text == String.Empty)
            {
                MessageBox.Show("Zapomniałeś o wpisaniu kwoty!");
            }
            else if (!ZawieraTylkoCyfry(edycjaKwotyTextBox.Text))
            {
                MessageBox.Show("Kwota może zawierać tylko nieujemne cyfry i przecinek! (np. 123,45)");
            }
            else
            {
                if (Convert.ToDouble(edycjaKwotyTextBox.Text) < 0)
                {
                    MessageBox.Show("Kwota nie może być mniejsza od zera!");
                }
                else if (edytujFirme.Text == String.Empty)
                {
                    MessageBox.Show("Wpisz lub wybierz nazwę firmy!");
                }
                else
                {
                    var data = edycjaDatyPicker.Value;
                    var nowaKwota = Convert.ToDouble(edycjaKwotyTextBox.Text);
                    var nowaFirma = edytujFirme.Text;

                    var dateTimeFaktury = new DateTime(data.Year, data.Month, data.Day);
                    var tag = (int)tabelaFaktur.SelectedCells[0].Tag;
                    var poprzedniaFirma = _przyciskDoWyszukiwaniaFaktur[tag].Item1;
                    var poprzedniCzas = _przyciskDoWyszukiwaniaFaktur[tag].Item2;
                    var poprzedniaKwota = _przyciskDoWyszukiwaniaFaktur[tag].Item3;
                    _kalendarzFaktur.EdytujFakture(poprzedniaFirma, poprzedniCzas, poprzedniaKwota, nowaFirma, dateTimeFaktury, nowaKwota);
                    WylaczPolaEdycji();
                    ZaktualizujTabeleKalendarzaFaktur(poleZedytowane: true);
                    AktualizujKalendarz();
                }
            }
        }

        bool ZawieraTylkoCyfry(string tekst)
        {
            foreach (char znak in tekst)
            {
                if (znak < '0' || znak > '9')
                {
                    if (znak != ',')
                        return false;
                }
            }
            return true;
        }

        void AnulujEdycjeButtonClick(object sender, EventArgs e)
        {
            var tag = (int)tabelaFaktur.SelectedCells[0].Tag;
            var daneFaktury = _przyciskDoWyszukiwaniaFaktur[tag];
            edytujFirme.Text = daneFaktury.Item1;
            edycjaDatyPicker.Value = daneFaktury.Item2;
            edycjaKwotyTextBox.Text = daneFaktury.Item3.ToString();
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
                tabelaFaktur.ClearSelection();
                WyczyscSzczegolyFaktury();
                ZaktualizujTabeleKalendarzaFaktur(poleZedytowane: false);
                AktualizujKalendarz();
            }
        }

        private void EksprotujFaktury()
        {
            var faktury = _kalendarzFaktur.PobierzAktywneFaktury();
            SaveFileDialog savefile = new SaveFileDialog();
            savefile.FileName = "Paxer_faktury_" + DateTime.Today.Month.ToString() + "-" + DateTime.Today.Day.ToString() + "-" + DateTime.Today.Year.ToString() + ".xls";
            savefile.Filter = "Excel Files|*.xls;*.xlsx;*.xlsm";
            if (faktury.Count() > 0)
            {
                if (savefile.ShowDialog() == DialogResult.OK)
                {
                    //using (StreamWriter sw = new StreamWriter(savefile.FileName))
                    //    sw.WriteLine("Hello World!");
                    StreamWriter wr = new StreamWriter(savefile.FileName);
                    wr.Write("NAZWA FIRMY" + "\t");
                    wr.Write("DATA" + "\t");
                    wr.Write("KWOTA" + "\t");

                    wr.WriteLine();

                    //write rows to excel file
                    foreach(WyswietlFakture fkt in faktury)
                    {
                        wr.Write(fkt.Firma + "\t");
                        wr.Write(fkt.Data + "\t");
                        wr.Write(fkt.Kwota + "\t");
                        wr.WriteLine();
                    }
                    wr.Close();
                    MessageBox.Show(this, "Dane zostały zapisane do formatu Excel w pliku " + savefile.FileName, "Sukces, zapisano", MessageBoxButtons.OK, MessageBoxIcon.Question);
                }
            }
            else
            {
                MessageBox.Show(this, "Brak faktur do wyeksprotowania, najpierw dodaj jakąś fakturę", "Nie mogę eksprotować pliku", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        void ClickPanelaFaktur(object sender, EventArgs e)
        {
            tabelaFaktur.ClearSelection();
            WyczyscSzczegolyFaktury();
        }

        void ClickOknaKalendarzaFaktur(object sender, EventArgs e)
        {
            tabelaFaktur.ClearSelection();
            WyczyscSzczegolyFaktury();
        }

        void MenuStrip1Click(object sender, EventArgs e)
        {
            tabelaFaktur.ClearSelection();
            WyczyscSzczegolyFaktury();
        }

        void dodajFaktureToolStripMenuItemClick(object sender, EventArgs e)
        {
            _dodajFaktureForm = new DodajFakture(_kalendarzFaktur, this);
        }

        private void eksprotujFakturyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            EksprotujFaktury();
        }

        private void usuńFirmęZBazyPodpowiedziToolStripMenuItem_Click(object sender, EventArgs e)
        {
            _usunFirmeForm = new UsunFirme();
        }
    }
}