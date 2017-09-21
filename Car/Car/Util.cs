using System;

namespace car
{
	public class Util
	{
		public const int topSpeed = 200;

		public static void washCar (Car car)
		{
			Console.WriteLine ("Washing car: " + car.Make + " " + car.Model + " of " + car.Year);
		}
	}
}

