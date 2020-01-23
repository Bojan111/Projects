using System;
using System.Collections.Generic;
using System.Text;

namespace Kosarkarski_tim
{
	class Visit
	{
		public List<KosarkarskiTim> tim;
		public Visit()
		{
			tim = new List<KosarkarskiTim>();
		}
		public void AddTeams(KosarkarskiTim addtim)
		{
			tim.Add(addtim);
		}
		public int Total()
		{
			var sum = 0;
			foreach (var item in tim)
			{
				sum += item.ZbirNaKosevi();
			}
			return sum;
		}
 	}
}
