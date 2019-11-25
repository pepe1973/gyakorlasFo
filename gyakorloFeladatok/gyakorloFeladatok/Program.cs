using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace gyakorloFeladatok
{
    class Program
    {
        static void Main(string[] args)
        {
            /* 1. feladat:
            Console.Write("Kérem a tömb elemszámát: ");
            int elemszam = Int32.Parse(Console.ReadLine());

            int[] tomb = new int[elemszam];

            for (int i = 0; i < tomb.Length; i++)
            {
                Console.Write($"Kérem a(z) {i + 1}. számot: ");
                tomb[i] = Int32.Parse(Console.ReadLine());
            }

            int maxKulonbseg = Int32.MinValue;

            for (int i = 0; i < tomb.Length - 1; i++)
            {
                //int kulonbseg = Math.Abs(tomb[i] - tomb[i + 1]);
                int kulonbseg = tomb[i] - tomb[i + 1];
                Console.WriteLine(kulonbseg);
                if (maxKulonbseg <= kulonbseg)
                {
                    maxKulonbseg = kulonbseg;
                }
            }

            Console.WriteLine($"A maximális különbség: {maxKulonbseg}");*/

            // 2. feladat:
            Console.Write("Kérem a tömb elemszámát: ");
            int elemszam = Int32.Parse(Console.ReadLine());

            int[] tomb = new int[elemszam];

            for (int i = 0; i < tomb.Length; i++)
            {
                Console.Write($"Kérem a(z) {i + 1}. számot: ");
                tomb[i] = Int32.Parse(Console.ReadLine());
            }

            int elso = 0;
            int masodik = 0;
            int minKulonbseg = Int32.MaxValue;

            for (int i = 0; i < tomb.Length; i++)
            {
                for (int j = i + 1; j < tomb.Length; j++)
                {

                }
            }

            Console.ReadKey(true);
        }
    }
}
