using System;
using System.Collections.Generic;
using System.Text;

namespace SportskiEkipi
{
	class FudbalskaEkipa : Ekipa
	{
		public int VkupenoCrveniKartoni { get; set; }
		public int VkupnoZoltiKartoni { get; set; }
		public int BrojNaNereseniNatprevari { get; set; }

		public FudbalskaEkipa(string name,int pobedi,int porazi,int crven,int zolt,int nereseno) : base(name, porazi, pobedi)
		{
			VkupenoCrveniKartoni = crven;
			VkupnoZoltiKartoni = zolt;
			BrojNaNereseniNatprevari = nereseno;
		}
		public int Poeni()
		{
			return BrojNaPobedi * BrojNaPorazi;
		}
		public override string Print()
		{
			string result;
			result = $"Nereseni Rezultati {BrojNaNereseniNatprevari}, Ime na ekipa: {ImeNaEkipa}, Broj na pobedi {BrojNaPobedi}, Broj na porazi {BrojNaPorazi}, vkupen broj poeni {Poeni()}";
			return result;
		}
	}
}
