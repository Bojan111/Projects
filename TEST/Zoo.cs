using System;
using System.Collections.Generic;
using System.Text;

namespace TEST
{
	class Zoo
	{
		public List<Animal> animals;
		public Zoo()
		{
			animals = new List<Animal>();
		}
		public void AddAnimal(Animal _animal)
		{
			animals.Add(_animal);
		}
		public Animal MostExpenses()
		{
			Animal mostexpenses = null;
			foreach (var animal in animals)
			{
				if(mostexpenses == null)
				{
					mostexpenses = animal;
				}
				if (CostByAnimal(mostexpenses) < CostByAnimal(animal))
				{
					mostexpenses = animal;
				}
			}
			return mostexpenses;
		}
		public int CostByAnimal(Animal animal)
		{
			var sum = 0;
			foreach (var food in animal.foods)
			{
				sum += food.Cost();
			}
			return sum;
		}
		public int TotalExpenses()
		{
			var sum = 0;
			foreach (var animal in animals)
			{
				sum += CostByAnimal(animal);
			}
			return sum;
		}
	}
}
