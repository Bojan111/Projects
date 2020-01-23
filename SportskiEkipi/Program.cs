using System;
using System.Collections.Generic;

namespace SportskiEkipi
{
	class Program
	{
		static void Main(string[] args)
		{
			var ekipa = new List<Ekipa>();
				Console.WriteLine("Vnesi podatoci za Fudbalska ekipa");

				Console.WriteLine("Vnesi ime na ekipa");
				var name1 = Console.ReadLine();
				Console.WriteLine("Vnesi pobedi: ");
				var pobedi1 = int.Parse(Console.ReadLine());
				Console.WriteLine("Vnesi porazi: ");
				var porazi1 = int.Parse(Console.ReadLine());
				Console.WriteLine("Vnesi broj na crveni kartoni: ");
				var crven = int.Parse(Console.ReadLine());
				Console.WriteLine("Vnesi broj na zolti kartoni: ");
				var zolt = int.Parse(Console.ReadLine());
				Console.WriteLine("Vnesi broj na nereseni natprevari: ");
				var neresn = int.Parse(Console.ReadLine());
				var fudbekipa = new FudbalskaEkipa(name1, pobedi1, porazi1, crven, zolt, neresn);
				ekipa.Add(fudbekipa);

				foreach (var item in ekipa)
				{
					Console.WriteLine($"{item.Print()}");

				}
		}
	}
}
