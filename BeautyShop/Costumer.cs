using System;
using System.Collections.Generic;
using System.Text;

namespace BeautyShop
{
	class Costumer
	{
		public string Name { get; set; }
		public bool IsMember
		{
			get
			{
				return membership != null;
			}
		}
		public MemberShips.Membership membership { get; set; }
		public void AddMemberShip(MemberShips.Membership _membership)
		{
			membership = _membership;
		}
	}
}
