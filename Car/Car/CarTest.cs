

using System;

namespace Car
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
			Console.WriteLine (car1.GetInfo ());

			car1.Accelerate (125);
			car1.Go (100);
			car1.Go (50);
			Console.WriteLine (car1.GetInfo ());

			Console.WriteLine ();

			Car car2 = new Car ();
			car2.Make = "BMW";
			car2.Model = "i8";
			car2.Year = "2016";
			car2.Distance = 10000;
			car2.Speed = 0;
			Console.WriteLine (car2.GetInfo ());

			car2.Accelerate (220);
			car2.Go (150);
			Console.WriteLine (car2.GetInfo ());

			Console.WriteLine ();

			//car1.Speed = Util.topSpeed;
			//Util.washCar (car1);

		}
	}
}