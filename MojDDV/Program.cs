using System;

namespace MojDDV
{
	class Program
	{
		static void Main(string[] args)
		{
			Console.WriteLine("Enter 'q' for exit");
			var states = new State();
			while (true)
			{
				Console.WriteLine("Enter costumer name");
				var costumername = Console.ReadLine();
				if(costumername == "q")
				{
					break;
				}
				var person = new Costumer(costumername);
				states.AddCostumer(person);

				Console.WriteLine("Enter product");
				while (true)
				{
					Console.WriteLine("1. 18%");
					Console.WriteLine("2. 5%");
					Console.WriteLine("3. 0%");
					var productype = Console.ReadLine();
					if(productype == "q")
					{
						break;
					}
					Console.WriteLine("Enter price: ");
					var product = GetProduct(productype);
					if(product != null)
					{
						person.AddProduct(product);
					}
				}
			}
			Console.WriteLine($"Total {states.TotalReturn()}");
			var tempc = states.Max();
			Console.WriteLine($"Riches person {tempc.Name}, total earnings {tempc.DDVReturned()}");

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
