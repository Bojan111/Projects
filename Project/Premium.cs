using System;
using System.Collections.Generic;
using System.Text;

namespace Project
{
	class Premium : Membership
	{
		public override MemberShipType Type()
		{
			return MemberShipType.Premium;
		}
		public override double DiscountServices()
		{
			return 20 / 100.0;
		}
	}
}
