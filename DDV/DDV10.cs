using System;
using System.Collections.Generic;
using System.Text;

namespace DDV
{
	class DDV10 : Product
	{	
		public DDV10(int price) : base(price)
		{

		}
		public override double ProductPrice()
		{
			return Price * 10 * 100.0;
		}
	}
}
