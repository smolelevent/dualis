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

namespace PizzeriaKL
{
    public partial class PizzaForm : Form
    {
        private bool lathato;
        private List<Pizza> pizzak = new List<Pizza>();
        private List<CheckBox> jeloloNegyzetek = new List<CheckBox>();
        private List<RadioButton> rdBtnKicsiArak = new List<RadioButton>();
        private List<RadioButton> rdBtnNagyArak = new List<RadioButton>();
        private List<TextBox> txtDarabok = new List<TextBox>();


        private int bal = 20, fent = 10;
        private int kozY = 40;
        private int meretY = 20;
        private int panelX = 200;
        private int meretChk = 120;
        private int meretAr = 50;
        private int meretFt = 40;
        private int meretDb = 50;
        private int koz = 3;

        private void ValasztekFeltoltes()
        {
            CheckBox checkBox;
            Label label;
            Label label2;
            RadioButton radioButton;
            RadioButton radioButton2;
            Panel panel;
            TextBox textBox;

            for (int i = 0; i < pizzak.Count; i++)
            {
                panel = new Panel();
                panel.Size = new Size(panelX, meretY);
                panel.Location = new Point(bal + meretChk, fent + i * kozY);
                pnlKozponti.Controls.Add(panel);

                checkBox = new CheckBox();
                checkBox.TextAlign = ContentAlignment.MiddleLeft;
                checkBox.Text = pizzak[i].Nev;
                checkBox.Location = new Point(bal, fent + i * kozY);
                checkBox.Size = new Size(meretChk, meretY);
                jeloloNegyzetek.Add(checkBox);
                pnlKozponti.Controls.Add(checkBox);

                radioButton = new RadioButton();
                radioButton.Size = new Size(meretAr, meretY);
                radioButton.TextAlign = ContentAlignment.MiddleLeft;
                radioButton.Text = pizzak[i].ArKicsi.ToString();
                radioButton.Location = new Point(0, 0);
                rdBtnKicsiArak.Add(radioButton);
                panel.Controls.Add(radioButton);

                label = new Label();
                label.TextAlign = ContentAlignment.MiddleLeft;
                label.Text = "Ft";
                label.Location = new Point(meretAr + koz, 0);
                label.Size = new Size(meretFt, meretY);
                panel.Controls.Add(label);

                
                radioButton2 = new RadioButton();
                radioButton2.Size = new Size(meretAr + 20, meretY);
                radioButton2.TextAlign = ContentAlignment.MiddleLeft;
                radioButton2.Text = pizzak[i].ArNagy.ToString();
                radioButton2.Location = new Point(0, 0);
                rdBtnNagyArak.Add(radioButton2);
                panel.Controls.Add(radioButton2);

                label2 = new Label();
                label2.TextAlign = ContentAlignment.MiddleLeft;
                label2.Text = "Ft";
                label2.Location = new Point(meretAr + koz + 20, 0);
                label2.Size = new Size(meretFt, meretY);
                panel.Controls.Add(label);

                
                textBox = new TextBox();
                textBox.Size = new Size(meretDb, meretY);
                textBox.Location = new Point(30, 0);
                txtDarabok.Add(textBox);
                panel.Controls.Add(textBox);

                label2 = new Label();
                label2.TextAlign = ContentAlignment.MiddleLeft;
                label2.Text = "Ft";
                label2.Location = new Point(meretAr + koz + 30, 0);
                label2.Size = new Size(meretFt, meretY);
                panel.Controls.Add(label);
                

                //befejezetlen a radio gomb, a fixelt ft-n, a db szám, és a felirat
            }
        }


        class Pizza
        {
            public string Nev { get; private set; }
            public int ArKicsi { get; set; }
            public int ArNagy { get; set; }

            public Pizza(string nev, int arKicsi, int arNagy)
            {
                Nev = nev;
                ArKicsi = arKicsi;
                ArNagy = arNagy;
            }

            public override string ToString()
            {
                return this.Nev;
            }
        }

        public PizzaForm()
        {
            InitializeComponent();
            openFileDialog1.InitialDirectory = Environment.CurrentDirectory;
            openFileDialog1.FileName = "";
            lathato = false;
            LathatosagBeallitasa(lathato);
        }


        private void btnAdatBe_Click(object sender, EventArgs e)
        {
            DialogResult result = openFileDialog1.ShowDialog();
            if (result == DialogResult.OK)
            {
                StreamReader olvasoCsatorna = null;
                try
                {
                    string fajlNev = openFileDialog1.FileName;
                    olvasoCsatorna = new StreamReader(fajlNev);

                    AdatBeolvasas(olvasoCsatorna);
                    ValasztekFeltoltes();

                    lathato = true;
                    LathatosagBeallitasa(lathato);
                    btnAdatBe.Visible = false;
                } catch (Exception ex) {
                    MessageBox.Show(ex.Message, "hibaüzenet a fejlesztő számára");
                } finally {
                    if(olvasoCsatorna != null) {
                        olvasoCsatorna.Close();
                    }
                }
            }
        }

        private void AdatBevitel()
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK) {
                StreamReader olvasoCsatorna = null;
                try
                {
                    string fajlNev = openFileDialog1.FileName;
                    olvasoCsatorna = new StreamReader(fajlNev);
                    AdatBeolvasas(olvasoCsatorna);
                } catch (Exception) {
                    MessageBox.Show("Adatbeviteli hiba", "Hiba");
                } finally {
                    if (olvasoCsatorna != null) {
                        olvasoCsatorna.Close();
                    }
                }
            }
        }

        private void AdatBeolvasas(StreamReader olvasoCsatorna)
        {
            string adat;
            while (!olvasoCsatorna.EndOfStream)
            {
                adat = olvasoCsatorna.ReadLine();
                Feldolgoz(adat);
            }
        }

        private void Feldolgoz(string adat)
        {
            string[] adatok = adat.Split(';');
            pizzak.Add(new Pizza(adatok[0], int.Parse(adatok[1]), int.Parse(adatok[2])));
        }

        /*
        private void ElemekMegjelenitese()
        {
            lblKicsi.Text = meretKicsi + " cm";
            lblNagy.Text = meretNagy + " cm";

            checkBox1.Text = pizzak[0].Nev;
            rdBtn1Kicsi.Text = pizzak[0].ArKicsi + " Ft";
            rdBtn1Nagy.Text = pizzak[0].ArNagy + " Ft";

            checkBox2.Text = pizzak[1].Nev;
            rdBtn2Kicsi.Text = pizzak[1].ArKicsi + " Ft";
            rdBtn2Nagy.Text = pizzak[1].ArNagy + " Ft";
        }*/

        private void btnTorol_Click(object sender, EventArgs e)
        {
            foreach (Control item in this.Controls)
            {
                if (item is CheckBox) (item as CheckBox).Checked = false;
                if (item is TextBox) ((TextBox)item).Clear();
                if (item.HasChildren)
                {
                    foreach (Control gyerek in item.Controls)
                    {
                        if (gyerek is RadioButton) (gyerek as RadioButton).Checked = false;
                    }
                }
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            LathatosagBeallitasa(false);
        }

        private void LathatosagBeallitasa(bool lathatoE)
        {
            foreach(Control item in this.Controls)
            {
                item.Visible = lathatoE;
            }
            btnAdatBe.Visible = !lathatoE;
        }

        private void btnSzamol_Click(object sender, EventArgs e)
        {
            bool vanKijeloles = false;
            int db = 0, osszeg = 0, ar = 0;

            for (int i = 0; i < jeloloNegyzetek.Count; i++)
            {
                if (jeloloNegyzetek[i].Checked) {
                    vanKijeloles = true;
                    try
                    {
                        if (rdBtnKicsiArak[i].Checked) ar = pizzak[i].ArKicsi;
                        else if (rdBtnNagyArak[i].Checked) ar = pizzak[i].ArNagy;
                        else throw new MissingFieldException();

                        db = int.Parse(txtDarabok[i].Text);

                        if (db < 0) throw new Exception();
                        txtDarabok[i].BackColor = Color.White;
                        osszeg += ar * db;
                    } catch (MissingFieldException)
                    {
                        MessageBox.Show("Nem választott méretet", "Hiba");
                    } catch (Exception)
                    {
                        MessageBox.Show("Hibásan adta meg a darabszámot", "Hiba");
                        txtDarabok[i].BackColor = Color.Coral;
                        txtDarabok[i].Clear();
                    }
                }
            }
            if (!vanKijeloles) MessageBox.Show("Nincs kijelölve semmi", "Figyelmeztetes");
            else txtFizetendo.Text = osszeg + " Ft"; 
        }
    }
}