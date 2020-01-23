using System;
using System.Collections.Generic;
using System.Text;

namespace Student_Teacher
{
	class Student : Person
	{
		public Student(string name) : base(name)
		{

		}

		public string GoToClasses()
		{
			return "Odam na cas";
		}
		public string Greeting()
		{
			return "Zdravo, jas imam " + 21;
		}
		public string ShowAge()
		{
			return "Mojata vozrast e " + 20;
		}
		public override int SetAge()
		{
			return 20;
		}
	}
}
