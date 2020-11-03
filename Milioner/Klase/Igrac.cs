using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Schema;
using Milioner.Klase;

namespace Milioner.Klase
{
    class Igrac :Gost
    {
       
        
        public Igrac(string naziv)
        {
            this.naziv = naziv;
            osvojeniBrBodova = 0;
        }
        public Igrac(string naziv, int osvojeniBrBodova)
        {
            this.naziv = naziv;
            this.osvojeniBrBodova = osvojeniBrBodova;
        }
        public static void Ispis()
        {
            Console.WriteLine("Dobrodosli!\nMolimo vas da ispisete vase ime ispod:");
        }
        public static List<Igrac> Kombinuj(List<Igrac> igraci, List<Gost> gosti)
        {
            List<Igrac> treca = new List<Igrac>();
            treca.AddRange(igraci);
            foreach (Gost clan in gosti)
            {
                treca.Add(new Igrac(clan.Naziv, clan.OSVOJENI_BrBodova));
            }
            return treca;
        }
        public static void Ispis(List<Igrac> lista)
        {
            for(int i = 0; i<lista.Count-1; i++)
                for(int j = i+1; j<lista.Count; j++)
                {
                    if (lista[i].OSVOJENI_BrBodova> lista[j].OSVOJENI_BrBodova)
                    {
                        Igrac kanta = lista[j];
                        lista[j] = lista[i];
                        lista[i] = kanta;
                    }
                }
            lista.Reverse();
            Console.WriteLine("Bodovna lista:\n");
            for(int i = 0; i<lista.Count; i++)
            {
                Console.WriteLine(1+i + "......"+lista[i].Naziv + "    " + lista[i].OSVOJENI_BrBodova);
            }
            lista.Clear();
        }
        
      
    }
}
