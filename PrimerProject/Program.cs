using System;

namespace PrimerProject
{
	class Program
	{
		static void Main(string[] args)
		{
			Console.WriteLine("Enter Vehicle");
			var vehicle = new Vehicle();
			while (true)
			{
				Console.WriteLine(	"Enter body");
				Console.WriteLine("1. Suv");
				Console.WriteLine("2. Roadster");
				Console.WriteLine("3. Limousine");
				var type = Console.ReadLine();
				if(type == "q")
				{
					break;
				}
				switch (type)
				{
					case "1":
						var body= Body.SUV;
						break;
					case "2":
						var body1 = Body.Roadster;
						break;
					case "3":
						var body2 = Body.Limousine;
						break;	
				}
				Console.WriteLine("Enter Engine");
				Console.WriteLine("1. Diesel");
				Console.WriteLine("2. Petrol");
				Console.WriteLine("3. TurboDiesel");
				Console.WriteLine("4. TurboPetrol");
				var types = Console.ReadLine();
				if(types == "q")
				{
					break;
				}
				switch (types)
				{
					case "1":
						var diesel = Engine.Diesel;
						break;
					case "2":
						var petrol = Engine.Petrol;
						break;
					case "3":
						var turbodiesel = Engine.TurboDiesel;
						break;
					case "4":
						var turbopetrol = Engine.TurboPetrol;
						break;
				}
			}
			
		}
		//static Body CreateBody()
		//{
		//	while (true)
		//	{
		//		Console.WriteLine("Enter Body");
		//		Console.WriteLine("1. Suv");
		//		Console.WriteLine("2. Roadster");
		//		Console.WriteLine("3. Limousine");
				
		//		var type = Console.ReadLine();
		//		Console.WriteLine("Enter price: ");
		//		switch (type)
		//		{
		//			case "1":
		//				return Body.SUV;
		//			case "2":
		//				return Body.Roadster;
		//			case "3":
		//				return Body.Limousine;
		//			default:
		//				Console.WriteLine("Not a valid body type");
		//				break;
		//		}
		//	}
		//}
		//static Engine CreateEngine()
		//{
		//	while (true)
		//	{
		//		Console.WriteLine("Enter Engine");
		//		Console.WriteLine("1. Diesel");
		//		Console.WriteLine("2. Petrol");
		//		Console.WriteLine("3. TurboDiesel");
		//		Console.WriteLine("4. TurboPetrol ");
		//		var type = Console.ReadLine();
		//		Console.WriteLine("Enter price: ");
		//		switch (type)
		//		{
		//			case "1":
		//				return Engine.Diesel;
		//			case "2":
		//				return Engine.Petrol;
		//			case "3":
		//				return Engine.TurboDiesel;
		//			case "4":
		//				return Engine.TurboPetrol;
		//			default:
		//				Console.WriteLine("Not a valid engine type");
		//				break;
		//		}
		//	}
		//}
		//static Wheels CreateWheels()
		//{
		//	while (true)
		//	{
		//		Console.WriteLine("Enter Wheels");
		//		Console.WriteLine("1. Alu");
		//		Console.WriteLine("2. Steal");
			
		//		var type = Console.ReadLine();
		//		Console.WriteLine("Enter price: ");
		//		switch (type)
		//		{
		//			case "1":
		//				return Wheels.Alu;
		//			case "2":
		//				return Wheels.Steal;
		//			default:
		//				Console.WriteLine("Not a valid Wheels type");
		//				break;
		//		}
		//	}
		//}
		//static Color CreateColor()
		//{
		//	while (true)
		//	{
		//		Console.WriteLine("Enter Color");
		//		Console.WriteLine("1. Regular");
		//		Console.WriteLine("2. Metalic");

		//		var type = Console.ReadLine();
		//		Console.WriteLine("Enter price: ");
		//		switch (type)
		//		{
		//			case "1":
		//				return Color.Regular;
		//			case "2":
		//				return Color.Metalic;
		//			default:
		//				Console.WriteLine("Not a valid color type");
		//				break;
		//		}
		//	}
		//}
	}
}
