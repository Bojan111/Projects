using System;
using System.Collections.Generic;

namespace Firm
{
	class Program
	{
		static void Main(string[] args)
		{
			Console.WriteLine("Type 0 for end!");
			var firm = new Firm();
			Console.WriteLine("Enter type of Employee: Manager,StaffMember,Contractor,Volunteer");
			while (true)
			{
				Console.WriteLine("Employee type: ");
				var input = int.Parse(Console.ReadLine());

				if (input == 1)
				{
					Console.WriteLine("Manager Base payment");
					var basepayment = int.Parse(Console.ReadLine());
					Console.WriteLine("Manager Bonus payment");
					var bonuspayment = int.Parse(Console.ReadLine());

					var manager = new Manager(basepayment, bonuspayment);
					firm.AddEmployeee(manager);
				}
				else if (input == 2)
				{
					Console.WriteLine("Staff member Base Payment");
					var staffBase = int.Parse(Console.ReadLine());
					var staffbase = new StaffMember(staffBase);
					firm.AddEmployeee(staffbase);
				}
				else if (input == 3)
				{
					Console.WriteLine("Constructor Hours: ");
					var hours = int.Parse(Console.ReadLine());
					Console.WriteLine("Hour Rate: ");
					var rate = int.Parse(Console.ReadLine());
					var constructor = new Contractor(hours, rate);
					firm.AddEmployeee(constructor);
				}
				else if(input == 4)
				{
					Console.WriteLine("Volunter Added");
					var volunter = new Volunteer();
				}
				else
				{
					Console.WriteLine("Bye!");
					break;
				}
				Console.WriteLine($"Total montly rate {firm.MontlyPayment()}");
			}
		}
	}
}
