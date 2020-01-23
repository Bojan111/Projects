using DDV;
using System;
using System.Collections.Generic;
using System.Text;

namespace DDV
{
	class Person
	{
		public string name;
		public List<Product> products;
		public Person(string _name)
		{
			name = _name;
			products = new List<Product>();
		}
		public void AddProduct(Product _product)
		{
			products.Add(_product);
		}
		public double CalculateDDV()
		{
			var sum = 0.0;
			foreach (var product in products)
			{
				sum += product.ProductPrice();
			}
			return sum;
		}
	}
}
