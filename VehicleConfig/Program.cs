using System;

namespace VehicleConfig
{
	class Program
	{
		static void Main(string[] args)
		{
			Console.WriteLine("For end type q");
			var vehicle = new Vehicle();
			vehicle.AddParts(CreateBody());
			vehicle.AddParts(CreateEngine());
			vehicle.AddParts(CreateWheels());
			vehicle.AddParts(CreateColor());

			Console.WriteLine($"Total Cost: {vehicle.CalculateTotal()}");
			var exit = false;
			do
			{
				Console.WriteLine("Which body parts you want to change:");
				Console.WriteLine("1. VehicleBody");
				Console.WriteLine("2. Engine");
				Console.WriteLine("3. Wheels");
				Console.WriteLine("4. Color");
				var change = Console.ReadLine();
				switch (change)
				{
					case "1":
						vehicle.ReplacePart(CreateBody());
						break;
					case "2":
						vehicle.ReplacePart(CreateEngine());
						break;
					case "3":
						vehicle.ReplacePart(CreateWheels());
						break;
					case "4":
						vehicle.ReplacePart(CreateColor());
						break;
					default:
						exit = true;
						break;
				}
				Console.WriteLine($"New Price {vehicle.CalculateTotal()}");
			} while (!exit);
		}
		static Body.VehicleBody CreateBody()
		{
			while (true)
			{
				Console.WriteLine("Enter Vehicle Body:");
				Console.WriteLine("1. Roadster");
				Console.WriteLine("2. Suv");
				Console.WriteLine("3. Limousine");

				var type = Console.ReadLine();

				Console.WriteLine("Enter price:");
				switch (type)
				{
					case "1":
						return new Body.Roadster(int.Parse(Console.ReadLine()));
					case "2":
						return new Body.Suv(int.Parse(Console.ReadLine()));
					case "3":
						return new Body.Limousine(int.Parse(Console.ReadLine()));
					default:
						Console.WriteLine("Enter valid type");
						break;

				}

			}
		}
		static VEngine.Engine CreateEngine()
		{
			while (true)
			{
				Console.WriteLine("Enter Engine:");
				Console.WriteLine("1. Diesel");
				Console.WriteLine("2. Petrol");
				Console.WriteLine("3. TurboDiesel");
				Console.WriteLine("4. TurboPetrol");
				Console.WriteLine("5. Electric");

				var type = Console.ReadLine();

				Console.WriteLine("Enter price:");
				switch (type)
				{
					case "1":
						return new VEngine.Diesel(int.Parse(Console.ReadLine()));
					case "2":
						return new VEngine.Petrol(int.Parse(Console.ReadLine()));
					case "3":
						return new VEngine.TurboDiesel(int.Parse(Console.ReadLine()));
					case "4":
						return new VEngine.TurboPetrol(int.Parse(Console.ReadLine()));
					default:
						Console.WriteLine("Enter valid type");
						break;

				}
			}
		}
		static VWheels.Wheels CreateWheels()
		{
			while (true)
			{
				Console.WriteLine("Enter Wheels:");
				Console.WriteLine("1. Alu");
				Console.WriteLine("2. Steal");

				var type = Console.ReadLine();

				Console.WriteLine("Enter price:");
				switch (type)
				{
					case "1":
						return new VWheels.Alu(int.Parse(Console.ReadLine()));
					case "2":
						return new VWheels.Steal(int.Parse(Console.ReadLine()));
					default:
						Console.WriteLine("Enter valid type");
						break;

				}
			}
		}
		static VColor.Color CreateColor()
		{
			while (true)
			{
				Console.WriteLine("Enter Color:");
				Console.WriteLine("1. Metalic");
				Console.WriteLine("2. Regular");

				var type = Console.ReadLine();

				Console.WriteLine("Enter price:");
				switch (type)
				{
					case "1":
						return new VColor.Metalic(int.Parse(Console.ReadLine()));
					case "2":
						return new VColor.Regular(int.Parse(Console.ReadLine()));
					default:
						Console.WriteLine("Enter valid type");
						break;

				}
			}
		}
	}
}
