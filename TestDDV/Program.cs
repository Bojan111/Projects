using System;

namespace TestDDV
{
	class Program
	{
		static void Main(string[] args)
		{
			Console.WriteLine("For end type 'q'");
			var states = new State();
			while (true)
			{
				Console.WriteLine("Enter costumer name: ");
				var name = Console.ReadLine();
				if(name == "q")
				{
					break;
				}
				var person = new Costumer(name);
				states.AddCostumer(person);
				Console.WriteLine("Enter product: ");
				while (true)
				{
					Console.WriteLine("");
					Console.WriteLine("1. 18%");
					Console.WriteLine("2. 5%");
					Console.WriteLine("3. 0%");
					var productType = Console.ReadLine();
					if(productType == "q")
					{
						break;
					}
					Console.Write("Enter price: ");
					var product = GetProduct(productType);
					if(product != null)
					{
						person.AddProduct(product);
					}
				}
			}
			Console.WriteLine($"Total {states.TotalReturn()}");
			var tempc = states.Max();
			Console.WriteLine($"Ritches person {tempc.Name}, total earnings {tempc.DDVReturned()}");
		}
		public static Product GetProduct(string productType)
		{
			Product product = null;
			switch (productType)
			{
				case "1":
					product = new DDV18(double.Parse(Console.ReadLine()));
					break;
				case "2":
					product = new DDV5(double.Parse(Console.ReadLine()));
					break;
				case "3":
					product = new DDV0(double.Parse(Console.ReadLine()));
					break;
				default:
					Console.WriteLine("Not a valid product type!");
					break;
			}
			return product;
		}
	}
}
