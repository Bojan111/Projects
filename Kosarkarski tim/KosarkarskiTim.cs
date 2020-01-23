using System;
using System.Collections.Generic;
using System.Text;

namespace Kosarkarski_tim
{
	abstract class KosarkarskiTim
	{
		public int Balance;
		public int PoleOdKosevi { get; private set; }
	
		public void AddPoleOdKosevi(int pole)
		{
			PoleOdKosevi = pole;
		}
		public virtual string NameOfClub()
		{
			return "";
		}
		public virtual int Titula()
		{
			return 0;
		}
		public virtual string Country()
		{
			return "";
		}
		public virtual int Megjunarodninastapi()
		{
			return 0;
		}
		public abstract int ZbirNaKosevi();

		public virtual int BrojNaTituli()
		{
			return Balance;
		}
		public virtual int MegjunarodniNastani()
		{
			return Balance;
		}
	}
}
