using System;
using System.Collections.Generic;
using System.Text;

namespace HouseProject
{
	class SmallApt : House
	{
		private int povrsina;
		public SmallApt(int price) : base(price)
		{
			povrsina = 50;
		}
		public int GetPovrsina()
		{
			return povrsina;
		}
	}
}
