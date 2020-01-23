using System;
using System.Collections.Generic;
using System.Text;

namespace VehicleConfig.VEngine
{
	class Engine : IParts
	{
		public int Price { get; set; }
		public Engine(int price)
		{
			Price = price;
		}

		public string Type()
		{
			return "Engine";
		}

		public int CalculatePrice()
		{
			return Price;
		}
	}
}
