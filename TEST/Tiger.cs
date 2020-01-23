using System;
using System.Collections.Generic;
using System.Text;

namespace TEST
{
	class Tiger : Animal
	{
		public override string Type()
		{
			return "Tiger";
		}
		public override void Eat(Food food)
		{
			if (food.Type() == "Meet")
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
