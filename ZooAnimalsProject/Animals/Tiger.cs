using System;
using System.Collections.Generic;
using System.Text;

namespace ZooAnimalsProject.Animals
{
	class Tiger : Animal
	{
		public override string AnimalType()
		{
			return "Tiger";
		}
		public override void Eat(Foods.Food food)
		{
			if (food.Type() == "Meet")
			{
				foods.Add(food);
			}
			else
			{
				base.RaiseWrongFoodProvided(food);
			}
		}
	}
}
