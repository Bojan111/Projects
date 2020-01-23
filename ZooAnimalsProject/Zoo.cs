using System;
using System.Collections.Generic;
using System.Text;

namespace ZooAnimalsProject
{
	class Zoo
	{
		public List<Animals.Animal> animals;
		public Zoo()
		{
			animals = new List<Animals.Animal>();
		}
		public void AddAnimal(Animals.Animal animal)
		{
			animals.Add(animal);
		}
		public Animals.Animal MostExpensive()
		{
			Animals.Animal mostexpenses = null;
			foreach (var animal in animals)
			{
				if(mostexpenses == null)
				{
					mostexpenses = animal;
				}
				if(CostByKgAnimal(mostexpenses) < CostByKgAnimal(animal))
				{
					mostexpenses = animal;
				}
			}
			return mostexpenses;

		}
		public int CostByKgAnimal(Animals.Animal animal)
		{
			int sum = 0;
			foreach (var food in animal.foods)
			{
				sum += food.Cost();
			}
			return sum;
		}
		public int TotalExpenses()
		{
			int sum = 0;
			foreach (var animal in animals) 
			{
				sum += CostByKgAnimal(animal);
			}
			return sum;
		}
	}
}
