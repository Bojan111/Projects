using System;
using System.Collections.Generic;
using System.Text;

namespace Kosarkarski_tim
{
	class Reprezentacija : KosarkarskiTim
	{

		public override string Country()
		{
			return "Makedonija";
		}
		public override int Megjunarodninastapi()
		{
			return 15;
		}
		public override int ZbirNaKosevi()
		{
			return Balance * 2;
		}
		public override int MegjunarodniNastani()
		{
			return Balance * 4;
		}
	}
}
