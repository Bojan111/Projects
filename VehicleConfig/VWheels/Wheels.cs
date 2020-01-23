using System;
using System.Collections.Generic;
using System.Text;

namespace VehicleConfig.VWheels
{
	class Wheels : IParts
	{
		public int Price { get; set; }
		public Wheels(int price)
		{
			Price = price;
		}

		public string Type()
		{
			return "Wheels";
		}

		public int CalculatePrice()
		{
			return Price;
		}
	}
}
