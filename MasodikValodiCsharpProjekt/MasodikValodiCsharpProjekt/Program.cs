﻿using System;
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

            /* 34. feladat:
            Console.WriteLine("A párosan speciális számok: ");
            for (int i = 10; i < 100; i++)
            {
                int kulsoTizes = i / 10;
                int kulsoEgyes = i % 10;
                for (int j = 10; j < 100; j++)
                {
                    int belsoTizes = j / 10;
                    int belsoEgyes = j % 10;
                    int belsoSzorzat = i * j;
                    int kulso = 10 * kulsoEgyes + kulsoTizes;
                    int belso = 10 * belsoEgyes + belsoTizes;
                    int kulsoszorzat = kulso * belso;
                    if (belsoSzorzat == kulsoszorzat)
                    {
                        Console.WriteLine($"Az {i} és {j} párosan speciális számok.");
                    }
                }
            }*/

            /* 35. feladat:
            int sorok = 3;
            for (int i = 0; i < sorok; i++)
            {
                for (int j = 0; j < 10; j++)
                {
					int eddig = 97 + i + j * sorok;
                    if (eddig  < 123)
                    {
                        Console.SetCursorPosition(j * 8, i);
                        Console.WriteLine($"{(char)(eddig)} {eddig}");
                    }
                }
            }*/

            /* 36. feladat:
            Console.Write("Kérem a sorok számát: ");
            int sorok = Int32.Parse(Console.ReadLine());
            Console.Write("Kérem az oszlopok számát: ");
            int oszlopok = Int32.Parse(Console.ReadLine());

            for (int i = 0; i < sorok; i++)
            {
                for (int j = 0; j < oszlopok; j++)
                {
                    if ((i + j) % 2 == 0)
                    {
                        Console.Write('x');
                    }
                    else
                    {
                        Console.Write('o');
                    }
                }
                Console.WriteLine();
            }*/

            /* 37. feladat:
            Console.Write("Kérem  sorok számát: ");
            int a = Convert.ToInt32(Console.ReadLine());

            for (int i = 0; i < a; i++)
            {
                for (int j = 0; j < 2 * i + 1; j++)
                {
                    Console.Write('*');
                }
                Console.WriteLine();
            }*/

            /* 38. feladat:
            Console.Write("Kérem  sorok számát: ");
            int a = Convert.ToInt32(Console.ReadLine());

            for (int i = 0; i < a; i++)
            {
                for (int k = 0; k < a - i; k++)
                {
                    Console.Write(' ');
                }
                for (int j = 0; j < 2 * i + 1; j++)
                {
                    Console.Write('*');
                }
                Console.WriteLine();
            }

            for (int i = 0; i < a; i++)
            {
                Console.SetCursorPosition(a - i, i + 1);
                for (int j = 0; j < 2 * i + 1; j++)
                {
                    Console.Write('*');
                }
                Console.WriteLine();
            }*/

            /* 39. feladat: 
            Console.Write("Kérem a sorok számát: ");
            int sorok = Int32.Parse(Console.ReadLine());
            Console.Write("Kérem az oszlopok számát: ");
            int oszlopok = Int32.Parse(Console.ReadLine());

            for (int i = 0; i < sorok; i++)
            {
                for (int j = 0; j < oszlopok; j++)
                {
                    if ((i == 0) || (i == (sorok - 1)) || (i == (sorok - 1) / 2))
                    {
                        Console.Write('*');
                    }
                    else if ((j == 0) || (j == oszlopok - 1) || (j == (oszlopok - 1) / 2))
                    {
                        Console.Write('*');
                    }
                    else
                    {
                        Console.Write(' ');
                    }
                }
                Console.WriteLine();
            }*/

            // 41. feladat:

            /*for (int i = 65; i < 91; i++)
            {
                Console.Write((char)i);
            }
            Console.WriteLine();
            for (int j = 66; j < 91; j++)
            {
                Console.Write((char)j);
            }
            for (int k = 65; k < 66; k++)
            {
                Console.Write((char)k);
            }
            Console.WriteLine();
            for (int m = 67; m < 91; m++)
            {
                Console.Write((char)m);
            }
            for (int n = 65; n < 67; n++)
            {
                Console.Write((char)n);
            }*/

            for (int i = 0; i < 27; i++)
            {
                for (int j = 65 + i; j < 91; j++)
                {
                    Console.Write((char)j);
                }
                for (int k = 65; k < 65 + i; k++)
                {
                    Console.Write((char)k);
                }
                Console.WriteLine();
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
