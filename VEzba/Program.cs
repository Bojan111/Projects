using System;
using System.Collections.Generic;

namespace OldestPerson
{
	class Program
	{
		static void Main(string[] args)
		{
			Console.Write("Enter People(number): ");
			var people = new List<Person>();
			var count = int.Parse(Console.ReadLine());
			for (int i = 0; i < count; i++)
			{
				Console.WriteLine($"Enter {i + 1} number of person:");
				Console.Write("Enter FirstName: ");
				var name = Console.ReadLine();
				Console.Write("Enter LastName: ");
				var lastname = Console.ReadLine();
				Console.Write("Enter Age: ");
				var age = int.Parse(Console.ReadLine());

				var person = new Person();
				person.AddName(name, lastname);
				person.AddAge(age);

				Console.Write("Enter City: ");
				var city = Console.ReadLine();
				Console.Write("Enter Street: ");
				var streeet = Console.ReadLine();
				Console.Write("Enter Number: ");
				var number = int.Parse(Console.ReadLine());
				var addres = new Addreses(city, streeet, number);
				person.SetAddress(addres);
				people.Add(person);
			}
			Person persons = people[0];
			foreach (var item in people)
			{
				if(persons.Age < item.Age)
				{
					persons = item;
				}
				var info = item.Print();
				Console.WriteLine(info);
			}
			Console.WriteLine(persons.GetName());
		}
	}
}
