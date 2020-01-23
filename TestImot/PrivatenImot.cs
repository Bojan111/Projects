using System;
using System.Collections.Generic;
using System.Text;

namespace TestImot
{
	class PrivatenImot : Imot
	{
		public string Name { get; set; }
		public double CenaPoKvadratenMetar;
		public double ProcentNaDanok;
		public PrivatenImot(int m2,string location,double cenapometar,double percent) : base(m2, location)
		{
			CenaPoKvadratenMetar = cenapometar;
			ProcentNaDanok = percent;
		}
		public override double CalculateDanok()
		{
			return M2 * CenaPoKvadratenMetar * ProcentNaDanok / 100.0 ;
		}
		public override string Type()
		{
			return string.IsNullOrEmpty(Name) ? $"Ova e privaten imot so {CenaPoKvadratenMetar} i povrsina {M2}" : $"Ova e privaten imot na {Name} so cena {CenaPoKvadratenMetar} i povrsina {M2}."; ;
		}
	}
}
