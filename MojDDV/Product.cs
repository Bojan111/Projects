using System;
using System.Collections.Generic;
using System.Text;

namespace MojDDV
{
	abstract class Product
	{
		protected double price;
		public Product(double price)
		{
			this.price = price;
		}

		public abstract double DDV();
		public double CallDDV()
		{
			return price * DDV();
		}
		public abstract double CalculateDDV();
	}
}
