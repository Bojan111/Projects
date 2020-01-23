using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace VehicleConfig
{
	class Vehicle
	{
		public VEngine.Engine Engine { get; set; }
		public Body.VehicleBody VehicleBody { get; set; }
		private List<IParts> parts;
		public Vehicle()
		{
			parts = new List<IParts>();
		}
		public void AddParts(IParts _parts)
		{
			parts.Add(_parts);
		}
		public int CalculateTotal()
		{
			//return Engine.CalculatePrice() + VehicleBody.CalculatePrice();
			return parts.Sum(x => x.CalculatePrice());
		}
		public void ReplacePart(IParts part)
		{
			parts.RemoveAll(item => item.Type() == part.Type());
			parts.Add(part);
		}
	}
}
