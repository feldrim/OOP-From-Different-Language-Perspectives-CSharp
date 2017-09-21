using System;

namespace Car
{
    public class CarWasher
    {
        public void WashCar(Car car)
        {
            Console.WriteLine($"Washing car: {car.Make} {car.Model} of {car.Year}");
        }
    }
}