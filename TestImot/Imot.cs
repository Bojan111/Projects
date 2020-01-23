using System;
using System.Collections.Generic;
using System.Text;

namespace TestImot
{
	abstract class Imot
	{
		public int M2 { get; set; }
		private string location;
		public string Location
		{
			get
			{
				return location;
			}
			set
			{
				if(value.Length <= 50)
				{
					location = value;
				}
			}
		}
		public Imot(int m2,string location)
		{
			M2 = m2;
			Location = location;
		}
		public abstract double CalculateDanok();
		public abstract string Type();
	}
}
