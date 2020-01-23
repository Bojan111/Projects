using System;
using System.Collections.Generic;
using System.Text;

namespace NewDeleteBeautyShop
{
	class Visit
	{
		public Costumer costumer;
		public List<double> services;
		public List<double> products;
		public Visit(Costumer _costumer)
		{
			costumer = _costumer;
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
		public double TotalCost()
		{
			double sum = 0.0;
			foreach (var service in services)
			{
				if (costumer.IsMember)
				{
					sum += service * (1 - costumer.membership.DiscountService());
				}
				else
				{
					sum += service;
				}
			}
			foreach (var product in products)
			{
				if (costumer.IsMember)
				{
					sum += product * (1 - costumer.membership.DiscountProducts());
				}
				else
				{
					sum += product;
				}
			}
			return sum;
		}
		public string GetCostumerInfo()
		{
			string result;
			if (costumer.IsMember)
			{
				result = $"{costumer.Name} has membership {costumer.membership.MembershipType()}";
			}
			else
			{
				result = $"{costumer.Name} does not have a membership";
			}
			return result;
		}
	}
}
