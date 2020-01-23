using System;
using System.Collections.Generic;

namespace BoxesProject
{
	class Program
	{
		static void Main(string[] args)
		{
            var boxes = new List<Boxes>();
            Console.WriteLine("How many box do you have(number):");
            var count = int.Parse(Console.ReadLine());
            for (int i = 1; i <= count; i++)
            {
                Console.WriteLine($"Enter {i} lenght:");
                var lenght = double.Parse(Console.ReadLine());
                Console.WriteLine($"Enter {i} width:");
                var width = double.Parse(Console.ReadLine());
                Console.WriteLine($"Enter {i} height:");
                var height = double.Parse(Console.ReadLine());

                Box newbox = new Box();
                newbox.AddBox(lenght, width, height);

                var box = new Boxes(newbox);

                boxes.Add(box);
            }
            Boxes newboxes1 = boxes[0];
            foreach (var item in boxes)
            {
                if (newboxes1.volumen.Volume < item.volumen.Volume)
                {
                    newboxes1 = item;
                }
                Console.WriteLine(item.Print());

            }
            Console.WriteLine(newboxes1.Biggest());
        }
	}
}
