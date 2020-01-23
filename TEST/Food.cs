using System;
using System.Collections.Generic;
using System.Text;

namespace TEST
{
	abstract class Food
	{
		public int Quantity { get; set; }
		public Food(int quantity) 
		{
			Quantity = quantity;
		}
		public abstract string Type();
		public abstract int Cost();

	}
}
