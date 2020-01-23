using System;
using System.Collections.Generic;
using System.Text;

namespace ZooAnimalsProject.Foods
{
	class Meet : Food
	{
		public Meet(int quantity) : base(quantity)
		{

		}
		public override int Cost()
		{
			return Quantity * 5;
		}
		public override string Type()
		{
			return "Meet";
		}
	}
}
