using System;
using System.Collections.Generic;
using System.Text;

namespace Student_Teacher
{
	abstract class Person
	{
		public string Name { get; set; }
		public Person(string name)
		{
			Name = name;
		}

		public abstract int SetAge();
	}
}
