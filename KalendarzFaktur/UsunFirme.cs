using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace KalendarzFaktur
{
    public partial class UsunFirme : Form
    {
        const string _sciezkaDoBazyPodpowiedziFirm = "firmy.json";
        readonly List<string> _firmy;
        
        public UsunFirme()
        {
            InitializeComponent();
            if (File.Exists(_sciezkaDoBazyPodpowiedziFirm))
            {
                _firmy = WczytajFirmy();
            }
            else
            {
                _firmy = new List<string>();
            }
            AktualizujFirmyWComboBox();
            this.ShowDialog();
        }

        public void AktualizujFirmyWComboBox()
        {
            foreach (string f in _firmy)
            {
                firmaComboBox.Items.Add(f);
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

        private void usunFirmeButton_Click(object sender, EventArgs e)
        {
            bool znalezionoFirme = false;
            var firma = firmaComboBox.Text;
            var wynik = MessageBox.Show("Czy jesteś pewien, że chcesz usunąć firmę z '" + firma + "' z bazy podpowiedzi?!", "", MessageBoxButtons.YesNo);
            if (wynik == DialogResult.Yes)
            {
                foreach (string f in _firmy)
                {
                    if (f == firma)
                        znalezionoFirme = true;
                }
                if(znalezionoFirme)
                {
                    _firmy.Remove(firma);
                    firmaComboBox.Items.Remove(firma);
                    File.Delete(_sciezkaDoBazyPodpowiedziFirm);
                    var streamWriter = new StreamWriter(_sciezkaDoBazyPodpowiedziFirm);
                    var serializowane = JsonConvert.SerializeObject(_firmy, Formatting.Indented);
                    streamWriter.Write(serializowane);
                    streamWriter.Close();
                }
                else
                {
                    MessageBox.Show("Nie znaleziono żadnej firmy o nazwie '" + firma + "'!");
                }
            }
        }
    }
}
