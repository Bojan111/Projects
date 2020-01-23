using System;
using System.Collections.Generic;
using System.Text;

namespace Zoo
{
	delegate void WrongFoodProvided(object sender,FoodEventArgs eventArgs);
	class FoodEventArgs : EventArgs
	{
		public Food Food { get; set; }
	}
}
