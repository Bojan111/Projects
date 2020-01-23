using System;
using System.Collections.Generic;
using System.Text;

namespace HouseProject
{
	class Door
	{
		public string Color { get; set; }
		private string door;
		public Door(string color, string _door)
		{
			Color = color;
			door = _door;
		}
		public string ShowData()
		{
			return "Jas sum vrata, mojata boja e kafeava";
		}
		public string GetColor()
		{
			return Color;
		}
		public string GetDoor()
		{
			return door;
		}
	}
}
