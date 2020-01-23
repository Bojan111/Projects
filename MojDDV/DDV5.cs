using System;
using System.Collections.Generic;
using System.Text;

namespace MojDDV
{
	class DDV5 : Product
	{
		public DDV5(double price) : base(price)
		{

		}
		public override double CalculateDDV()
		{
			return price * 5 / 100.0;
		}
		public override double DDV()
		{
			return 5 / 100.0;
		}
	}
}
