using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Milioner.Klase;

namespace Milioner
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Gost> svi_Gosti = new List<Gost>();
            List<Igrac> svi_Igraci = new List<Igrac>();
            do
            {
                Console.WriteLine("Da li zelite da igrate kao igrac ili kao gost?");
                Console.WriteLine("A: Gost");
                Console.WriteLine("B: Igrac");
                char igrac = ' ';
                bool s = false;
                while (s == false)
                {
                    try
                    {
                        igrac = Convert.ToChar(Console.ReadLine().ToUpper());
                        if (igrac == 'A' || igrac == 'B')
                        { s = true; }
                        else
                            Console.WriteLine("Molimo odaberite A ili B kao odgovor");
                    }
                    catch
                    {
                        Console.WriteLine("Molimo unesite adekvatan odgovor");
                    }
                }

                switch (igrac)
                {
                    case 'A':
                        Console.Clear();
                        Gost gost = new Gost();
                        gost.Caos();
                        Igrica(gost, svi_Gosti);
                        break;

                    case 'B':
                        Console.Clear();
                        Igrac.Ispis();
                        string naziv = Console.ReadLine();
                        Igrac igracc = new Igrac(naziv);
                        Igrica(igracc, svi_Igraci);
                        break;
                }
                Console.Clear();
                Igrac.Ispis(Igrac.Kombinuj(svi_Igraci, svi_Gosti));
                Console.WriteLine("\nUnesite \"0\" kako bi ponovili igricu\nBilo sta drugo izlazi iz igrice");
                if (Console.ReadLine() != "0")
                    break;

            }
            while (true);
        }











        public static void Igrica(Gost obj, List<Gost> svi_G)
        {

            Console.WriteLine("\nGenerisace vam se 5 pitanja na koje morate tacno da odgovorite kako bi osvojili sve bodove koji vam se nude\nSrecno!!!");
            List<Pitanje> pitanja = Pitanje.GenerisiBazu(5);
            foreach (Pitanje pitanje in pitanja)
            {
                pitanje.IspisiPitanje();
                Console.WriteLine("Vas odgovor:");
                char odgovor = ' ';
                bool s = false;
                while (s == false)
                {
                    try
                    {
                        odgovor = Convert.ToChar(Console.ReadLine().ToUpper());
                        if (odgovor == 'A' || odgovor == 'B' || odgovor == 'C' || odgovor == 'D')
                        { s = true; }
                        else
                            Console.WriteLine("Molimo odaberite A ili B kao odgovor");
                    }
                    catch
                    {
                        Console.WriteLine("Molimo unesite adekvatan odgovor");
                    }
                }
                if (!obj.Odgovori(odgovor.ToString(), pitanje))
                {
                 
                    break;
                }
            }
            svi_G.Add(obj);
        }




        public static void Igrica(Igrac obj, List<Igrac> svi_I)
        {

            Console.WriteLine("\nGenerisace vam se 5 pitanja na koje morate tacno da odgovorite kako bi osvojili sve bodove koji vam se nude\nSrecno!!!");
            List<Pitanje> pitanja = Pitanje.GenerisiBazu(5);
            foreach (Pitanje pitanje in pitanja)
            {
                pitanje.IspisiPitanje();
                Console.WriteLine("Vas odgovor:");
                char odgovor = ' ';
                bool s = false;
                while (s == false)
                {
                    try
                    {
                        odgovor = Convert.ToChar(Console.ReadLine().ToUpper());
                        if (odgovor == 'A' || odgovor == 'B' || odgovor == 'C' || odgovor == 'D')
                        { s = true; }
                        else
                            Console.WriteLine("Molimo odaberite A ili B kao odgovor");
                    }
                    catch
                    {
                        Console.WriteLine("Molimo unesite adekvatan odgovor");
                    }
                }
                if (!obj.Odgovori(odgovor.ToString(), pitanje))
                {

                    break;
                }
            }
            svi_I.Add(obj);
        }
    }
}
