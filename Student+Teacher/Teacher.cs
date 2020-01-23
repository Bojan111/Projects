using System;
using System.Collections.Generic;
using System.Text;

namespace Student_Teacher
{
	class Teacher : Person
	{
		private string subject;
		public Teacher(string name) : base(name)
		{

		}
		
		public string Explain()
		{
			return "Zapocnuva objasnuvanje";
		}
		public string Info()
		{
			return "Zdravo, mojata vozrast " + 31;
		}
		public override int SetAge()
		{
			return 38;
		}
	}
}
