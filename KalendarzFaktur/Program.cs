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
            File.Decrypt(_sciezkaDoZapisanychFaktur);
            File.Decrypt(_sciezkaDoBazyPodpowiedziFirm);
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new KalendarzFakturWindow());
            File.Encrypt(_sciezkaDoZapisanychFaktur);
            File.Encrypt(_sciezkaDoBazyPodpowiedziFirm);
        }
    }
}
