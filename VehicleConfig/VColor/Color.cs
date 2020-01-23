using System;
using System.Collections.Generic;
using System.Text;

namespace VehicleConfig.VColor
{
	class Color : IParts
	{
		public int Price { get; set; }
		public Color(int price)
		{
			Price = price;
		}

		public string Type()
		{
			return "Color";
		}

		public int CalculatePrice()
		{
			return Price;
		}
	}
}
