using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ismetles
{
    enum Napok { Hétfő = 12, Kedd, Szerda = 123, Csütörtök, Péntek, Szombat, Vasárnap }
    class Program
    {
        enum Honap { Január, Február, Március }
        static void Main(string[] args)
        {
            /* Két egész szám (<= 10) összegik.
            int szam = 1;
            int masikSzam = 1;
            bool kiertekel = true;
            bool masikKiertekel = true;

            while ((kiertekel || masikKiertekel) && (szam + masikSzam <= 10))
            {
                Console.Write("Kérek egy egész számot: ");
                kiertekel = !Int32.TryParse(Console.ReadLine(), out szam);
                Console.Write("Kérek egy másik egész számot: ");
                masikKiertekel = !Int32.TryParse(Console.ReadLine(), out masikSzam);
                if (szam + masikSzam > 10)
                {
                    kiertekel = true;
                    masikKiertekel = true;
                    szam = 1;
                    masikSzam = 1;
                }
            }

            Console.WriteLine($"A két szám összege: {szam + masikSzam}");
            */

            /* Addig pozitív egész számok, amig összegük kisebb, mint 100

            int osszeg = 0;
            int darabSzam = 0;
            int szam = 0;

            while (osszeg <= 100)
            {
                Console.Write("Kérek egy pozitív egész számot: ");
                szam = Convert.ToInt32(Console.ReadLine());
                osszeg += szam;
                ++darabSzam;
            }

            Console.WriteLine($"A számok darabszáma: {--darabSzam}, összegük: {osszeg - szam}");
            */

            /* Addig stringek, amig összhosszuk kisebb, mint 10

            string kimenet = "";
            int stringOsszHossz = 0;
            int darabszam = 0;

            Console.Write("Milyen hosszú lehet a string: ");
            int ekkoraLehetAString = Int32.Parse(Console.ReadLine());
         
            while (stringOsszHossz <= ekkoraLehetAString)
            {
                Console.Write("Kérek egy stringet: ");
                string beker = Console.ReadLine();
                int hossz = beker.Length;
                if (stringOsszHossz + hossz <= ekkoraLehetAString)
                {
                    stringOsszHossz += hossz;
                    kimenet += beker;
                    darabszam++;
                }
                else { break; }
            }

            Console.WriteLine($"A bekért stringek száma: {darabszam}.");
            Console.WriteLine($"Az eredő string: {kimenet}");
            */

            /* n! do while-lal megoldva

            Console.Write("Kérek egy pozitív egész számot 20-ig: ");
            int szam = Int32.Parse(Console.ReadLine());

            int faktorialis = 1;
            int index = 1;

            do
            {
                faktorialis *= index++;
            } while (index <= szam);

            Console.WriteLine($"{szam}! = {faktorialis}");
            */

            /* Binomiális együtthatók: n = 5 esetén
                      
            for (int k = 1; k < 7; k++)
            {
                Console.SetCursorPosition(k * 7, 0);
                Console.Write($"k = {k - 1}");
            }

            for (int n = 1; n < 7; n++)
            {
                Console.SetCursorPosition(0, n);
                Console.Write($"n = {n - 1}");
            }

            for (int i = 1; i < 7; i++)
            {
                for (int j = 1; j < i + 1; j++)
                {
                    Console.SetCursorPosition(j * 7, i);
                    int fakt = FaktorialisSzamitas(i - 1) / (FaktorialisSzamitas(j - 1) * FaktorialisSzamitas(i - j));
                    Console.Write(fakt);
                }
            }
            */

            /* break vagy continue

            for (int i = 1; i < 21; i++)
            { 
                if (i % 5 == 0)
                {
                    break;
                    //goto ide;
                }
                Console.WriteLine(i);
            }

            //ide:
            //Console.WriteLine("Itt ér véget a mese!");
            */

            /* Hét napjai switch-csel

            Console.Write("Kérek egy napot: ");
            string nap = Console.ReadLine();

            switch (nap)
            {
                case "Hétfő":
                case "Kedd":
                case "Szerda":
                case "Csütörtök":
                    Console.WriteLine("Szeretem a hétköznapokat!");
                    break;
                case "Péntek":
                    Console.WriteLine("Majdnem hétvége!");
                    break;
                case "Szombat":
                case "Vasárnap":
                    Console.WriteLine("Hurrá hétvége!");
                    break;
                default:
                    Console.WriteLine("Nincs ilyen nap!");
                    break;
            }
            */

            // 
            Console.ReadKey(true);
        }

        static int FaktorialisSzamitas(int szam)
        {
            int faktorialis = 1;
            int index = 1;

            do
            {
                faktorialis *= index++;
            } while (index <= szam);

            return faktorialis;
        }
    }
}
