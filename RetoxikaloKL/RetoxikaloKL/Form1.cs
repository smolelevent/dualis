using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RetoxikaloKL
{
    public partial class BetoltoForm : Form
    {
        public class Ital
        {
            public string ItalNev { get; private set; }
            public int EgysegAr { get; set; }

            public Ital(string italNev, int egysegAr)
            {
                ItalNev = italNev;
                EgysegAr = egysegAr;
            }
        }

        private List<Ital> italok = new List<Ital>();
        private List<Image> kepek = new List<Image>();
        private int kepekSzama = 5;

        private ItalLapForm italForm = new ItalLapForm();
        


        public BetoltoForm()
        {
            InitializeComponent();
            openFileDialog1.InitialDirectory = Environment.CurrentDirectory;
            openFileDialog1.FileName = "arlap.txt";
            saveFileDialog1.InitialDirectory = Environment.CurrentDirectory;
            saveFileDialog1.FileName = "konyveles.txt";
        }

        private void BetoltoForm_Load(object sender, EventArgs e)
        {
            try
            {
                KepBetoltes();
            }
            catch (Exception)
            {
                MessageBox.Show("Hiba a képek létrehozásakor", "hiba");
            }
        }

        private void KepBetoltes()
        {
            Image kep;
            for (int i = 1; i < kepekSzama; i++)
            {
                kep = Image.FromFile("kep" + i + ".jpg");
                kepek.Add(kep);
            }
        }

        private void openMenuItem_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                StreamReader olvasoCsatorna = null;
                try
                {
                    string fajlNev = openFileDialog1.FileName;
                    olvasoCsatorna = new StreamReader(fajlNev);

                    AdatBevitel(olvasoCsatorna);

                    italForm.ArlapotIr(italok);
                    italForm.Show();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "hibaüzenet a fejlesztő számára");
                }
                finally
                {
                    if (olvasoCsatorna != null)
                    {
                        olvasoCsatorna.Close();
                    }
                }
            }
        }

        private void AdatBevitel(StreamReader olvasoCsatorna)
        {
            string sor = olvasoCsatorna.ReadLine();
            string[] adatok;
            while(sor != null)
            {
                adatok = sor.Split(';');
                italok.Add(new Ital(adatok[0], int.Parse(adatok[1])));
                sor = olvasoCsatorna.ReadLine();
            }
        }

        private void ItallapMenuItem_Click(object sender, EventArgs e)
        {
            italForm.ArlapotIr(italok);
            italForm.ShowDialog();
        }
    }
}
