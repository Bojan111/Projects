using System;
using System.Collections.Generic;
using System.Text;

namespace NewDeleteBeautyShop
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
		public Memberships.Membership membership { get; set; }
		public void GetMembership(Memberships.Membership _membership)
		{
			membership = _membership;
		}
	}
}
