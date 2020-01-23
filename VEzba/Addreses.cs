using System;
using System.Collections.Generic;
using System.Text;

namespace VEzba
{
	class Addreses
	{
		public string City;
		public string Street;
		public int Number;
		public Addreses(string city, string street,int number)
		{
			City = city;
			Street = street;
			Number = number;
		}
		public string GetAddreses()
		{
			return $"City: {City}, Street: {Street}, Number {Number}";
		}
	}

}
