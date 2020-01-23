using System;
using System.Collections.Generic;

namespace Kosarkarski_tim
{
	class Program
	{
		static void Main(string[] args)
		{
			Console.WriteLine("For end type 'q'");
			var visit = new Visit();
			while (true)
			{
				Console.WriteLine("Vnesi ime na trener");
				var name = Console.ReadLine();
				if(name == "q")
				{
					break;
				}
				var person = new Trener();
				person.AddName(name);

				Console.WriteLine("Enter klub or preznetacija");
				Console.WriteLine("1. Klub");
				Console.WriteLine("2. Prezentacija");

				var type = Console.ReadLine();
				KosarkarskiTim tim = null;
				switch (type)
				{
					case "1":
						tim = new Klub();
						break;
					case "2":
						tim = new Reprezentacija();
						break;
				}
				visit.AddTeams(tim);
				Console.WriteLine($"{visit.Total()}");
			}
		}
	}
}
