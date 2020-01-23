using System;
using System.Collections.Generic;
using System.Text;

namespace NewDeleteBeautyShop.Memberships
{
	class Premium : Membership
	{
		public override double DiscountService()
		{
			return 25 / 100.0;
			
		}
		public override string MembershipType()
		{
			return "Premium";
		}
	}
}
