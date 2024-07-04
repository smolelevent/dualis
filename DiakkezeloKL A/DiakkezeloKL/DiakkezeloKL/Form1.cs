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

        List<Diak> diakok = new List<Diak>();
        List<CheckBox> chkBoxok = new List<CheckBox>();

        private int kezdoX = 20;
        private int kezdoY = 20;
        private int chkYkoz = 30;

        private void GombBeallitas(bool aktiv)
        {
            btnAdatbevitel.Enabled = !aktiv;
            btnKivalaszt.Enabled = !aktiv;
        }

        private void Adatbevitel()
        {
            DialogResult eredmeny = openFileDialog1.ShowDialog();
            if (eredmeny == DialogResult.OK) {
                string fajlNev = openFileDialog1.FileName;
                try {
                    AdatBeolvasas(fajlNev);
                    FelrakDiakok();
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

        private void Feldolgoz(string adat)
        {
            string[] adatok = adat.Split(';');
            Diak diak = new Diak(adatok[0], adatok[1], int.Parse(adatok[2]));
            diakok.Add(diak);
        }

        private void FelrakDiakok()
        {
            CheckBox chkBox;
            for (int i = 0; i < diakok.Count; i++)
            {
                chkBox = new CheckBox();
                chkBox.AutoSize = true;
                chkBox.Location = new Point(kezdoX, kezdoY + i * chkYkoz);
                chkBox.Text = diakok[i].ToString();

                pnlDiakok.Controls.Add(chkBox);
                chkBoxok.Add(chkBox);
            }
        }

        private void btnKivalaszt_Click(object sender, EventArgs e)
        {
            Kivalaszt();
        }

        private void Kivalaszt()
        {
            bool vanValasztott = false;
            lstKivalasztottak.Items.Clear();
            for (int i = 0; i < chkBoxok.Count; i++)
            {
                if (chkBoxok[i].Checked)
                {
                    lstKivalasztottak.Items.Add(diakok[i]);
                    vanValasztott = true;
                }
            }
            if (!vanValasztott) {
                MessageBox.Show("Senkit sem választott", "Hiba");
            } else {
                MinKeres();
            }
        }

        private void MinKeres()
        {
            lstLegidosebbek.Items.Clear();
            int min = (lstKivalasztottak.Items[0] as Diak).szulEv;
            foreach (Diak diak in lstKivalasztottak.Items)
            {
                if (diak.szulEv < min) min = diak.szulEv;
            }
            foreach (Diak diak in lstKivalasztottak.Items)
            {
                if (diak.szulEv == min) lstLegidosebbek.Items.Add(diak);
            }
        }

        private void lstKivalasztottak_SelectedIndexChanged(object sender, EventArgs e)
        {
            Diak diak = (Diak)lstKivalasztottak.SelectedItem;
            if (diak != null) lblDiak.Text = diak + ", születési éve: " + diak.szulEv;
        }

        private void btnAdatbevitel_Click(object sender, EventArgs e)
        {
            Adatbevitel();
        }
    }
}