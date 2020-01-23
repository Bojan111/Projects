using System;
using System.Collections.Generic;
using System.Text;

namespace TestDDV
{
	class DDV5 : Product
	{
		public DDV5(double price) : base(price)
		{

		}
		public override double DDV()
		{
			return 5/100.0;
		}
		public override double CalculateDDV()
		{
			return Price * 5/100.0;
		}
	}
}
