using System;
using System.Collections.Generic;
using System.Text;

namespace Project
{
	abstract class Membership
	{
		public abstract MemberShipType Type();
		public abstract double DiscountServices();
		public double Discount { get; set; }
		public virtual double DiscountProduct()
		{
			return 10 / 100.0;
		}
	}
}
