using System;
using System.Collections.Generic;
using System.Text;

namespace Firm
{
	class Firm
	{
		public List<Employees> Employee;

		public Firm()
		{
			Employee = new List<Employees>();
		}
		public void AddEmployeee(Employees employee)
		{
			Employee.Add(employee);
		}

		public int MontlyPayment()
		{
			int sum = 0;
			foreach (var item in Employee)
			{
				sum += item.Payment();
			}
			return sum;
		}
	}
}
