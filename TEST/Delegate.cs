using System;
using System.Collections.Generic;
using System.Text;

namespace TEST
{
	delegate void WrongFoodProvided(object sender, FoodEventArgs eventArgs );

	class FoodEventArgs : EventArgs
	{
		public Food Food { get; set; }
	}
}
