using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Allat_KL
{
    class Allat
    {
        //mezők
        public string nev;
        private int szuletesiEv;

        private int szepsegPont, viselkedesPont;
        private int pontSzam;

        private static int aktualisEv;
        private static int korHatar;

        //konstruktor
        public Allat(string nev, int szuletesiEv)
        {
            this.nev = nev;
            this.szuletesiEv = szuletesiEv;
        }

        //metódusok
        public int Kor() {
            return aktualisEv - szuletesiEv;
        }

        public void Pontozzak(int szepsegPont, int viselkedesPont) {
            this.szepsegPont = szepsegPont;
            this.viselkedesPont = viselkedesPont;
            if (Kor() <= korHatar) {
                pontSzam = viselkedesPont * Kor() + szepsegPont * (korHatar - Kor());
            } else {
                pontSzam = 0;
            }
        }

        public override string ToString()
        {
            return "Név:" + Nev + " pontszáma: " + PontSzam + " pont";
        }

        //tulajdonságok
        //kívűlről nem változtatható értékek
        public string Nev {
            get { return nev; }
        }
        public int SzuletesiEv {
            get { return szuletesiEv; }
        }

        public int SzepsegPont {
            get { return szepsegPont; }
        }

        public int ViselkedesPont {
            get { return viselkedesPont; }
        }

        public int PontSzam {
            get { return pontSzam; }
        }

        //kívűlről változtatható értékek
        public static int AktualisEv {
            get { return aktualisEv; }
            set { aktualisEv = value; }
        }

        public static int KorHatar {
            get { return korHatar; }
            set { korHatar = value; }
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
