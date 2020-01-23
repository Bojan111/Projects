using System;
using System.Collections.Generic;
using System.Text;

namespace TestDDV
{
	class DDV18 : Product
	{
		public DDV18(double price) : base(price)
		{

		}
		public override double DDV()
		{
			return 18 / 100.0;
		}
		public override double CalculateDDV()
		{
			return Price * 18 / 100.0;
		}
	}
}
