using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DolgozatHetfo
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Alapösszeg: ");
            double osszeg = Double.Parse(Console.ReadLine());
            double alapOsszeg = osszeg;
            double evesOsszeg = osszeg; 
            Console.Write("Kamatláb: ");
            double kamat = Double.Parse(Console.ReadLine());
            Console.Write("Futamidő: ");
            int futamIdo = Int32.Parse(Console.ReadLine());
            Console.WriteLine();
            Console.SetCursorPosition(13, 4);
            Console.Write("Évenkénti összeg");
            Console.SetCursorPosition(32, 4);
            Console.Write("Összhozam");
            Console.SetCursorPosition(45, 4);
            Console.Write("Éves hozam");

            for (int i = 0; i < futamIdo; i++)
            {
                osszeg =(kamat / 100 + 1) * osszeg;
                Console.SetCursorPosition(0, 5 + i);
                Console.Write($"{i + 1}. év végén: {osszeg:F0}Ft");
                Console.SetCursorPosition(32, 5 + i);
                Console.Write($"{osszeg - alapOsszeg:F0}Ft");
                Console.SetCursorPosition(45, 5 + i);
                Console.Write($"{osszeg - evesOsszeg:F0}Ft");
                evesOsszeg = osszeg;
            }

            Console.ReadKey(true);
        }
    }
}
