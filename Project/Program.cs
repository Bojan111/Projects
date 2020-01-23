using System;
using System.Collections.Generic;

namespace Project
{
	class Program
	{
		static void Main(string[] args)
		{
			//	Console.WriteLine("For end type 'q'");
			//	while (true)
			//	{
			//		Console.WriteLine("Enter costumer name");
			//		var name = Console.ReadLine();
			//		if(name == "q")
			//		{
			//			Console.WriteLine("Bye!");
			//			break;
			//		}
			//		var costumer = new Costumer();
			//		costumer.Name = name;

			//		Console.WriteLine("Enter Membership: ");
			//		Console.WriteLine("1. Premium");
			//		Console.WriteLine("2. Gold");
			//		Console.WriteLine("3. Silver");
			//		Console.WriteLine("4. Costum");
			//		var type = Console.ReadLine();
			//		if(type == "q")
			//		{
			//			break;
			//		}
			//		Membership membership = null;
			//		switch (type)
			//		{
			//			case "1":
			//				membership = new Premium();
			//				break;
			//			case "2":
			//				membership = new Gold();
			//				break;
			//			case "3":
			//				membership = new Silver();
			//				break;
			//			case "4":
			//				Console.WriteLine("Enter Costum MemberShip: ");
			//				var membershipCostum = new CostumerMemberShipCostum(Console.ReadLine());
			//				membership = membershipCostum;
			//				break;
			//			default:
			//				Console.WriteLine("Not a valid membership type");
			//				break;
			//		}
			//		costumer.GetMemberShip(membership);
			//		var visit = new Visit(costumer);
			//		while (true)
			//		{
			//			Console.WriteLine("Buy Service");
			//			var money = Console.ReadLine();
			//			if(money == "q")
			//			{
			//				break;
			//			}
			//			visit.BuyServices(double.Parse(money));
			//		}
			//		while (true)
			//		{
			//			Console.WriteLine("Buy Product");
			//			var money = Console.ReadLine();
			//			if (money == "q")
			//			{
			//				break;
			//			}
			//			visit.BuyProducts(double.Parse(money));
			//		}
			//		Console.WriteLine($"{visit.GetCostumerInfo()}");
			//		Console.WriteLine($"Total Cost: {visit.Total()}");
			//	}
			//}



			//var test = "abbcbba";
			//var isPalindrom = true;
			//for (int i = 0; i < test.Length / 2; i++)
			//{
			//	if(test[i] != test[test.Length - 1 - 1])
			//	{
			//		isPalindrom = false;
			//		break;
			//	}
			//}

			//Console.WriteLine(isPalindrom);


			int[] a ={ 3,2,5,7,1 };
			int b;
			Console.WriteLine("Number:");
			foreach (int item in a)
			Console.Write(item + " ");
			for (int i = 0; i <= a.Length - 2; i++)
			{
				for (int j = 0; j <= a.Length - 2; j++)
				{
					if (a[j] > a[j + 1])
					{
						b = a[j + 1];
						a[j + 1] = a[j];
						a[j] = b;
					}
				}
			}
			Console.WriteLine("\n" +"Sorted Number :");
			foreach (int item in a)
			Console.Write(item + " ");

		}
	}
}
