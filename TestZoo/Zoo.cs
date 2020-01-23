using System;
using System.Collections.Generic;
using System.Text;

namespace TestZoo
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
		public Animal MostExpensive()
		{
			Animal mostexpenses = null;
			foreach (var item in animals)
			{
				if(mostexpenses == null)
				{
					mostexpenses = item;
				}
				if(CostByAnimal(mostexpenses) < CostByAnimal(item))
				{
					mostexpenses = item;
				}
			}
			return mostexpenses;
		}
		public int CostByAnimal(Animal animal)
		{
			var sum = 0;
			foreach (var Food in animal.FOOD)
			{
				sum += Food.Cost();
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
