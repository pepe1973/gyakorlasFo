using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace kukacRoviden
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

			for (int i = 0; i < 5; i++)
			{
				xCoord[i] = x + i;
				yCoord[i] = y;
			}

			int[] pontokX = new int[10];
			int[] pontokY = new int[10];

			for (int i = 0; i < 10; i++)
			{
				pontokX[i] = rnd.Next(0, szelesseg);
				pontokY[i] = rnd.Next(0, magassag);
			}

			Megrajzol(xCoord, yCoord);
			Megrajzol(pontokX, pontokY);

			ConsoleKeyInfo cki = new ConsoleKeyInfo();

			while (cki.Key != ConsoleKey.Escape)
			{
				cki = Console.ReadKey();
				switch (cki.Key)
				{
					case ConsoleKey.LeftArrow:
						Console.Clear();
						Megrajzol(pontokX, pontokY);
						Mozgat('b', ref xCoord, ref yCoord);
						Megrajzol(xCoord, yCoord);
						Vizsgal(ref pontokX, ref pontokY, ref xCoord, ref yCoord);
						break;
					case ConsoleKey.UpArrow:
						Console.Clear();
						Megrajzol(pontokX, pontokY);
						Mozgat('f', ref xCoord, ref yCoord);
						Megrajzol(xCoord, yCoord);
						Vizsgal(ref pontokX, ref pontokY, ref xCoord, ref yCoord);
						break;
					case ConsoleKey.RightArrow:
						Console.Clear();
						Megrajzol(pontokX, pontokY);
						Mozgat('j', ref xCoord, ref yCoord);
						Megrajzol(xCoord, yCoord);
						Vizsgal(ref pontokX, ref pontokY, ref xCoord, ref yCoord);
						break;
					case ConsoleKey.DownArrow:
						Console.Clear();
						Megrajzol(pontokX, pontokY);
						Mozgat('l', ref xCoord, ref yCoord);
						Megrajzol(xCoord, yCoord);
						Vizsgal(ref pontokX, ref pontokY, ref xCoord, ref yCoord);
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
		static void Mozgat(char merre, ref int[] x, ref int[] y)
		{
			int[] atmenetX = x;
			int[] atmenetY = y;
			for (int i = 0; i < x.Length - 1; i++)
			{
				x[i] = atmenetX[i + 1];
				y[i] = atmenetY[i + 1];
			}
			switch (merre)
			{
				case 'f':
					x[x.Length - 1] = atmenetX[x.Length - 1];
					y[x.Length - 1] = atmenetY[x.Length - 1] - 1;
					break;
				case 'l':
					x[x.Length - 1] = atmenetX[x.Length - 1];
					y[x.Length - 1] = atmenetY[x.Length - 1] + 1;
					break;
				case 'b':
					x[x.Length - 1] = atmenetX[x.Length - 1] - 1;
					y[x.Length - 1] = atmenetY[x.Length - 1];
					break;
				case 'j':
					x[x.Length - 1] = atmenetX[x.Length - 1] + 1;
					y[x.Length - 1] = atmenetY[x.Length - 1];
					break;
			}
		}

		static int[] EggyelCsokkent(int szam, int[] a)
		{
			int hossz = a.Length;
			int[] b = new int[hossz - 1];

			for (int i = 0; i < hossz; i++)
			{
				if (szam != a[i] && i < hossz - 1)
				{
					b[i] = a[i];
				}
				else if (szam == a[i] && (i == hossz - 1))
				{
					break;
				}
				else if (szam == a[i] && (i < hossz - 1))
				{
					for (int j = i; j < hossz - 1; j++)
					{
						b[j] = a[j + 1];
					}
					break;
				}
			}

			return b;
		}

		static int[] EggyelNovel(char a, int[] tomb)
		{
			int hossz = tomb.Length;
			int[] b = new int[hossz + 1];

			for (int i = 1; i < hossz + 1; i++)
			{
				b[i] = tomb[i - 1];
			}

			if (a == 'x')
			{
				b[0] = tomb[0] - 1;
			}
			else if (a == 'y')
			{
				b[0] = tomb[0];
			}
			
			return b;
		}

		static void Vizsgal(ref int[] a, ref int[] b, ref int[] c, ref int[] d)
		{
			for (int i = 0; i < a.Length; i++)
			{
				if (a[i] == c[c.Length - 1] && b[i] == d[d.Length - 1])
				{
					a = EggyelCsokkent(a[i], a);
					b = EggyelCsokkent(b[i], b);
					c = EggyelNovel('x', c);
					d = EggyelNovel('y', d);
				}
			}
			Megrajzol(c, d);
		}
	}
}
