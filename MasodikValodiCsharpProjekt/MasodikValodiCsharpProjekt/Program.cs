using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MasodikValodiCsharpProjekt
{
    class Program
    {
        static void Main(string[] args)
        {
            /*Console.WriteLine("1-től 100-ig azok a számok, melyek valódi osztóinak összege osztható héttel.");

            for (int i = 1; i < 101; i++)
            {
                if (osszegHettel(i))
                {
                    Console.WriteLine($"{i} valódi osztóinak összege osztható 7-tel.");
                }
            }*/

            /*Console.WriteLine("2-től 100-ig a prímszámok: ");

            for (int i = 2; i < 101; i++)
            {
                if (primszamE(i))
                {
                    Console.WriteLine(i);
                }
            }*/

            /* Int32.TryParse használata 
            int szam = -89;
            bool egeszSzam = true;

            do
            {
                Console.Write("Kérek egy számot: ");
                egeszSzam = Int32.TryParse(Console.ReadLine(), out szam);
            } while (!egeszSzam);

            Console.WriteLine($"A bekért szám: {szam}");*/

            /* 23. feladat: 
            string kimenet = "";

            Console.Write("Kérek egy pozitív egész számot: ");
            int szam = Convert.ToInt32(Console.ReadLine());

            kimenet += szam + " = ";

            while (szam % 2 == 0)
            {
                kimenet += 2 + " * ";
                szam = szam / 2;
            }

            kimenet += szam;

            Console.WriteLine(kimenet); */

            /* 24. feladat:
            string alma = "";

            while (alma != "alma")
            {
                Console.Write("Kérek egy gyümölcsöt: ");
                alma = Console.ReadLine();
            }

            Console.WriteLine("Az alma gyümölcs!");*/

            /* 25. feladat:
            string kimenet = "";

            Console.Write("Kérek egy pozitív egész számot: ");
            int szam = Convert.ToInt32(Console.ReadLine());

            kimenet += szam + " = ";

            int egesz = 0;
            int tort = szam;

            while (szam - 3 >= 0)
            {
                szam = szam - 3;
                egesz++;
                tort = szam;
            }

            kimenet += egesz + " * 3 + " + tort;

            Console.WriteLine(kimenet); */

            /* 28. - 29. feladat:
            string kimenet = "";

            Console.Write("Kérek egy pozitív egész számot: ");
            int szam = Convert.ToInt32(Console.ReadLine());

            kimenet += szam + " = ";

            int meddig = (int)(Math.Floor(Math.Sqrt(szam))) + 1;

            for (int i = 2; i < meddig; i++)
            {
                if (szam % i == 0)
                {
                    if (szam == i)
                    {
                        kimenet += i;
                    }
                    else
                    {
                        kimenet += i + " * ";
                        szam = szam / i;
                        i--;
                    } 
                }
            }

            Console.WriteLine(kimenet);*/

            /* 32. feladat: 
            Console.Write("Kérek egy pozitív egész számot: ");
            int szam = Int32.Parse(Console.ReadLine());

            for (int i = 1; i < szam +1; i++)
            {
                for (int j = 1; j < szam + 1; j++)
                {
                    Console.SetCursorPosition(3 * (j - 1) + 1, i);
                    Console.Write($"{i * j} ");
                }
                Console.WriteLine();
            }*/

            // 34. feladat:
            for (int i = 10; i < 100; i++)
            {
                for (int j = 10; j < 100; j++)
                {

                }

                for (int k = 10; k < 100; k++)
                {

                }
            }

            Console.ReadKey(true);
            
        }

        static bool osszegHettel(int szam)
        {
            int osszeg = 0;
            bool hettel = true;

            for (int i = 1; i < szam; i++)
            {
                if (szam % i == 0)
                {
                    osszeg += i;
                }
            }

            if (osszeg % 7 != 0)
            {
                hettel = false;
            }

            return hettel;
        }

        static bool primszamE(int szam)
        {
            bool primE = true;
            int hatar = (int)Math.Floor(Math.Sqrt(szam)) + 1;

            for (int i = 2; i < hatar; i++)
            {
                if (szam % i == 0)
                {
                    primE = false;
                    break;
                }
            }

            return primE;
        }
    }
}
