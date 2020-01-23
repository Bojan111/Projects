using System;
using System.Collections.Generic;
using System.Text;

namespace ZooAnimalsProject
{
	delegate void WrongFoodProvided(object sender, FoodEventArgs eventArgs);
	 class FoodEventArgs : EventArgs
	{
		public Foods.Food Food { get; set; }
	}
	
}
