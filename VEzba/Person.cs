using System;
using System.Collections.Generic;
using System.Text;

namespace VEzba
{
	class Person
	{
		public string Name;
		public string LastName;
		public int Age;

		private Addreses addres;

		public void AddName(string name, string lastname)
		{
			Name = name;
			LastName = lastname;
		}
		public string GetName()
		{
			return "The oldest person is :" + Name.ToString();
		}
		public void AddAge(int age)
		{
			if(age > 0)
			{
				Age = age;
			}
		}
		public void SetAddress(Addreses address)
		{
			this.addres = address;
		}
		public string Print()
		{
			var result = string.Empty;
			if (Age == 0)
			{
				result = $"{Name} {LastName}.";
			}
			else
			{
				result = $"{Name} {LastName}, {Age.ToString()} years old.";
			}

			result = $"{result} Address: {addres.GetAddreses()}";
			return result;
		}
	}
}
