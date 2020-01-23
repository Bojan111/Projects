
using System;

namespace DDV
{
	class Program
	{
		static void Main(string[] args)
		{
			var state = new State();
			while (true)
			{
				Console.WriteLine("Enter name of costumer: ");
				var name = Console.ReadLine();
				if (name == "q")
				{
					break;
				}
				var person = new Person(name);

				while (true)
				{

					Console.WriteLine("Enter type of product");
					Console.WriteLine("1. Product with 18% ddv ");
					Console.WriteLine("2. Product with 5% ddv");
					Console.WriteLine("3. Product with 0% ddv");

					var input = Console.ReadLine();
					if(input == "q")
					{
						Console.WriteLine("Bye");
						break;
					}
					Product product = null;
					switch (input)
					{
						case "1":
							Console.WriteLine("Price: ");
							var price = double.Parse(Console.ReadLine());
							product = new DDV18(price);
							person.AddProduct(product);
							break;
						case "2":
							Console.WriteLine("Price: ");
							var price1 = double.Parse(Console.ReadLine());
							product = new DDV5(price1);
							person.AddProduct(product);
							break;
						case "3":
							Console.WriteLine("Price: ");
							var price2 = double.Parse(Console.ReadLine());
							product = new DDV0(price2);
							person.AddProduct(product);
							break;
					}
					state.AddPeople(person);
					Console.WriteLine($"Total {person.CalculateDDV()}");
				}
				

			}
			Console.WriteLine($"Total sum the state needs to pay {state.TotalReturn()}");
			Console.WriteLine($"Person with most DDV returned {state.CostumerMostMoneyReturned()}");
		}
		
	}
}
