using System;
using System.Collections.Generic;
using System.Text;

namespace TEST
{
	abstract class Animal
	{
		public abstract string Type();

		public event WrongFoodProvided WrongFoodProvided;
		public List<Food> foods;
		public Animal()
		{
			foods = new List<Food>();
		}
		public abstract void Eat(Food food); 

		public virtual void RaiseWrongFoodProvided(Food food)
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
