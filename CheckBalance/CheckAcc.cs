using System;
using System.Collections.Generic;
using System.Text;

namespace CheckBalance
{
	class CheckAcc
	{
		private int balance;
		public string authorName;
		public WithDrawal personAccount;

		public CheckAcc(string authorname)
		{
			authorName = authorname;
			balance = 100;
		}
		public void Withdraw(int money)
		{
			balance -= money;
			if(balance < 0)
			{
				if(personAccount != null)
				{
					personAccount(authorName);
				}
			}
		}
	}
}
