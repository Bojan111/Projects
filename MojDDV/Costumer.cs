using System;
using System.Collections.Generic;
using System.Text;

namespace MojDDV
{
	class Costumer
	{
		public List<Product> product;
		public string Name { get;private set; }
		public Costumer(string name)
		{
			Name = name;
			product = new List<Product>();
		}
		public void AddProduct(Product _product)
		{
			product.Add(_product);
		}
		public  double DDVReturned()
		{
			var sum = 0.0;
			foreach (var item in product)
			{
				sum += item.CallDDV();
			}
			return sum * 15 / 100.0;
		}
	}
}
