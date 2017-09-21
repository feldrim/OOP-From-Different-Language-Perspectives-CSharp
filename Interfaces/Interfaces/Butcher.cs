using System;

namespace Interfaces
{
	public class Butcher : ICutter
	{
		public void cut ()
		{
			Console.WriteLine ("I've just started cutting the meat!");
		}
	}
}

