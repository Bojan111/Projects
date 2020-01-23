using System;
using System.Collections.Generic;
using System.Text;

namespace Zoo
{
	class Vegetable : Food
	{
		public Vegetable(int quantity) : base(quantity)
		{

		}
		public override int Cost()
		{
			return Quantity * 2;
		}
		public override string Type()
		{
			return "Meet";
		}
	}
}
