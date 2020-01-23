using System;
using System.Collections.Generic;
using System.Text;

namespace TestDDV
{
	class State
	{
		public List<Costumer> costumers;
		public State()
		{
			costumers = new List<Costumer>();
		}
		public void AddCostumer(Costumer _costumer)
		{
			costumers.Add(_costumer);
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
			Costumer costumerMax = null;
			foreach (var item in costumers)
			{
				if (costumerMax == null)
				{
					costumerMax = item;
				}
				if(costumerMax.DDVReturned() < costumerMax.DDVReturned())
				{
					costumerMax = item;
				}
			}
			return costumerMax;
		}
	}
}
