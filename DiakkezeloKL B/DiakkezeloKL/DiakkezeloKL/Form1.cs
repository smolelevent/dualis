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

namespace DiakkezeloKL
{
    public partial class Form1 : Form
    {
        class Diak
        {
            private string Nev { get; set; }
            private string tanulKod { get; set; }
            public int szulEv { get; set; }

            public Diak(string nev, string tanulKod, int szulEv)
            {
                Nev = nev;
                this.tanulKod = tanulKod;
                this.szulEv = szulEv;
            }

            public override string ToString()
            {
                return Nev + tanulKod + szulEv;
            }
        }

        public Form1()
        {
            InitializeComponent();
            openFileDialog1.InitialDirectory = Environment.CurrentDirectory;
            openFileDialog1.FileName = "";
            GombBeallitas(false);
        }

        List<int> evek = new List<int>();
        List<Diak> diakok = new List<Diak>();
        List<CheckBox> chkBoxok = new List<CheckBox>();
        List<Button> btnEvek = new List<Button>();

        private int kezdoX = 20;
        private int kezdoY = 20;
        private int chkYkoz = 30;
        private int btnXKoz = 50;

        private void Feldolgoz(string adat)
        {
            string[] adatok = adat.Split(';');
            Diak diak = new Diak(adatok[0], adatok[1], int.Parse(adatok[2]));
            diakok.Add(diak);
            if(!evek.Contains(diak.szulEv)) evek.Add(diak.szulEv);
        }

        private void FelrakEvek()
        {
            Button btn;
            evek.Sort();
            for(int i = 0; i < evek.Count; i++)
            {
                btn = new Button();
                btn.Location = new Point(kezdoX + i * btnXKoz, kezdoY);
                btn.Text = evek[i].ToString();
                btn.Click += new System.EventHandler(Kivalaszt);

                pnlEvek.Controls.Add(btn);
                btnEvek.Add(btn);
            }
        }

        private void Kivalaszt(object sender, EventArgs e)
        {
            int ev = int.Parse((sender as Button).Text);
            lstEredmenyek.Items.Clear();
            foreach(Diak diak in lstDiakok.Items)
            {
                if(diak.szulEv == ev) lstEredmenyek.Items.Add(diak);
            }
        }

        private void GombBeallitas(bool aktiv)
        {
            btnAdatbevitel.Enabled = !aktiv;
        }

        private void Adatbevitel()
        {
            DialogResult eredmeny = openFileDialog1.ShowDialog();
            if (eredmeny == DialogResult.OK) {
                string fajlNev = openFileDialog1.FileName;
                try {
                    AdatBeolvasas(fajlNev);
                    GombBeallitas(true);
                }
                catch (Exception) {
                    MessageBox.Show("Hiba a fájl beolvasásakor", "Hiba");
                }
            }
        }

        private void AdatBeolvasas(string fajlnev)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                fajlnev = openFileDialog1.FileName;
                StreamReader sr = new StreamReader(fajlnev);
                string adat;
                while (!sr.EndOfStream)
                {
                    adat = sr.ReadLine();
                    Feldolgoz(adat);
                }                    
            }
        }

        private void btnAdatbevitel_Click(object sender, EventArgs e)
        {
            Adatbevitel();
        }
    }
}