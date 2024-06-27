using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Allat_KL
{
    class Allat
    {
        //mezők és tulajdonságok helyett automatikus tulajdonságok:
        public string Nev { get; private set; }
        public int SzuletesiEv { get; private set; }
        public int RajtSzam { get; private set; }

        public int SzepsegPont { get; private set; }
        public int ViselkedesPont { get; private set; }

        public int Pontszam { get; protected set; }
        public static int AktualisEv { get; set; }
        public static int KorHatar { get; set; }

        //konstruktor
        //mivel nincsenek mezők, értékadáskor a tulajdonság kap értéket
        public Allat(int rajtSzam, string nev, int szuletesiEv)
        {
            this.RajtSzam = rajtSzam;
            this.Nev = nev;
            this.SzuletesiEv = szuletesiEv;
        }

        //metódusok
        public int Kor() {
            return AktualisEv - SzuletesiEv;
        }

        public virtual void Pontozzak(int szepsegPont, int viselkedesPont) {
            this.SzepsegPont = szepsegPont;
            this.ViselkedesPont = viselkedesPont;
            if (Kor() < KorHatar)
            {
                PontSzam = viselkedesPont * Kor() + szepsegPont * (KorHatar - Kor());
            } else
            {
                PontSzam = 0;
            }
        }

        // a ToString() így majd kisebtűsen kiírja az osztályneveket is.
        public override string ToString()
        {
            return RajtSzam + ". " + Nev + " nevű "
                    + this.GetType().Name.ToLower()
                    + " pontszáma: " + PontSzam() + " pont";
        }
    }

    class Kutya : Allat
    {
        public int GazdaViszonyPont { get; private set; }
        public bool KapottViszonyPontot { get; private set; }

        public Kutya(int rajtSzam, string nev, int szulEv) : base(rajtSzam, nev, szulEv)
        {
        }

        public void ViszonyPontozas(int gazdaViszonyPont)
        {
            this.GazdaViszonyPont = gazdaViszonyPont;
            KapottViszonyPontot = true;
        }

        public override void Pontozzak(int szepsegPont, int viselkedesPont)
        {
            if (KapottViszonyPontot)
            {
                base.Pontozzak(szepsegPont, viselkedesPont);
                this.Pontszam += GazdaViszonyPont;
            }
        }
    }

    class Macska : Allat
    {
        public bool VanMacskaSzallitoDoboz { get; set; }
        public Macska(int rajtSzam, string nev, int szulEv, bool vanMacskaSzallitoDoboz) : base(rajtSzam, nev, szulEv)
        {
            this.VanMacskaSzallitoDoboz = vanMacskaSzallitoDoboz;
        }

        public override void Pontozzak(int szepsegPont, int viselkedesPont)
        {
            if (VanMacskaSzallitoDoboz)
            {
                base.Pontozzak(szepsegPont, viselkedesPont);
            }
        }
    }

    class Vezerles
    {
        private List<Allat> allatok = new List<Allat>();
        public void Start()
        {
            Allat.AktualisEv = 2015;
            Allat.KorHatar = 10;
            Proba();
            Regisztracio();
            Kiiratas("A regisztrált versenyzők");
            Verseny();
            Kiiratas("A verseny eredménye");
        }

        private void Proba()
        {
            Allat allat1, allat2;
            string nev1 = "Pamacs", nev2 = "Bolhazsák";
            int szulEv1 = 2010, szulEv2 = 2011;
            bool vanDoboz = true;
            int rajtSzam = 1;

            int szepsegPont = 5, viselkedesPont = 4; viszonyPont = 6;

            allat1 = new Kutya(rajtSzam, nev1, szulEv1);
            rajtSzam++;

            allat2 = new Macska(rajtSzam, nev2, szulEv2, vanDoboz);



            allat1.Pontozzak(szepsegPont, viselkedesPont);

            Console.WriteLine("A regisztrált állatok: ");
            Console.WriteLine(allat1);
            Console.WriteLine(allat2);

            //verseny
            allat2.Pontozzak(szepsegPont, viselkedesPont);
            if (allat1 is Kutya)
            {
                (allat1 as Kutya).ViszonyPontozas(viszonyPont);
            }

            Console.WriteLine("\nA verseny eredménye: ");
            Console.WriteLine(allat1);
            Console.WriteLine(allat2);
        }

        private void Regisztracio()
        {
            StreamReader olvasoCsatorna = new StreamReader("allatok.txt");
            string fajta, nev;
            int rajtszam = 1, szulEv;
            bool vanDoboz;

            while (!olvasoCsatorna.EndOfStream)
            {
                fajta = olvasoCsatorna.ReadLine();
                nev = olvasoCsatorna.ReadLine();
                szulEv = int.Parse(olvasoCsatorna.ReadLine());

                if (fajta == "kutya")
                {
                    allatok.Add(new Kutya(rajtszam, nev, szulEv));
                } else
                {
                    vanDoboz = bool.Parse(olvasoCsatorna.ReadLine());
                    allatok.Add(new Macska(rajtszam, nev, szulEv, vanDoboz));
                }
                rajtszam++;
            }
            olvasoCsatorna.Close();
        }

        private void Verseny()
        {
            Random rand = new Random();
            int hatar = 11;
            foreach (Allat item in allatok)
            {
                if(item is Kutya)
                {
                    (item as Kutya).ViszonyPontozas(rand.Next(hatar));
                }
                item.Pontozzak(rand.Next(hatar), rand.Next(hatar));
            }
        }
    }

internal class Program
    {
        private static void Main(string[] args)
        {
            //allat nevű változó deklarálása
            Allat allat;

            string nev;
            int szulEv;
            int szepseg, viselkedes;
            int veletlenPontHatar = 10;

            //egy random példány létrehozása
            Random rand = new Random();

            //számoláshoz szükséges kezdőértékek beállítása
            int osszesVersenyzo = 0;
            int osszesPont = 0;
            int legtobbPont = 0;

            Console.WriteLine("Kezdődik a verseny");

            char tovabb = 'i';
            while (tovabb == 'i')
            {
                Console.Write("Az állat neve: ");
                nev = Console.ReadLine();

                Console.Write("születési éve: ");
                while (!int.TryParse(Console.ReadLine(), out szulEv))
                    if(szulEv <= 0 || szulEv > Allat.AktualisEv)
                {
                        Console.WriteLine("Az eredmény jó.");
                } else {
                        Console.Write("Hibás adat, kérem újra.");
                }

                // véletlen pontértékek
                szepseg = rand.Next(veletlenPontHatar + 1);
                viselkedes = rand.Next(veletlenPontHatar + 1);

                //az állat példány létrehozása
                allat = new Allat(nev, szulEv);

                // a pontozási metódus meghívása
                allat.Pontozzak(szepseg, viselkedes);

                Console.WriteLine(allat);

                //számítások
                osszesVersenyzo++;
                osszesPont += allat.PontSzam;
                if (legtobbPont < allat.PontSzam)
                {
                    legtobbPont = allat.PontSzam;
                }

                Console.Write("Van még állat? (i/n) ");

                // alakítsa át ellenőrzött beolvasásra
                tovabb = char.Parse(Console.ReadLine());

                //eredmény kiíratása
                Console.WriteLine("\nÖsszesen " + osszesVersenyzo + " versenyző volt," + "\nösszpontszámuk: " + osszesPont + " pont," + "\nlegnagyobb pontszám: " + legtobbPont);
            }
        }
    }
}
