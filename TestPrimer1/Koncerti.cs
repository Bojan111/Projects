using System;
using System.Collections.Generic;
using System.Text;

namespace KONCERT
{
	class Koncerti
	{
		private string naziv
		{
			get
			{
				return naziv;
			}
			set
			{
				if (value.Length <= 20)
				{
					value = naziv;
				}
			}
		}
		
		private string lokacija
		{
			get
			{
				return lokacija;
			}
			set
			{
				if (value.Length <= 20)
				{
					value = lokacija;
				}
			}
		}
		
		private double sezonskiPopust { get; set; }
		private double cenaNaBilet { get; set; }
		public Koncerti (string _naziv,string _lokacija,double cenabilet)
		{
			naziv = _naziv;
			lokacija = _lokacija;
			sezonskiPopust = 20 / 100.0;
			cenaNaBilet = cenabilet;
		}
		public double Cena()
		{
			return cenaNaBilet * (1 - sezonskiPopust);
		}
		public string Naziv()
		{
			return naziv;
		}
	}
}
