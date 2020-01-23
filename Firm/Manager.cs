using System;
using System.Collections.Generic;
using System.Text;

namespace Firm
{
	class Manager : Employees
	{
		public int BasePayment { get; set; }
		public int BonusPayment { get; set; }

		public Manager(int basepayment, int bonus)
		{
			BasePayment = basepayment;
			BonusPayment = bonus;
		}

		public override int Payment()
		{
			return BasePayment + BonusPayment;
		}
	}
}
