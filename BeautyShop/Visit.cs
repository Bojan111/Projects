using System;
using System.Collections.Generic;
using System.Text;

namespace BeautyShop
{
	class Visit
	{
		public Costumer costumers;
		public List<double> services;
		public List<double> products;
		public Visit(Costumer _costumer)
		{
			costumers = _costumer;
			services = new List<double>();
			products = new List<double>();
		}
		public void BuyServices(double pay)
		{
			services.Add(pay);
		}
		public void BuyProducts(double pay)
		{
			products.Add(pay);
		}
		public double Total()
		{
			var sum = 0.0;
			foreach (var service in services)
			{
				if (costumers.IsMember)
				{
					sum += service * (1 - costumers.membership.DiscountService());
				}
				else
				{
					sum += service;
				}
			}
			foreach (var product in products)
			{
				if (costumers.IsMember)
				{
					sum += product * (1 - costumers.membership.DiscountProducts());
				}
				else
				{
					sum += product;
				}
			}
			return sum;
		}
		public string GetCostumerName()
		{
			string result;
			if (costumers.IsMember)
			{
				result = $"{costumers.Name} has a membership: {costumers.membership.MemberShipType()}";
			}
			else
			{
				result = $"{costumers.Name} does not have a membership";
			}
			return result;
		}
	}
}
