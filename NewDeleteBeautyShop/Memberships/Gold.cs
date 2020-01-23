using System;
using System.Collections.Generic;
using System.Text;

namespace NewDeleteBeautyShop.Memberships
{
	class Gold : Membership
	{
		public override double DiscountService()
		{
			return 15 / 100.0;

		}
		public override string MembershipType()
		{
			return "Gold";
		}
	}
}
