using System;
using System.Collections.Generic;
using System.Linq;

namespace Imot
{
	class Program
	{
		static void Main(string[] args)
		{
			var imoti = new List<Imot>();

			Console.WriteLine("Vnesi 'q' za izlez.");
			while (true)
			{
				Console.WriteLine("1. Javen Iimot");
				Console.WriteLine("2. Private Imot");
				var imotTip = Console.ReadLine();
				if (imotTip == "q")
				{
					break;
				}

				Console.Write("Povrsina: ");
				var p = int.Parse(Console.ReadLine());

				Console.Write("Lokacija: ");
				var l = Console.ReadLine();
				switch (imotTip)
				{
					case "1":
						Console.Write("Vnesi Godina:");
						imoti.Add(new JavenImot(int.Parse(Console.ReadLine()),l , p));
						break;
					case "2":
						Console.Write("Sopstvenik :");
						var i = new PrivatenImot(200,l, p, 5);
						i.Name = Console.ReadLine();
						imoti.Add(i);
						break;
					default:
						Console.WriteLine("Vnesi TIP!");
						break;
				}
			}

			var imot = Max(imoti);
			if (imot != null)
			{
				Console.WriteLine($"Najgolem Danok : {imot.CalculateDanok()} od vkuono : {imoti.Count}");
				Console.WriteLine(imot.Type());
			}
		}

		static Imot Max(List<Imot> imoti)
		{
			//return imoti.OrderByDescending(i => i.Danok()).FirstOrDefault();

			Imot result = null;
			foreach (var imot in imoti)
			{
				if (result == null)
				{
					result = imot;
				}
				if (result.CalculateDanok() < imot.CalculateDanok())
				{
					result = imot;
				}
			}

			return result;
		}
	}
}
