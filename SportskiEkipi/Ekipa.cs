using System;
using System.Collections.Generic;
using System.Text;

namespace SportskiEkipi
{
	abstract class Ekipa
	{
		private string imenaekipa;
		public string ImeNaEkipa
		{
			get
			{
				return imenaekipa;
			}
			private set
			{
				if (value.Length <= 15)
				{
					imenaekipa = value;
				}
			}
		}
		public int BrojNaPorazi { get; set; }
		public int BrojNaPobedi { get; set; }
		public Ekipa(string ime,int porazi,int pobedi)
		{
			ImeNaEkipa = ime;
			BrojNaPorazi = porazi;
			BrojNaPobedi = pobedi;
		}

		public abstract string Print();
		

	}
}
