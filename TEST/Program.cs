using System;
using System.Collections.Generic;

namespace TEST
{
	class Program
	{
		static void Main(string[] args)
		{
			Console.WriteLine("For edn type q");
			var zoo = new Zoo();

			while (true)
			{
				Console.WriteLine("Enter Animal Type");
				Console.WriteLine("1. Lion");
				Console.WriteLine("2. Tiger");
				Console.WriteLine("3. Zebra");

				Console.WriteLine("Type (number)");
				var type = Console.ReadLine();
				if(type == "q")
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
						Console.WriteLine("Not valid animal type");
						break;
				}
				if(animal != null)
				{
					Console.WriteLine($"Feed the {animal.Type()}");
					animal.WrongFoodProvided += OnWrongFoodProvided;
					FeedAnimal(animal);
					zoo.AddAnimal(animal);
				}
				Console.WriteLine($"Total expenses for all animal {zoo.TotalExpenses()}");
				var mostexpenses = zoo.MostExpenses();
				Console.WriteLine($"Most expneses animal {mostexpenses.Type()}");
				Console.WriteLine($"It eats {zoo.CostByAnimal(mostexpenses)}");
			}
		}
		public static void OnWrongFoodProvided(object sender, FoodEventArgs eventArgs)
		{
			Console.WriteLine($"The {eventArgs.Food.Type()} was not eaten");
		}
		private static void FeedAnimal(Animal animal)
		{
			while (true)
			{
				Console.WriteLine("Enter Food Type");
				Console.WriteLine("1. Meet");
				Console.WriteLine("2. Vegetable");

				Console.WriteLine("Type (number)");
				var type = Console.ReadLine();
				if (type == "q")
				{
					break;
				}
				Food food = null;
				switch (type)
				{
					case "1":
						food = new Meet(GetByKg());
						break;
					case "2":
						food = new Vegetable(GetByKg());
						break;
				}

				if (food != null)
				{
					animal.Eat(food);
				}

			}

		}
		public static int GetByKg()
		{
			Console.WriteLine("Enter Quantity (kg)");
			return int.Parse(Console.ReadLine());
		}
	}
}
