using System;
using System.IO;
using System.Windows.Forms;

namespace KalendarzFaktur
{
    static class Program
    {
        const string _sciezkaDoZapisanychFaktur = "faktury.json";
        const string _sciezkaDoBazyPodpowiedziFirm = "firmy.json";
        [STAThread]
        static void Main()
        {
            if (File.Exists(_sciezkaDoZapisanychFaktur))
                File.Decrypt(_sciezkaDoZapisanychFaktur);
            if (File.Exists(_sciezkaDoBazyPodpowiedziFirm))
                File.Decrypt(_sciezkaDoBazyPodpowiedziFirm);
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new KalendarzFakturWindow());
            if (File.Exists(_sciezkaDoZapisanychFaktur))
                File.Encrypt(_sciezkaDoZapisanychFaktur);
            if (File.Exists(_sciezkaDoBazyPodpowiedziFirm))
                File.Encrypt(_sciezkaDoBazyPodpowiedziFirm);
        }
    }
}
