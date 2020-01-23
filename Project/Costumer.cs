using System;
using System.Collections.Generic;
using System.Text;

namespace Project
{
	class Costumer
	{
		public string Name { get; set; }
		public Membership membership { get; set; }
		public bool IsMember
		{
			get
			{
				return membership != null;
			}
		}
		public void GetMemberShip(Membership _membership)
		{
			membership = _membership;
		}
	}
}
