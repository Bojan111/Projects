using System;

namespace BeautyShop
{
	class Program
	{
		static void Main(string[] args)
		{
			Console.WriteLine("For end type 'q'");
			while (true)
			{
				Console.WriteLine("Enter Costumer Name: ");
				var name = Console.ReadLine();
				if(name == "q")
				{
					break;
				}
				var costumer = new Costumer();
				costumer.Name = name;

				Console.WriteLine("Enter Membership:");
				Console.WriteLine("1. Premium");
				Console.WriteLine("2. Gold");
				Console.WriteLine("3. Silver");
				Console.WriteLine("4. Costum");
				var type = Console.ReadLine();
				if(type == "q")
				{
					break;
				}
				MemberShips.Membership membership = null;
				switch (type)
				{
					case "1":
						membership = new MemberShips.Premium();
						break;
					case "2":
						membership = new MemberShips.Gold();
						break;
					case "3":
						membership = new MemberShips.Silver();
						break;
					case "4":
						Console.WriteLine("Enter Costum Membership: ");
						var membershipCostum = new MemberShips.MemberShipCostum(Console.ReadLine());
						Console.WriteLine("Enter Discount: ");
						membership = membershipCostum;
						break;
					default:
						Console.WriteLine("Not a valid membership type");
						break;
				}
				costumer.AddMemberShip(membership);
				var visit = new Visit(costumer);
				while (true)
				{
					Console.WriteLine("Buy Services:");
					var money = Console.ReadLine();
					if(money == "q")
					{
						break;
					}
					visit.BuyServices(double.Parse(money));
				}
				while (true)
				{
					Console.WriteLine("Buy Products:");
					var money = Console.ReadLine();
					if (money == "q")
					{
						break;
					}
					visit.BuyProducts(double.Parse(money));
				}
				Console.WriteLine($"{visit.GetCostumerName()}");
				Console.WriteLine($"Total cost: {visit.Total()}");
			}
		}
	}
}
