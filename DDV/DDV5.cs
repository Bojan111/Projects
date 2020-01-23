using System;
using System.Collections.Generic;
using System.Text;

namespace DDV
{
	class DDV5 : Product
	{
		public DDV5(double price) : base(price)
		{

		}
		public override double ProductPrice()
		{
			return Price * 5 / 100.0;
		}
	}
}
