using System;
using System.Collections.Generic;
using System.Text;

namespace DDV
{
	abstract class Product
	{
		public double Price;
		public Product(double price)
		{
			this.Price = price;
		}
		public abstract double ProductPrice();
		public double CalDDV()
		{
			return Price * ProductPrice();
		}
	}
}
