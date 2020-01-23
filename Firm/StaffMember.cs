using System;
using System.Collections.Generic;
using System.Text;

namespace Firm
{
	class StaffMember : Employees
	{
		public int BasePayment { get; set; }

		public StaffMember(int payment)
		{
			BasePayment = payment;
		}
		public override int Payment()
		{
			return BasePayment;
		}
	}
}
