using System;
using System.Collections.Generic;
using System.Text;

namespace ZooAnimalsProject.Animals
{
	abstract class Animal
	{
		public abstract string AnimalType();
		public event WrongFoodProvided WrongFoodProvided;
		public List<Foods.Food> foods;
		public Animal()
		{
			foods = new List<Foods.Food>();
		}
		public abstract void Eat(Foods.Food food);
		public void RaiseWrongFoodProvided(Foods.Food food)
		{
			if(WrongFoodProvided != null)
			{
				var args = new FoodEventArgs();
				args.Food = food;
				WrongFoodProvided(this, args);
			}
		}
	}
}
