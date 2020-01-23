using System;
using System.Collections.Generic;

namespace CheckBalance
{
	class Program
	{
		static void Main(string[] args)
		{
			var accounts = new List<CheckAcc>();
			var ujp = new DebtCollector();
			ujp.personHolder = OnDebtCollector;
			while (true)
			{
				Console.WriteLine("Enter account by name and exit 'q'");
				var counts = Console.ReadLine();
				if(counts == "q")
				{
				
					break;
				}
				var account = new CheckAcc(counts);
				account.personAccount = ujp.Debtcollector;
				accounts.Add(account);
			}
			foreach (var account in accounts)
			{
				Console.WriteLine($"Withdrowal money from {account.authorName} account");
				while (true)
				{
					Console.WriteLine("Amount and exit 'q'");
					var money = Console.ReadLine();
					if (money == "q")
					{
					
						break;
					}
					account.Withdraw(int.Parse(money));
				}
						
			}

		}
		static void OnDebtCollector(List<string> accountPersons)
		{
			Console.WriteLine($"in debth are {accountPersons.Count} persons");
			foreach (var item in accountPersons)
			{
				Console.WriteLine($"In debth - {item}");
			}
		}
	}

}
