using System;
using System.Collections.Generic;
using System.Text;

namespace MojDDV
{
	class State
	{
		public List<Costumer> costumers;
		public State()
		{
			costumers = new List<Costumer>();
		}
		public void AddCostumer(Costumer people)
		{
			costumers.Add(people);
		}
		public double TotalReturn()
		{
			var sum = 0.0;
			foreach (var item in costumers)
			{
				sum += item.DDVReturned();
			}
			return sum;
		}
		public Costumer Max()
		{
			Costumer costumer = null;
			foreach (var people in costumers)
			{
				if(costumer == null)
				{
					costumer = people;
				}
				if(costumer.DDVReturned() < costumer.DDVReturned())
				{
					costumer = people;
				}
			}
			return costumer;
		}
	}
}
