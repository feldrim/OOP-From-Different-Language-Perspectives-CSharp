using System;

namespace Interfaces
{
	public class Actor : ICutter
	{
		public void cut ()
		{
			Console.WriteLine ("I've just stop acting!");
		}
	}
}

