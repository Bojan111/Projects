using System;

namespace HouseProject
{
	class Program
	{
		static void Main(string[] args)
		{
			Console.WriteLine("Enter Information");
			Console.Write("Enter name: ");
			var name = Console.ReadLine();
			var people = new Person(name);

			Console.Write("Enter m2: ");
			var m2 = int.Parse(Console.ReadLine());
			var house = new House(m2);
			Console.Write("Enter color: ");
			var color = Console.ReadLine();
			Console.Write("Enter door: ");
			var door = Console.ReadLine();
			var doors = new Door(color,door);

			Console.WriteLine($"{house.ShowData()}\n{doors.ShowData()}");
			Console.WriteLine("=======================================");
			Console.WriteLine($"New Information:");
			Console.WriteLine($"Name of owner: {people.Name}");
			Console.WriteLine($"M2: {house.GetM2()}");
			Console.WriteLine($"Color: {doors.GetColor()}");
			Console.WriteLine($"Door: {doors.GetDoor()}");
		}
	}
}
