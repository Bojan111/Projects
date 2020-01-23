using System;
using System.Collections.Generic;
using System.Text;

namespace Firm
{
	class Contractor : Employees
	{
		public int WorkingHours { get; set; }

		public int HourRate { get; set; }
		public Contractor(int hours,int hourrate)
		{
			WorkingHours = hourrate;
			HourRate = hourrate;
		}

		public override int Payment()
		{
			return WorkingHours * HourRate;
		}

	}
}
