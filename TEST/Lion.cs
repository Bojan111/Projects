using System;
using System.Collections.Generic;
using System.Text;

namespace TEST
{
	class Lion : Animal
	{
		public override string Type()
		{
			return "Lion";
		}
		public override void Eat(Food food)
		{
			if(food.Type() == "Meet")
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
