using System;
using System.Collections.Generic;
using System.Text;

namespace CheckBalance
{
	public delegate void WithDrawal(string authorName);
	public delegate void OnWithDrawal(List<string> authorName);
}
