using System;
using System.Collections.Generic;
using System.Text;
using ZooAnimalsProject.Foods;

namespace ZooAnimalsProject.Animals
{
	class Zebra : Animal
	{
		public override string AnimalType()
		{
			return "Zebra";
		}
		public override void Eat(Food food)
		{
			if(food.Type() == "Vegetable")
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
