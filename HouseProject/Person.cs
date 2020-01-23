using System;
using System.Collections.Generic;
using System.Text;

namespace HouseProject
{
	class Person
	{
		public string Name { get; set; }
		public Door doors;
		public House house;
		public Person(string name)
		{
			Name = name;
		}
		//public string GetName()
		//{
		//	return Name;
		//}
		public string GetInfoOfPerson()
		{
			return $"Name: {Name}\n Information for his house: {house.ShowData()}\n and doors: {doors.GetDoor()}";
		}
	}
}
