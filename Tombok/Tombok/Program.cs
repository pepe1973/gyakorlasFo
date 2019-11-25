using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tombok
{
    class Program
    {
        static void Main(string[] args)
        {
            /* 42.-43.-44. feladat:
            Console.Write("Mennyi adattal dolgozzak: ");
            int darabszam = Int32.Parse(Console.ReadLine());

            // Létrehozzuk a tömböt.
            int[] tomb = new int[darabszam];

            // Feltöltjük  a tömböt egész számokkal.
            for (int i = 0; i < tomb.Length; i++)
            {
                Console.Write($"Kérem a(z) {i + 1}. számot: ");
                int szam = Int32.Parse(Console.ReadLine());
                tomb[i] = szam;
            }

            // Megszámoljuk a páratlan tömbelemeket.
            int paratlanokSzama = 0;

            for (int i = 0; i < tomb.Length; i++)
            {
                if (tomb[i] % 2 == 1)
                {
                    paratlanokSzama++;
                }
                //else
                //{
                //    parosokOsszege += tomb[i];
                //}
            }

            Console.WriteLine($"A tömbben található páratlan számok száma:  {paratlanokSzama}");

            // Páros számok összege.
            int parosokOsszege = 0;

            for (int i = 0; i < tomb.Length; i++)
            {
                if (tomb[i] % 2 == 0)
                {
                    parosokOsszege += tomb[i];
                    Console.WriteLine($"{i + 1}. szám páros : {tomb[i]}");
                }
            }

            Console.WriteLine($"A páros számok összege: {parosokOsszege}");*/

            /* 45. feladat:

            Console.Write("Mennyi adattal dolgozzak: ");
            int darabszam = Int32.Parse(Console.ReadLine());

            // Létrehozzuk a tömböt.
            int[] tomb = new int[darabszam];

            // Feltöltjük  a tömböt egész számokkal.
            for (int i = 0; i < tomb.Length; i++)
            {
                Console.Write($"Kérem a(z) {i + 1}. számot: ");
                int szam = Int32.Parse(Console.ReadLine());
                tomb[i] = szam;
            }

            Console.Write("Kérem a próbaszámot: ");
            int probaSzam = Convert.ToInt32(Console.ReadLine());
            int tombIndex = -1;
            bool vanE = false;

            for (int i = 0; i < tomb.Length; i++)
            {
                if (tomb[i] == probaSzam)
                {
                    tombIndex = i + 1;
                    vanE = true;
                    break;
                }
            }

            if (vanE)
            {
                Console.WriteLine($"Találtam ilyen számot a(z) {tombIndex}. pozícióban.");
            } 
            else
            {
                Console.WriteLine("Nincs ilyen szám a tömbben.");
            }*/

            /* 46. feladat:

            Console.Write("Mennyi adattal dolgozzak: ");
            int darabszam = Int32.Parse(Console.ReadLine());

            // Létrehozzuk a tömböt.
            int[] tomb = new int[darabszam];

            // Feltöltjük  a tömböt egész számokkal.
            for (int i = 0; i < tomb.Length; i++)
            {
                Console.Write($"Kérem a(z) {i + 1}. számot: ");
                int szam = Int32.Parse(Console.ReadLine());
                tomb[i] = szam;
            }

            Console.Write("Kérem a próbaszámot: ");
            int probaSzam = Convert.ToInt32(Console.ReadLine());
            int szamlalo = 0;

            for (int i = 0; i < tomb.Length; i++)
            {
                if (tomb[i] == probaSzam)
                {
                    szamlalo++;
                }
            }

            if (szamlalo != 0)
            {
                Console.WriteLine($"A(z) {probaSzam} ennyiszer szerepel: {szamlalo}");
            }
            else
            {
                Console.WriteLine("Ilyen szám nincs a tömbben.");
            }*/

            /* 47. feladat:

            Console.Write("Mennyi adattal dolgozzak: ");
            int darabszam = Int32.Parse(Console.ReadLine());

            // Létrehozzuk a tömböt.
            string[] tomb = new string[darabszam];

            // Feltöltjük  a tömböt keresztnevekkel.
            for (int i = 0; i < tomb.Length; i++)
            {
                Console.Write($"Kérem a(z) {i + 1}. nevet: ");
                string keresztnev = Console.ReadLine();
                tomb[i] = keresztnev;
            }

            Console.Write("Kérem a próbanevet: ");
            string probaNev = Console.ReadLine();
            int szamlalo = 0;

            for (int i = 0; i < tomb.Length; i++)
            {
                if (tomb[i] == probaNev)
                {
                    szamlalo++;
                }
            }

            if (szamlalo != 0)
            {
                Console.WriteLine($"A(z) {probaNev} ennyiszer szerepel: {szamlalo}");
            }
            else
            {
                Console.WriteLine("Ilyen név nincs a tömbben.");
            }*/

            // 48. feladat:
            Console.Write("Mennyi adattal dolgozzak: ");
            int darabszam = Int32.Parse(Console.ReadLine());

            // Létrehozzuk a tömböt.
            int[] tomb = new int[darabszam];

            // Feltöltjük  a tömböt egész számokkal.
            for (int i = 0; i < tomb.Length; i++)
            {
                Console.Write($"Kérem a(z) {i + 1}. számot: ");
                int szam = Int32.Parse(Console.ReadLine());
                tomb[i] = szam;
            }

            int maxKulonbseg = 0;

            for (int i = 0; i < tomb.Length; i++)
            {
                for (int j = i; j < tomb.Length; j++)
                {
                    int kulonbseg = Math.Abs(tomb[i] - tomb[j]);
                    if (maxKulonbseg <= kulonbseg)
                    {
                        maxKulonbseg = kulonbseg;
                    }
                }
            }

            Console.WriteLine("Különbség: " + maxKulonbseg);

            //tombKiir(tomb);
            Array.Sort(tomb);
            //tombKiir(tomb);

            Console.WriteLine($"A különbség: {tomb[tomb.Length - 1] - tomb[0]}");

            Console.WriteLine($"A különbség: {tomb.Max() - tomb.Min()}");

            Console.ReadKey(true);
        }

        static void tombKiir(int[] tomb)
        {
            for (int i = 0; i < tomb.Length; i++)
            {
                Console.WriteLine(tomb[i]);
            }
        }

    }
}
