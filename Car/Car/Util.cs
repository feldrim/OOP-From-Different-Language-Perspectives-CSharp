using System;

namespace Car
{
    public class Util
    {
        public const int TopSpeed = 200;

        public static void WashCar(Car car)
        {
            Console.WriteLine($"Washing car: {car.Make} {car.Model} of {car.Year}");
        }
    }
}