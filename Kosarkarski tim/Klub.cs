using System;
using System.Collections.Generic;
using System.Text;

namespace Kosarkarski_tim
{
	class Klub : KosarkarskiTim
	{
		public override string NameOfClub()
		{
			return "MZT";
		}
		public override int Titula()
		{
			return 15;
		}
		public override int ZbirNaKosevi()
		{
			return Balance * 2;
		}
		public override int BrojNaTituli()
		{
			return Balance * 5;
		}
	}
}
