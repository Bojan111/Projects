using System;

namespace TestZoo
{
	class Program
	{
		static void Main(string[] args)
		{
			Console.WriteLine("Enter q to quit!");

			var zoo = new Zoo();
			while (true)
			{
				Console.WriteLine();
				Console.WriteLine("Enter Animal Type: ");
				Console.WriteLine("1. Lion");
				Console.WriteLine("2. Tiger");
				Console.WriteLine("3. Zebra");

				Console.Write("Type (number): ");
				var type = Console.ReadLine();
				if (type == "q")
				{
					break;
				}

				Animal animal = null;
				switch (type)
				{
					case "1":
						animal = new Lion();
						break;
					case "2":
						animal = new Tiger();
						break;
					case "3":
						animal = new Zebra();
						break;

					default:
						Console.WriteLine("Not a valid animal type!");
						break;
				}

				if (animal != null)
				{
					Console.WriteLine();
					Console.WriteLine($"Feed the : {animal.Type()}.");
					animal.WrongFoodProvided += OnWrongFoodProvided;
					FeedAnimal(animal);
					zoo.AddAnimal(animal);
				}
			}

			Console.WriteLine($"Total Expenses for all animals: {zoo.TotalExpenses()}");
			var mostExpensive = zoo.MostExpensive();
			Console.WriteLine($"Most expensive animal to keep is: {mostExpensive.Type()}");
			Console.WriteLine($"It eats: {zoo.CostByAnimal(mostExpensive)}");
		}

		private static void OnWrongFoodProvided(object sender, FoodEventArgs eventArgs)
		{
			Console.WriteLine("*****************************");
			Console.WriteLine($"The food : {eventArgs.Food.Type()} was not eaten.");
			Console.WriteLine("*****************************");
		}

		static void FeedAnimal(Animal animal)
		{
			while (true)
			{
				Console.WriteLine();
				Console.WriteLine("Enter food type: ");
				Console.WriteLine("1. Meet");
				Console.WriteLine("2. Vegetables");

				Console.Write("Type (number): ");
				var type = Console.ReadLine();
				if (type == "q")
				{
					break;
				}

				Food food = null;
				switch (type)
				{
					case "1":
						food = new Meet(GetFoodQty());
						break;
					case "2":
						food = new Vegetable(GetFoodQty());
						break;
					default:
						Console.WriteLine("Not a valid food type!");
						break;
				}

				if (food != null)
				{
					animal.Eat(food);
				}
			}
		}

		private static int GetFoodQty()
		{
			Console.Write("Enter quantity (kg): ");
			return int.Parse(Console.ReadLine());
		}
	}
}

