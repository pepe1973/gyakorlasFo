using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OsztalyokEgy
{
    class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine($"Évfolyam: {Ember.evfolyam}, osztály: {Ember.osztaly}");
            //Ember.KiirOsztaly();
            /*Ember[] emberTomb = new Ember[2];

            for (int i = 0; i < 2; i++)
            {
                bool letezik = false;
                Console.Write("Kérem a magasságot: ");
                int magassag = Int32.Parse(Console.ReadLine());
                Console.Write("Kérem a testsúlyt: ");
                int testsuly = Int32.Parse(Console.ReadLine());
                Console.Write("Kérem a születési évet: ");
                string szuletesiEv = Console.ReadLine();
                Ember ember = new Ember();
                try
                {
                    ember = new Ember(magassag, testsuly, szuletesiEv);
                }
                catch (ArgumentException e)
                {
                    Console.WriteLine(e.Message);
                    letezik = true;
                }
                
                emberTomb[i] = ember;
                ember.Kiir(i + 1);
                Console.WriteLine($"Az {i + 1}. ember magassága: {ember.GetMagassag()} centiméter.");
                Console.WriteLine($"Az {i + 1}. ember testsúlya: {ember.GetTestsuly()} kilogram.");
                Console.WriteLine("Az {i + 1}. ember születési éve: {ember.GetSzuletesiEv()}.");
                if (letezik) i--;
            }

            for (int i = 0; i < emberTomb.Length; i++)
            {
                Console.WriteLine($"Az {i + 1}. ember magassága: {emberTomb[i].Magassag} centiméter.");
                Console.WriteLine($"Az {i + 1}. ember testsúlya: {emberTomb[i].Testsuly} kilogram.");
                Console.WriteLine($"Az {i + 1}. ember születési éve: {emberTomb[i].SzuletesiEv}.");
            }

            Console.Write("Második ember új magassága: ");
            int ujMagassag = Convert.ToInt32(Console.ReadLine());

            try
            {
                emberTomb[1].SetMagassag(ujMagassag);
            }
            catch (ArgumentException e)
            {
                Console.WriteLine(e.Message);
            }

            emberTomb[1].Kiir(2);*/
            
            try
            {
                Fiu fiu = new Fiu(176, -65, "2001.01.07", false);
                fiu.Kiir(fiu.SzemelyiSzamEgyesE);
            }
            catch (ArgumentException e)
            {
                Console.WriteLine(e.Message);
            }
            
            

            Console.ReadKey(true);
        }
    }

    class Ember
    {
        protected int magassag;
        protected int testsuly;
        protected string szuletesiEv;
        static public string osztaly = "Szoftverfejlesztő";
        static public int evfolyam = 13;

        public int Magassag
        {
            get { return this.magassag; }
            set {
                if (value < 0 || value > 450)
                    throw new ArgumentException("Nem jó magasság érték!");
                this.magassag = value;
            }
        }

        public int Testsuly
        {
            get { return this.testsuly; }
            set {
                if (Testsuly < 0)
                    throw new ArgumentException("Nem jó testsúly érték!");
                this.testsuly = value;
            }
        }

        public string SzuletesiEv
        {
            get { return this.szuletesiEv; }
            set { this.szuletesiEv = value; }
        }

        public Ember(int Magassag, int Testsuly, string SzuletesiEv)
        {
            if (Magassag < 0 || Magassag > 450)
                throw new ArgumentException("Nem jó magasság érték!");
            if (Testsuly < 0)
                throw new ArgumentException("Nem jó testsúly érték!");
            this.magassag = Magassag;          
            this.testsuly = Testsuly;
            this.szuletesiEv = SzuletesiEv;
        }

        public Ember()
        {

        }

        public int GetMagassag()
        {
            return this.magassag;
        }

        public void SetMagassag(int value)
        {
            if (value < 0 || value > 450)
                throw new ArgumentException("Nem jó magasságérték!");
            this.magassag = value;
        }

        public int GetTestsuly()
        {
            return this.testsuly;
        }

        public void SetTestsuly(int value)
        {
            if (value < 0)
                throw new ArgumentException("Nem jó testsúlyérték!");
            this.testsuly = value;
        }

        public string GetSzuletesiEv()
        {
            return this.szuletesiEv;
        }

        public void SetSzuletesiEv(string value)
        {
            this.szuletesiEv = value;
        }

        public void Kiir(int i)
        {
            Console.WriteLine($"Az {i}. ember magassága: {this.magassag}");
            Console.WriteLine($"Az {i}. ember testsúlya: {this.testsuly}");
            Console.WriteLine($"Az {i}. ember születési éve: {this.szuletesiEv}");
            Console.WriteLine($"Az {i}. ember osztálya: {evfolyam}/{osztaly}");
        }

        public void Kiir(bool ertek)
        {
            Console.WriteLine($"Az ember magassága: {this.magassag}");
            Console.WriteLine($"Az ember testsúlya: {this.testsuly}");
            Console.WriteLine($"Az ember születési éve: {this.szuletesiEv}");
            if (ertek)
            {
                Console.WriteLine($"Az ember fiú.");
            }
            else
            {
                Console.WriteLine($"Az ember lány.");
            }
        }

        static public void KiirOsztaly()
        {
            Console.WriteLine($"Évfolyam: {evfolyam}, osztály: {osztaly}");
        } 
    }
}
