using System;
using System.Collections.Generic;
using System.Text;

namespace Project
{
	abstract class Product
	{
		public double Price { get; set; }
		public ProductType TypeProduct { get; set; }
		public Product(double price,ProductType product)
		{
			TypeProduct = product;
			Price = price;
		}
	}
}
