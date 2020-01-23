using System;
using System.Collections.Generic;
using System.Text;

namespace BeautyShop.MemberShips
{
	class MemberShipCostum : Membership
	{
		private string name;
		public MemberShipCostum(string _name)
		{
			name = _name;
		}
		public double Discount { get; set; }
		public override double DiscountService()
		{
			return Discount / 100.0;
		}
		public override string MemberShipType()
		{
			return name;
		}
	}
}
