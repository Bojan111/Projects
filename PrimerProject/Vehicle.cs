using System;
using System.Collections.Generic;
using System.Text;

namespace PrimerProject
{
	class Vehicle
	{
		public List<IParts> parts;
		
		public Vehicle()
		{
			parts = new List<IParts>();
			
		}
		public void SetVehicle(IParts _parts)
		{
			parts.Add(_parts);
		}
		public double Total()
		{
			var sum = 0.0;
			foreach (var item in parts)
			{
				sum += item.Price();
			}
			return sum;
		}
	}
}
