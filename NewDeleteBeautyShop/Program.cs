using System;

namespace NewDeleteBeautyShop
{
	class Program
	{
		static void Main(string[] args)
		{
			Console.WriteLine("Fr end type 'q'");
			while (true)
			{
				Console.WriteLine("Enter costumer name");
				var name = Console.ReadLine();
				if(name == "q")
				{
					break;
				}
				var costumer = new Costumer();
				costumer.Name = name;

				Console.WriteLine("Enter membership");
				Console.WriteLine("1. Premium");
				Console.WriteLine("2. Gold");
				Console.WriteLine("3. Silver");
				Console.WriteLine("4. Custom");
				var type = Console.ReadLine();
				if(type == "q")
				{
					break;
				}
				Memberships.Membership membership = null;
				switch (type)
				{
					case "1":
						membership = new Memberships.Premium();
						break;
					case "2":
						membership = new Memberships.Gold();
						break;
					case "3":
						membership = new Memberships.Silver();
						break;
					case "4":
						Console.WriteLine("Enter custom memebership");
						var membershipcostum = new Memberships.costumermembership(Console.ReadLine());
						Console.WriteLine("Enter discount");
						membership = membershipcostum;
						break;
					default:
						Console.WriteLine("Not a valid membership type");
						break;
				}
				costumer.GetMembership(membership);
				var visit = new Visit(costumer);
				while (true)
				{
					Console.WriteLine("Buy Service");
					var money = Console.ReadLine();
					if(money == "q")
					{
						break;
					}
					visit.BuyServices(double.Parse(money));
				}
				while (true)
				{
					Console.WriteLine("Buy Products");
					var money = Console.ReadLine();
					if (money == "q")
					{
						break;
					}
					visit.BuyProducts(double.Parse(money));
				}
				Console.WriteLine($"{visit.GetCostumerInfo()}");
				Console.WriteLine($"Total cost: {visit.TotalCost()}");
			}
		}
	}
}
