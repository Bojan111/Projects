using System;
using System.Collections.Generic;
using System.Text;

namespace TEST
{
	class Zebra : Animal
	{
		public override string Type()
		{
			return "Zebra";
		}
		public override void Eat(Food food)
		{
			if (food.Type() == "Vegetable")
			{
				foods.Add(food);
			}
			else
			{
				RaiseWrongFoodProvided(food);
			}
		}
	}
}
