using System;
using System.Collections.Generic;
using System.Text;

namespace Zoo
{
	abstract class Animal
	{
		public abstract string Type();
		public event WrongFoodProvided WrongFoodProvided;
		public List<Food> FOOD { get; private set; }
		public Animal()
		{
			FOOD = new List<Food>();
		}
		public abstract void Eat(Food food);
		public void RaiseWrongFoodProvided(Food food)
		{
			if (WrongFoodProvided != null)
			{
				var args = new FoodEventArgs();
				args.Food = food;
				WrongFoodProvided(this, args);
			}
		}
	}
}
