using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Attekintes
{
    class Program
    {
        static void Main(string[] args)
        {
            HaziKedvenc hk = new HaziKedvenc();
            hk.Neme = "lány";
            Console.WriteLine($"A házikedvenc neme: {hk.Neme}");

            HaziKedvenc hk2 = new HaziKedvenc();
            hk2.Megvaltoztat("fiú");
            Console.WriteLine($"A házikedvenc neme: {hk2.Neme}");

            Console.ReadKey(true);
        }
    }

    class HaziKedvenc
    {
        // mező adattag
        private string neme;

        // mező property-je
        public string Neme
        {
            get { return this.neme; }
            set { this.neme = value; }
        }

        //public string Neme { get; set; }

        public void Megvaltoztat(string ertek)
        {
            this.neme = ertek;
            Console.WriteLine($"A kedvenc neme: {this.neme}");
        }
    }
}
