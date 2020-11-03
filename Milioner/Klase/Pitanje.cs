using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Milioner.Klase
{
    enum ponuda
    {
        A=0,
        B=1, 
        C=2, 
        D=3
    }
    class Pitanje
    {
        private string sadrzaj;
        private string[] odgovori;
        private int tacan;
        private int bodovi;

        public Pitanje(string sadrzaj,string odgovor1, string odgovor2, string odgovor3, string odgovor4, int tacan, int bodovi)
        {
            this.sadrzaj = sadrzaj;
            odgovori = new string[4] { odgovor1, odgovor2, odgovor3, odgovor4 };
            this.tacan = tacan - 1;
            this.bodovi = bodovi;
        }
        public bool Odgovor(ponuda clan, out int Bodovi)
        {
            
            if ((int)clan == tacan)
            {
                Bodovi = bodovi;
                return true;
            }
            else
            {
                Bodovi = 0;
                return false;
            }

        }

        public void IspisiPitanje()
        {
            Console.WriteLine(sadrzaj);
            Console.WriteLine("A: " + odgovori[0]);
            Console.WriteLine("B: " +odgovori[1]);
            Console.WriteLine("C: " +odgovori[2]);
            Console.WriteLine("D: "+odgovori[3]);

        }

        public static List<Pitanje> GenerisiBazu(int n)
        {

            if (n > 10)
                n = 10;
            if (n < 0)
                n = 1;
            
            Random random = new Random();

            List<Pitanje> baza = new List<Pitanje>();
            baza.Add(new Pitanje("Koje od ovih država su na obalama istog okeana?", "Južna Koreja i Indija", "Indija i Maroko", "Brazil i Francuska", "Brazil i Peru", 1, 100));
            baza.Add(new Pitanje("Gde se nalazi Fontana di trevi, poznata kao Fontana želja?", "Rimu", "Veroni", "Bratislavi", "ništa od navedenog", 1, 150));
            baza.Add(new Pitanje("Šta označava skraćenica V.I.P.?", "Mobilnu telefoniju", "Veoma važne osobe", "Veoma opasne osobe", "Vrati ili plati", 2, 80));
            baza.Add(new Pitanje("Koji od datih naziva nije naziv za internet čitač?", "Yahoo", "Mozilla Firefox", "Opera", "Google Chrome", 1, 100));
            baza.Add(new Pitanje("Kada kažemo „večni grad”, mislimo na:", "Pariz", "Rim", "Berlin", "London", 2, 100));
            baza.Add(new Pitanje("Šta je izumeo Aleksandar Fleming?", "Mikroskop", "Zakon održanja energije", "Rendgenske zrake", "Penicilin", 4, 100));
            baza.Add(new Pitanje("Poslovni partneri koji su sklopili barter aranžman su:", "Preduzeća iz iste zemlje, koja su ugovorila razmenu dobara, bez novčanih transakcija", "Preduzeća koja su ugovorom ograničila međusobnu konkurenciju", "Preduzeća iz različitih zemalja koja su ugovorila međusobnu razmenu dobara, bez novčanih transakcija", "Sklopili ugovor o međunarodnom transportu robe barama", 3, 200));
            baza.Add(new Pitanje("Pacemaker je", "Aparat za merenje pritiska", "Aparat za poboljšanje rada srca", "Borac za ljudska prava", "Trener u košarci", 2, 100));
            baza.Add(new Pitanje("Broj Pi (π) iznosi približno:", "3", "15", "3.14", "6,1", 3, 80));
            baza.Add(new Pitanje("Zaokruži zemlju koja nije članica EU?", "Belgija", "Švajcarska", "Poljska", "Hrvatska", 2, 70));
            List<int> niz = new List<int>();
            List<Pitanje> pitanja = new List<Pitanje>();
            int k = 0;
            for(int i=0; i<n; i++)
            {
                do
                {
                     k = random.Next(10);
                    if(!niz.Contains(k))
                    {
                        niz.Add(k);
                        break;
                    }

                }
                while (true);
                pitanja.Add(baza[k]);

            }
            return pitanja;
        }
    }
}
