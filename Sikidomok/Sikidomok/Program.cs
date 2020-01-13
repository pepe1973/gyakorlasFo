using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sikidomok
{
    class Program
    {
        static void Kiiras(Negyzet negy)
        {
            if (negy is Negyzet)
            {
                Console.WriteLine($"A negyzet kerülete: {(negy as Negyzet).KeruletSzamol()}");
            }
            else if (negy is Teglalap)
            {
                Console.WriteLine($"A negyzet kerülete: {(negy as Teglalap).KeruletSzamol()}");
            }
            
        }

        static void Main(string[] args)
        {
            /*Negyzet negyzet = new Negyzet(12);
            Console.WriteLine($"A négyzet kerülete: {negyzet.KeruletSzamol()}");
            Console.WriteLine($"A négyzet területe: {negyzet.TeruletSzamol()}");

            Teglalap teglalap = new Teglalap(12, 10);
            Console.WriteLine($"A téglalap kerülete: {teglalap.KeruletSzamol()}");
            Console.WriteLine($"A téglalap területe: {teglalap.TeruletSzamol()}");*/

            Negyzet negyzet = new Negyzet(10);
            Teglalap teglalap = new Teglalap(20, 30);

            Kiiras(negyzet);
            Kiiras(teglalap);

            Console.ReadKey(true);
        }
    }

    class Negyzet
    {
        public int AOldal { get; set; }

        public Negyzet()
        {

        }

        public Negyzet(int aoldal)
        {
            this.AOldal = aoldal;
        }

        public int TeruletSzamol()
        {
            return this.AOldal * this.AOldal;
        }

        public int KeruletSzamol()
        {
            return 4 * this.AOldal;
        }

        public void Kiir(Negyzet negy)
        {
            Console.WriteLine($"A negyzet kerülete: {negy.KeruletSzamol()}");
        }
    }

    class Teglalap : Negyzet
    {
        public int BOldal { get; set; }

        public Teglalap(int aOldal, int bOldal) : base(aOldal)
        {
            this.BOldal = bOldal;
        }

        public Teglalap()
        {

        }

        new public int TeruletSzamol()
        {
            return this.AOldal * this.BOldal;
        }

        new public int KeruletSzamol()
        {
            return 2 * (this.AOldal + this.BOldal);
        }

        new public void Kiir(Negyzet negy)
        {
            Console.WriteLine($"A negyzet kerülete: {negy.KeruletSzamol()}");
        }
    }
}
