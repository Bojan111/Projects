using System;
using System.Collections.Generic;
using System.Text;

namespace HouseProject
{
	class House
	{
		public int Price { get; set; }
		public House(int price)
		{
			Price = price;
		}
		public string ShowData()
		{
			return "Ja sum kukja, mojata povrsina e 200m2";
		}
		public int GetM2()
		{
			return Price;
		}
	}
}
