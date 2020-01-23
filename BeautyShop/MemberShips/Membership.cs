using System;
using System.Collections.Generic;
using System.Text;

namespace BeautyShop.MemberShips
{
	abstract class Membership
	{
		public abstract double DiscountService();
		public abstract string MemberShipType();

		public virtual double DiscountProducts()
		{
			return 15 / 100.0;
		}
	}
}
