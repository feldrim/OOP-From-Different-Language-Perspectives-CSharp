using System;

namespace Interfaces
{
	public class Barber : ICutter
	{
		public void cut ()
		{
			Console.WriteLine ("I'm gonna cut your hair very stylish!");
		}
	}
}

