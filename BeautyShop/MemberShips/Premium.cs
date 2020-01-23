using System;
using System.Collections.Generic;
using System.Text;

namespace BeautyShop.MemberShips
{
	class Premium : Membership
	{
		public override double DiscountService()
		{
			return 25 / 100.0;
		}
		public override string MemberShipType()
		{
			return "Premium";
		}
	}
}
