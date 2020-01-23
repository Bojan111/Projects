using System;
using System.Collections.Generic;
using System.Text;

namespace BeautyShop.MemberShips
{
	class Gold : Membership
	{
		public override double DiscountService()
		{
			return 15 / 100.0;
		}
		public override string MemberShipType()
		{
			return "Gold";
		} 
	}
}
