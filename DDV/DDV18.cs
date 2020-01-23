using System;
using System.Collections.Generic;
using System.Text;

namespace DDV
{
	class DDV18 : Product
	{
		public DDV18(double price) : base(price)
		{

		}
		public override double ProductPrice()
		{
			return Price * 18 / 100.0;
		}
	}
}
