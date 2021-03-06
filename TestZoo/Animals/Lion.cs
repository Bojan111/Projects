﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Zoo
{
	class Lion : Animal
	{
		public override void Eat(Food food)
		{
			if(food.Type() == "Meet")
			{
				FOOD.Add(food);
			}
			else
			{
				base.RaiseWrongFoodProvided(food);
			}
		}
		public override string Type()
		{
			return "Lion";
		}
	}
}
