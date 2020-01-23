using System;
using System.Collections.Generic;
using System.Text;

namespace VehicleConfig.Body
{
	class VehicleBody : IParts
	{
		public int Price { get; set; }
		public VehicleBody(int price)
		{
			Price = price;
		}
		public int CalculatePrice()
		{
			return Price;
		}

		public string Type()
		{
			return "Body";
		}
	}
}
