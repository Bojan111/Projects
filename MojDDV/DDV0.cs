using System;
using System.Collections.Generic;
using System.Text;

namespace MojDDV
{
	class DDV0 : Product
	{
		public DDV0(double price) : base(price)
		{

		}
		public override double DDV()
		{
			return 0;
		}
		public override double CalculateDDV()
		{
			return 0;
		}
	}
}
