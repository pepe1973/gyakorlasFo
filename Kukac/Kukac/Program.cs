﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ismetles2
{
    class Program
    {
        static void Main(string[] args)
        {
            Random rnd = new Random();
            int szelesseg = Console.WindowWidth;
            int magassag = Console.WindowHeight;
            int x = szelesseg / 2;
            int y = magassag / 2;

            int[] xCoord = new int[5];
            int[] yCoord = new int[5];

            int[] pontokX = new int[10];
            int[] pontokY = new int[10];

            for (int i = 0; i < 5; i++)
            {
                xCoord[i] = x + i;
                yCoord[i] = y;
            }

            for (int i = 0; i < 10; i++)
            {
                pontokX[i] = rnd.Next(0, szelesseg);
                pontokY[i] = rnd.Next(0, magassag);
            }

            Megrajzol(pontokX, pontokY);
            Megrajzol(xCoord, yCoord);
           
            //Console.WriteLine($"{szelesseg} és {magassag}");

            ConsoleKeyInfo cki = new ConsoleKeyInfo();

            while (cki.Key != ConsoleKey.Escape)
            {
                cki = Console.ReadKey();
                switch (cki.Key)
                {
                    case ConsoleKey.LeftArrow:
                        Console.Clear();
                        Megrajzol(pontokX, pontokY);
                        Balfele(ref xCoord, ref yCoord);
                        Megrajzol(xCoord, yCoord);
                        for (int i = 0; i < pontokX.Length; i++)
                        {
                            if (pontokX[i] == xCoord[xCoord.Length - 1] && pontokY[i] == yCoord[yCoord.Length - 1])
                            {
                                pontokX = EggyelCsokkent(pontokX[i], pontokX);
                                pontokY = EggyelCsokkent(pontokY[i], pontokY);
                            }
                        }
                        break;
                    case ConsoleKey.UpArrow:
                        Console.Clear();
                        Megrajzol(pontokX, pontokY);
                        Felfele(ref xCoord, ref yCoord);
                        Megrajzol(xCoord, yCoord);
                        for (int i = 0; i < pontokX.Length; i++)
                        {
                            if (pontokX[i] == xCoord[xCoord.Length - 1] && pontokY[i] == yCoord[yCoord.Length - 1])
                            {
                                pontokX = EggyelCsokkent(pontokX[i], pontokX);
                                pontokY = EggyelCsokkent(pontokY[i], pontokY);
                            }
                        }
                        break;
                    case ConsoleKey.RightArrow:
                        Console.Clear();
                        Megrajzol(pontokX, pontokY);
                        Jobbfele(ref xCoord, ref yCoord);
                        Megrajzol(xCoord, yCoord);
                        for (int i = 0; i < pontokX.Length; i++)
                        {
                            if (pontokX[i] == xCoord[xCoord.Length - 1] && pontokY[i] == yCoord[yCoord.Length - 1])
                            {
                                pontokX = EggyelCsokkent(pontokX[i], pontokX);
                                pontokY = EggyelCsokkent(pontokY[i], pontokY);
                            }
                        }
                        break;
                    case ConsoleKey.DownArrow:
                        Console.Clear();
                        Megrajzol(pontokX, pontokY);
                        Lefele(ref xCoord, ref yCoord);
                        Megrajzol(xCoord, yCoord);
                        for (int i = 0; i < pontokX.Length; i++)
                        {
                            if (pontokX[i] == xCoord[xCoord.Length - 1] && pontokY[i] == yCoord[yCoord.Length - 1])
                            {
                                pontokX = EggyelCsokkent(pontokX[i], pontokX);
                                pontokY = EggyelCsokkent(pontokY[i], pontokY);
                            }
                        }
                        break;
                   
                }
            }

            Console.ReadKey(true);
        }

        static void Megrajzol(int[] x, int[] y)
        {
            for (int i = 0; i < x.Length; i++)
            {
                Console.SetCursorPosition(x[i], y[i]);
                Console.Write("*");
            }
        }
        static void Felfele(ref int[] x, ref int[] y)
        {
            int[] atmenetX = x;
            int[] atmenetY = y;
            for (int i = 0; i < 4; i++)
            {
                x[i] = atmenetX[i + 1];
                y[i] = atmenetY[i + 1];
            }
            x[4] = atmenetX[4];
            y[4] = atmenetY[4] - 1;
        }

        static void Lefele(ref int[] x, ref int[] y)
        {
            int[] atmenetX = x;
            int[] atmenetY = y;
            for (int i = 0; i < 4; i++)
            {
                x[i] = atmenetX[i + 1];
                y[i] = atmenetY[i + 1];
            }
            x[4] = atmenetX[4];
            y[4] = atmenetY[4] + 1;
        }
        static void Jobbfele(ref int[] x, ref int[] y)
        {
            int[] atmenetX = x;
            int[] atmenetY = y;
            for (int i = 0; i < 4; i++)
            {
                x[i] = atmenetX[i + 1];
                y[i] = atmenetY[i + 1];
            }
            x[4] = atmenetX[4] + 1;
            y[4] = atmenetY[4];
        }
        static void Balfele(ref int[] x, ref int[] y)
        {
            int[] atmenetX = x;
            int[] atmenetY = y;
            for (int i = 0; i < 4; i++)
            {
                x[i] = atmenetX[i + 1];
                y[i] = atmenetY[i + 1];
            }
            x[4] = atmenetX[4] - 1;
            y[4] = atmenetY[4];
        }

        static int[] EggyelCsokkent(int szam, int[] a)
        {
            int hossz = a.Length;
            int[] b = new int[hossz - 1];

            for (int i = 0; i < b.Length; i++)
            {
                    b[i] = a[i];
            }

            return b;
        } 
    }
}
