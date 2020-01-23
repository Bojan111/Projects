using System;

namespace ZooAnimalsProject
{
	class Program
	{
		static void Main(string[] args)
		{
			Console.WriteLine("For end type 'q'");
			var zoo = new Zoo();
			while (true)
			{
				Console.WriteLine("Enter animal type");
				Console.WriteLine("1. Lion");
				Console.WriteLine("2. Tiger");
				Console.WriteLine("3. Zebra");
				var type = Console.ReadLine();
				if(type == "q")
				{
					break;
				}
				Animals.Animal animal = null;
				switch (type)
				{
					case "1":
						animal = new Animals.Lion();
						break;
					case "2":
						animal = new Animals.Tiger();
						break;
					case "3":
						animal = new Animals.Zebra();
						break;
					default:
						Console.WriteLine("Not a valid animal type");
						break;
				}
				if(animal != null)
				{
					Console.WriteLine($"Feed the {animal.AnimalType()}");
					animal.WrongFoodProvided += OnRaiseWrongFoodProvided;
					FeedAnimal(animal);
					zoo.AddAnimal(animal);

				}
			}
			Console.WriteLine($"Total expenses for all animal {zoo.TotalExpenses()}");
			var mostExpenses = zoo.MostExpensive();
			Console.WriteLine($"Most expensive animal to keep is {mostExpenses.AnimalType()}");
			Console.WriteLine($"It eats {zoo.CostByKgAnimal(mostExpenses)}");
		}
		public static void OnRaiseWrongFoodProvided(object sender,FoodEventArgs eventArgs)
		{
			Console.WriteLine($"The food {eventArgs.Food.Type()} was not eaten");
		}
		static void FeedAnimal(Animals.Animal animal)
		{
			while (true)
			{
				Console.WriteLine("Enter Food Type");
				Console.WriteLine("1. Meet");
				Console.WriteLine("2. Vegetable");
				var meet = Console.ReadLine();
				if(meet == "q")
				{
					break;
				}
				Foods.Food food = null;
				switch (meet)
				{
					case "1":
						food = new Foods.Meet(Cost());
						break;
					case "2":
						food = new Foods.Vegetable(Cost());
						break;
					default:
						Console.WriteLine("Not a valid food type");
						break;
				}
				if(food != null)
				{
					animal.Eat(food);	
				}
			}
		}
		private static int Cost()
		{
			Console.WriteLine("Enter quantity by (kg)");
			return int.Parse(Console.ReadLine());
		}
	}
}
