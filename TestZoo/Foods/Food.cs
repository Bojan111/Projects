using System;
using System.Collections.Generic;
using System.Text;

namespace TestZoo
{
	abstract class Food
	{
		public int Quantity { get; private set; }
		public Food(int quantity)
		{
			Quantity = quantity;
		}

		public abstract string Type();
		public abstract int Cost();
	}
}
