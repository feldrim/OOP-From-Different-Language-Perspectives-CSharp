

using System;

namespace car
{

	public class CarTest
	{

		public static void Main (string [] args)
		{

			Car car1 = new Car ();
			car1.Make = "Mercedes";
			car1.Model = "C200";
			car1.Year = "2017";
			car1.Distance = 0;
			car1.Speed = 0;
			Console.WriteLine (car1.getInfo ());

			car1.accelerate (125);
			car1.go (100);
			car1.go (50);
			Console.WriteLine (car1.getInfo ());

			Console.WriteLine ();

			Car car2 = new Car ();
			car2.Make = "BMW";
			car2.Model = "i8";
			car2.Year = "2016";
			car2.Distance = 10000;
			car2.Speed = 0;
			Console.WriteLine (car2.getInfo ());

			car2.accelerate (220);
			car2.go (150);
			Console.WriteLine (car2.getInfo ());

			Console.WriteLine ();

			//car1.Speed = Util.topSpeed;
			//Util.washCar (car1);

		}
	}
}