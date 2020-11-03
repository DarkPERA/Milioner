using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Milioner.Klase
{
    class Gost 
    {
        protected string naziv;
        protected int osvojeniBrBodova;
        public int OSVOJENI_BrBodova
        {
            get { return osvojeniBrBodova; }
        }
        public string Naziv
        {
            get { return naziv; }
        }
        public Gost()
        {
            string k = null;
            Random random = new Random();
            for (int i = 0; i<=5; i++)
            {
                k = k + (char)random.Next(63, 123);
            }
            naziv = "Gost_"+k;
            osvojeniBrBodova = 0;
        }
        public void Caos()
        {
            Console.WriteLine("Dobrodosli!\nVase ime je:\n"+ naziv);
        }
        public bool Odgovori(string odgovor, Pitanje obj)
        {

            if (obj.Odgovor((ponuda)Enum.Parse(typeof(ponuda), odgovor), out int Bodovi) == true)
            {
                osvojeniBrBodova += Bodovi;
                Console.WriteLine("Svaka cast, odgovorili ste tacno na pitanje!\nOsvojili ste " + Bodovi + " bodova!");
                return true;
            }
            else
                return false;

        }

    }
}
