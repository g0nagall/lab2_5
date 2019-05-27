using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab2_5
{
	class Program
	{
		static double power(double x, double i)
		{
			return Math.Pow(x, i);
		}
		static double square_root(double x)
		{
			return Math.Sqrt(x);
		}
		static double percent(double x, double i)
		{
			return (x * i) / 100;

		}

		static void Main(string[] args)
		{
		def:
			Console.Write("Enter necessary action [power] [square_root] [percent] = ");
			string switch_on = Console.ReadLine();
			switch (switch_on)

			{

				case "power":
					double x, i;
					Console.WriteLine("Type x");
					x = double.Parse(Console.ReadLine());
					Console.WriteLine("Type i");
					i = double.Parse(Console.ReadLine());
					Console.WriteLine(power(x, i));
					break;
				case "Square_root":
					Console.WriteLine("Type x");
					x = double.Parse(Console.ReadLine());
					Console.WriteLine(square_root(x));
					break;
				case "percent":
					Console.WriteLine("Type x");
					x = double.Parse(Console.ReadLine());
					Console.WriteLine("Type i");
					i = double.Parse(Console.ReadLine());
					Console.WriteLine(percent(x, i));
					break;



				default:
					Console.WriteLine("Try again");
					goto def;
			}


		}
	}
}
