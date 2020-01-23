using System;
using System.Collections.Generic;
using System.Text;

namespace DDV
{
	class State
	{
		private List<Person> people;
		public State()
		{
			people = new List<Person>();
		}
		public void AddPeople(Person person)
		{
			people.Add(person);
		}
		public double TotalReturn()
		{
			double sum = 0;
			foreach (var item in people)
			{
				sum += item.CalculateDDV();
			}
			return sum;
		}
		public string CostumerMostMoneyReturned()
		{
			string name = null;
			double sum = 0;
			foreach (var item in people)
			{
				if(sum < item.CalculateDDV())
				{
					sum = item.CalculateDDV();
					name = item.name;
				}
				
			}
			return name;
			}
	}
}
