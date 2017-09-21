using System;
namespace Interfaces
{
	public class CutterFactory
	{
		private static Random random = new Random ();

		public static ICutter CreateCutter ()
		{
			ICutter cutter = null;

			var i = (int)(3 * random.NextDouble ());

			switch (i) {
			case 0:
				cutter = new Actor ();
				break;
			case 1:
				cutter = new Barber ();
				break;
			case 2:
				cutter = new Butcher ();
				break;
			}
			return cutter;

		}
	}
}

