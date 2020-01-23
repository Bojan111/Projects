using System;

namespace ConsoleApp1
{
	class Program
	{
		static void Main(string[] args)
		{
			Console.WriteLine("Can you make a word");
			Console.WriteLine("string for making a word");
			var karakteri = "butl";
			var zbor = "beautiful";


			Console.WriteLine(CanComplete(karakteri,zbor));
		}
		static bool CanComplete(string karakteri,string zbor)
		{
			int temp = 0;
			bool bukvanajdena = false;
			for (int i = 0; i < karakteri.Length; i++)
			{
				bukvanajdena = false;
				for (int j = temp; j < zbor.Length; j++)
				{
					if(karakteri[i] == zbor[j])
					{
						temp = j + 1;
						bukvanajdena = true;
						break;
					}
				}
				if(bukvanajdena == false)
				{
					break;
				}
			}
			return bukvanajdena;
			
		}
	}
}
