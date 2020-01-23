using System;
using System.Collections.Generic;
using System.Text;

namespace NewDeleteBeautyShop.Memberships
{
	class costumermembership :Membership
	{
		private string name;
		public costumermembership(string _name)
		{
			name = _name;
		}
		public double Discount { get; set; }
		public override double DiscountService()
		{
			return Discount / 100.0;
		}
		public override string MembershipType()
		{
			return name;
		}
	}
}
