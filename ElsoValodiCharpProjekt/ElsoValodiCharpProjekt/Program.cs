using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ElsoValodiCharpProjekt
{
    class Program
    {
        static void Main(string[] args)
        {
            /* 1. Feladat: 
            string kiir = "Hello world!";
            Console.WriteLine(kiir);*/

            /* 2. Feladat:
            Console.Write("Add meg a neved: ");
            string nev = Console.ReadLine();
            Console.WriteLine($"Üdvözöllek {nev}!");*/

            /* 3. Feladat: 
            Console.Write("Adj meg egy számot: ");
            int szam = Int32.Parse(Console.ReadLine());
            int szam = Convert.ToInt32(Console.ReadLine());
            double szam = Double.Parse(Console.ReadLine());
            double szam = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine($"A szám: {szam} kétszerese: {2 * szam}");*/

            /* 4. feladat:
            Console.Write("Adj meg egy számot: ");
            int szamA = Convert.ToInt32(Console.ReadLine());
            Console.Write("Adj meg egy másik számot: ");
            int szamB = Int32.Parse(Console.ReadLine());

            int osszeg = szamA + szamB;
            int kulonbseg = szamA - szamB;
            int szorzat = szamA * szamA;
            double hanyados = (double)szamA / szamB;

            Console.WriteLine($"A két szám: {szamA} és {szamB}: ");
            Console.WriteLine($"Összege: {osszeg}");
            Console.WriteLine($"Különbsége: {kulonbseg}");
            Console.WriteLine($"Szorzata: {szorzat}");
            Console.WriteLine($"Hányadosa: {hanyados}");*/

            /* 5. Feladat:
            Console.Write("Adj meg egy számot: ");
            int szamA = Convert.ToInt32(Console.ReadLine());
            Console.Write("Adj meg egy másik számot: ");
            int szamB = Int32.Parse(Console.ReadLine());

            if (szamA > szamB)
            {
                Console.WriteLine($"A nagyobbik szám: {szamA}");
            }
            else if (szamB > szamA)
            {
                Console.WriteLine($"A nagyobbik szám: {szamB}");
            }
            else
            {
                Console.WriteLine("A két szám egyenlő!");
            }

            if (szamA >= szamB)
            {
                Console.WriteLine($"A nagyobbik szám: {szamA}");
            }
            else
            {
                Console.WriteLine($"A nagyobbik szám: {szamB}");
            }*/

            /* 6. Feladat: 
            Console.Write("Adj meg egy számot: ");
            int szamA = Convert.ToInt32(Console.ReadLine());
            Console.Write("Adj meg egy másik számot: ");
            int szamB = Int32.Parse(Console.ReadLine());
            Console.Write("Adj meg egy harmadik számot: ");
            int szamC = Convert.ToInt32(Console.ReadLine());

            if (szamA <= szamB)
            {
                if (szamA <= szamC)
                {
                    Console.WriteLine($"A legkisebb szám: {szamA}");
                }
                else
                {
                    Console.WriteLine($"A legkisebb szám: {szamC}");
                }
            }
            else
            {
                if (szamB <= szamC)
                {
                    Console.WriteLine($"A legkisebb szám: {szamB}");
                }
                else
                {
                    Console.WriteLine($"A legkisebb szám: {szamC}");
                }
            }*/

            /* 7. Feladat:
            Console.Write("Adj meg egy számot: ");
            int szamA = Convert.ToInt32(Console.ReadLine());
            Console.Write("Adj meg egy másik számot: ");
            int szamB = Int32.Parse(Console.ReadLine());
            Console.Write("Adj meg egy harmadik számot: ");
            int szamC = Convert.ToInt32(Console.ReadLine());

            if (szamA + szamB > szamC && szamA + szamC > szamB && szamB + szamC > szamA)
            {
                Console.WriteLine($"A három számból: {szamA}, {szamB} és {szamC} háromszög szerkeszthető.");
            }
            else
            {
                Console.WriteLine($"A három számból: {szamA}, {szamB} és {szamC} háromszög nem szerkeszthető.");
            }*/

            /* 8. Feladat:
            Console.Write("Adj meg egy számot: ");
            int szamA = Convert.ToInt32(Console.ReadLine());
            Console.Write("Adj meg egy másik számot: ");
            int szamB = Int32.Parse(Console.ReadLine());

            if (szamA >= 0 && szamB >= 0)
            {
                double szamtani = ((double)szamA + szamB) / 2;
                double mertani = Math.Sqrt(szamA * szamB);
                Console.WriteLine($"A két szám: {szamA} és {szamB} számtani közepe: {szamtani}");
                Console.WriteLine($"A két szám: {szamA} és {szamB} mértani közepe: {mertani}");
            }
            else
            {
                Console.WriteLine("A feladat nem megoldható!");
            }*/

            /* 15. Feladat:
            Console.Write("Kérem a pozitív egész számot: ");
            int bemenoSzam = Int32.Parse(Console.ReadLine());
            string kiiratas = "";

            for (int i = 1; i < bemenoSzam; i++)
            {
                kiiratas += i + " ";
            }

            Console.WriteLine(kiiratas);

            for (int i = 1; i < bemenoSzam; i++)
            {
                Console.Write(i + " ");
            }

            int i = 1;

            Elöltesztelő ciklus
            while (i < bemenoSzam)
            {
                Console.Write(i++ + " ");
                //i = i + 1;
                //i += 1;
                //i++;
            }

            Hátultesztelő ciklus
            do
            {
                Console.Write(i++ + " ");
            } while (i < bemenoSzam);*/

            /* 16.Feladat:
            Console.Write("Kérem a pozitív egész számot: ");
            int bemenoSzam = Int32.Parse(Console.ReadLine());
            string kiiratas = "";

            for (int i = 1; i < bemenoSzam; i++)
            {
                kiiratas += i + "\n"; // "\n" jelöli a sortörést.
            }

            Console.WriteLine(kiiratas);

            for (int i = 1; i < bemenoSzam; i++)
            {
                Console.WriteLine(i);
            }

            int i = 1;

            //Elöltesztelő ciklus
            while (i < bemenoSzam)
            {
                Console.WriteLine(i++);
                //i = i + 1;
                //i += 1;
                //i++;
            }

            Hátultesztelő ciklus
            int i = 1;
            do
            {
                Console.WriteLine(i++);
            } while (i < bemenoSzam);*/

            /* 17. Feladat:
            Console.Write("Kérem a pozitív egész számot: ");
            int bemenoSzam = Int32.Parse(Console.ReadLine());
            
            Console.WriteLine($"{bemenoSzam} egész osztói: ");

            for (int i = 1; i <= bemenoSzam; i++)
            {
                if (bemenoSzam % i == 0)
                {
                    Console.WriteLine(i);
                }
            }

            int i = 1;

            while (i <= bemenoSzam)
            {
                if (bemenoSzam % i == 0)
                {
                    Console.WriteLine(i);
                }
                i++;
            }*/

            /* 18. Feladat + Plusz feladat: Prím-e a bekért pozitív egész szám?
            Console.Write("Kérem a pozitív egész számot: ");
            int bemenoSzam = Int32.Parse(Console.ReadLine());

            int szamlalo = 0;
            int osztokOsszege = 0;

            for (int i = 1; i < bemenoSzam + 1; i++)
            {
                if (bemenoSzam % i == 0)
                {
                    szamlalo++;
                    osztokOsszege += i;
                }
            }

            if (szamlalo == 2)
            {
                Console.WriteLine($"A bemenő szám {bemenoSzam} prím.");
                Console.WriteLine($"A bemenő szám {bemenoSzam} osztóinak összege: {osztokOsszege}.");
            }
            else
            {
                Console.WriteLine($"A bemenő szám {bemenoSzam} nem prím.");
                Console.WriteLine($"A bemenő szám {bemenoSzam} osztóinak összege: {osztokOsszege}.");
            }*/

            /* 19. Feladat:
            Console.Write("Kérem a pozitív egész számot: ");
            int bemenoSzam = Int32.Parse(Console.ReadLine());

            int osztokOsszege = 0;

            int i = 1;

            while (i < bemenoSzam)
            {
                if (bemenoSzam % i == 0)
                {
                    osztokOsszege += i;
                }
                i++;
            }

            if (osztokOsszege == bemenoSzam)
            {
                Console.WriteLine($"A szám {bemenoSzam} tökéletes szám.");
            }
            else
            {
                Console.WriteLine($"A szám {bemenoSzam} nem tökéletes szám.");
            }*/

            /* 20. Feladat:
            int alap = -1;
            while (alap <= 0 || alap > 10)
            {
                Console.Write("Kérem az alapot: ");
                alap = Int32.Parse(Console.ReadLine());
            }

            int kitevo = -1;
            while (kitevo <= 0 || kitevo > 10)
            {
                Console.Write("Kérem az kitevőt: ");
                kitevo = Int32.Parse(Console.ReadLine());
            }
            
            int hatvany = 1;

            for (int i = 0; i < kitevo; i++)
            {
                hatvany *= alap;
            }

            Console.Write($"a hatvány: {hatvany}");*/

            /* 21. Feladat:
            int szam = 0;

            while (szam <= 0)
            {
                Console.Write("Kérek egy pozitív egész számot: ");
                szam = Convert.ToInt32(Console.ReadLine());
            }*/

            /* Plusz feladat: Prímszámra lépjen ki a ciklusból.

            int szam = 3;

            while (primszamE(szam))
            {
                Console.Write("Kérek egy nem prímszámot: ");
                szam = Convert.ToInt32(Console.ReadLine());
            }*/

            // 22. Feladat:
            int szam = 0;

            int osszeg = 0;

            while (szam <= 10) 
            {
                Console.Write("Kérek egy 10-nél kisebb egész számot: ");
                szam = Int32.Parse(Console.ReadLine());
                if (szam <= 10)
                {
                    osszeg += szam;
                    Console.WriteLine($"Az eddig beolvasott megfelelő számok összege: {osszeg}.");
                }
                else
                {
                    Console.WriteLine("Nem megfelelő szám!");
                    break;
                }
            }

            Console.WriteLine($"A beolvasott számok összege: {osszeg}");
			// Ide írok egy kommentet!

            Console.ReadKey(true);
        }

        static bool primszamE(int szam)
        {
            bool teljesul = true;

            int osztokSzama = 0;

            for (int i = 1; i <= szam; i++)
            {
                if (szam % i == 0)
                {
                    osztokSzama++;
                }
            }

            if (osztokSzama == 2)
            {
                return teljesul;
            }
            else
            {
                return !teljesul;
            }
        }
    }
}
