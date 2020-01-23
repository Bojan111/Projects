using System;
using System.Collections.Generic;
using System.Text;

namespace Project
{
	class Gold : Membership
	{
		public override MemberShipType Type()
		{
			return MemberShipType.Gold;
		}
		public override double DiscountServices()
		{
			return 15 / 100.0;
		}
	}
}
