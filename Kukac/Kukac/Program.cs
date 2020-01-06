using System;
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
						//Megrajzol(xCoord, yCoord);
						for (int i = 0; i < pontokX.Length; i++)
						{
							if (pontokX[i] == xCoord[xCoord.Length - 1] && pontokY[i] == yCoord[yCoord.Length - 1])
							{
								pontokX = EggyelCsokkent(pontokX[i], pontokX);
								pontokY = EggyelCsokkent(pontokY[i], pontokY);
								xCoord = EggyelNovel('x', xCoord);
								yCoord = EggyelNovel('y', yCoord);
							}
						}
						Megrajzol(xCoord, yCoord);
						break;
					case ConsoleKey.UpArrow:
						Console.Clear();
						Megrajzol(pontokX, pontokY);
						Felfele(ref xCoord, ref yCoord);
						//Megrajzol(xCoord, yCoord);
						for (int i = 0; i < pontokX.Length; i++)
						{
							if (pontokX[i] == xCoord[xCoord.Length - 1] && pontokY[i] == yCoord[yCoord.Length - 1])
							{
								pontokX = EggyelCsokkent(pontokX[i], pontokX);
								pontokY = EggyelCsokkent(pontokY[i], pontokY);
								xCoord = EggyelNovel('x', xCoord);
								yCoord = EggyelNovel('y', yCoord);
							}
						}
						Megrajzol(xCoord, yCoord);
						break;
					case ConsoleKey.RightArrow:
						Console.Clear();
						Megrajzol(pontokX, pontokY);
						Jobbfele(ref xCoord, ref yCoord);
						//Megrajzol(xCoord, yCoord);
						for (int i = 0; i < pontokX.Length; i++)
						{
							if (pontokX[i] == xCoord[xCoord.Length - 1] && pontokY[i] == yCoord[yCoord.Length - 1])
							{
								pontokX = EggyelCsokkent(pontokX[i], pontokX);
								pontokY = EggyelCsokkent(pontokY[i], pontokY);
								xCoord = EggyelNovel('x', xCoord);
								yCoord = EggyelNovel('y', yCoord);
							}
						}
						Megrajzol(xCoord, yCoord);
						break;
					case ConsoleKey.DownArrow:
						Console.Clear();
						Megrajzol(pontokX, pontokY);
						Lefele(ref xCoord, ref yCoord);
						//Megrajzol(xCoord, yCoord);
						for (int i = 0; i < pontokX.Length; i++)
						{
							if (pontokX[i] == xCoord[xCoord.Length - 1] && pontokY[i] == yCoord[yCoord.Length - 1])
							{
								pontokX = EggyelCsokkent(pontokX[i], pontokX);
								pontokY = EggyelCsokkent(pontokY[i], pontokY);
								xCoord = EggyelNovel('x', xCoord);
								yCoord = EggyelNovel('y', yCoord);
							}
						}
						Megrajzol(xCoord, yCoord);
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
			for (int i = 0; i < x.Length - 1; i++)
			{
				x[i] = atmenetX[i + 1];
				y[i] = atmenetY[i + 1];
			}
			x[x.Length - 1] = atmenetX[x.Length - 1];
			y[x.Length - 1] = atmenetY[x.Length - 1] - 1;
		}

		static void Lefele(ref int[] x, ref int[] y)
		{
			int[] atmenetX = x;
			int[] atmenetY = y;
			for (int i = 0; i < x.Length - 1; i++)
			{
				x[i] = atmenetX[i + 1];
				y[i] = atmenetY[i + 1];
			}
			x[x.Length - 1] = atmenetX[x.Length - 1];
			y[x.Length - 1] = atmenetY[x.Length - 1] + 1;
		}
		static void Jobbfele(ref int[] x, ref int[] y)
		{
			int[] atmenetX = x;
			int[] atmenetY = y;
			for (int i = 0; i < x.Length - 1; i++)
			{
				x[i] = atmenetX[i + 1];
				y[i] = atmenetY[i + 1];
			}
			x[x.Length - 1] = atmenetX[x.Length - 1] + 1;
			y[x.Length - 1] = atmenetY[x.Length - 1];
		}
		static void Balfele(ref int[] x, ref int[] y)
		{
			int[] atmenetX = x;
			int[] atmenetY = y;
			for (int i = 0; i < x.Length - 1; i++)
			{
				x[i] = atmenetX[i + 1];
				y[i] = atmenetY[i + 1];
			}
			x[x.Length - 1] = atmenetX[x.Length - 1] - 1;
			y[x.Length - 1] = atmenetY[x.Length - 1];
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
			else if (a == 'y'
			{
				b[0] = tomb[0];
			}

			return b;
		}
	}
}
