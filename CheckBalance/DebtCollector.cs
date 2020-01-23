using System;
using System.Collections.Generic;
using System.Text;

namespace CheckBalance
{
	class DebtCollector
	{
		public List<string> checkACcount;
		public OnWithDrawal personHolder;

		public DebtCollector()
		{
			checkACcount = new List<string>();
		}
		public void Debtcollector(string accountholder)
		{
			if (!checkACcount.Contains(accountholder))
			{
				checkACcount.Add(accountholder);
				if(personHolder != null)
				{
					personHolder(checkACcount);
				}
			}
		}
	}
}
