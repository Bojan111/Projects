using System;
using System.Collections.Generic;
using System.Text;

namespace Project
{
	class Silver:Membership
 	{
		public override MemberShipType	 Type()
		{
			return MemberShipType.Silver;
		}
		public override double DiscountServices()
		{
			return 10 / 100.0;
		}
	}
}
