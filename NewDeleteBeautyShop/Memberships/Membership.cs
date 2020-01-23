using System;
using System.Collections.Generic;
using System.Text;

namespace NewDeleteBeautyShop.Memberships
{
	abstract class Membership
	{
		public abstract double DiscountService();
		public abstract string MembershipType();

		public virtual double DiscountProducts()
		{
			return 15 / 100.0;
		}
	}
}
