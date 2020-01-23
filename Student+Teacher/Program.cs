using System;
using System.Collections.Generic;

namespace Student_Teacher
{
	class Program
	{
		static void Main(string[] args)
		{
			
			var people = new List<Person>();
			Console.WriteLine("Enter Student name");
			var name = Console.ReadLine();
			var person = new Student(name);
			Console.WriteLine($"Jas {person.GoToClasses()},\n{person.ShowAge()}");
			Console.WriteLine("Enter Teacher Name");
			var teacher = Console.ReadLine();
			var teachername = new Teacher(teacher);
			Console.WriteLine($"{teachername.Explain()}...\nJa sum profesor, i imam {teachername.SetAge()} godini");

			Console.WriteLine("New Student ");
			var name2 = Console.ReadLine();
			var student = new Student(name2);
			Console.WriteLine($"{student.Greeting()}");

			Console.WriteLine("New Teacher ");
			var name3 = Console.ReadLine();
			var teachers = new Teacher(name3);
			Console.WriteLine($"{teachers.Info()}");
			people.Add(person);
			people.Add(teachername);
			
		}
	}
}
