using System;
using System.Collections.Generic;
using System.Text;

namespace TestDDV
{
	class Costumer
	{
		public string Name;
		public List<Product> products;
		public Costumer(string _name)
		{
			Name = _name;
			products = new List<Product>();
		}
		public void AddProduct(Product _product)
		{
			products.Add(_product);
		}
		public double DDVReturned()
		{
			var sum = 0.0;
			foreach (var product in products)
			{
				sum += product.CalDDV();
			}
			return sum * 15/100.0;
		}
	}
}
