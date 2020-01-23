using System;
using System.Collections.Generic;
using System.Text;

namespace TestDDV
{
	abstract class Product
	{
		public double Price { get; set; }
		public Product(double price)
		{
			Price = price;
		}
		public abstract double DDV();
		public virtual double CalDDV()
		{
			return Price * DDV();
		}
		public abstract double CalculateDDV();
	}
}
