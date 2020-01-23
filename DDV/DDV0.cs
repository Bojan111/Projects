using System;
using System.Collections.Generic;
using System.Text;

namespace DDV
{
	class DDV0 : Product
	{
		public DDV0(double price) : base(price)
		{

		}
		public override double ProductPrice()
		{
			return 0;
		}
	}
}
