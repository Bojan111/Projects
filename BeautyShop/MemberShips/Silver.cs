using System;
using System.Collections.Generic;
using System.Text;

namespace BeautyShop.MemberShips
{
	class Silver : Membership
	{
		public override double DiscountService()
		{
			return 10 / 100.0;
		}
		public override string MemberShipType()
		{
			return "Silver";
		}
	}
}
