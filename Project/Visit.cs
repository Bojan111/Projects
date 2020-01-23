using System;
using System.Collections.Generic;
using System.Text;

namespace Project
{
	class Visit
	{
		public Costumer costumers;
		
		public Discount Discounts { get; set; }
		public List<Product> Products { get; set; }
		public Visit()
		{
			Products = new List<Product>();
		}

		//public double Total()
		//{
			
		//	var sum = 0.0;
		//	foreach (var product in Products)
		//	{
		//		if(product.TypeProduct == ProductType.Product)
		//		{
		//			sum += product.Price * (1 - Discounts.DiscountProduct);
		//		}
		//		if (product.TypeProduct == ProductType.Service)
		//		{
		//			sum += product.Price * (costumers.membership ? (1- costumers.membership.DiscountProduct()) : 1);
		//		}
		//	}
		//	return sum;
		//}
		
		
	}
}
