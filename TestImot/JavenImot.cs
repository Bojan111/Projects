using System;
using System.Collections.Generic;
using System.Text;

namespace Imot
{
	class JavenImot : Imot
	{
		public int GodinaNaIzgradba;
		public JavenImot(int m2,string location,int godina) : base(m2, location)
		{
			GodinaNaIzgradba = godina;
		}
		public override double CalculateDanok()
		{
			return GodinaNaIzgradba < 2000 ? M2 * 10 : M2 * 20;
		}
		public override string Type()
		{
			return $"Ovoj imot e Javen od {GodinaNaIzgradba} god";
		}
	}
}
