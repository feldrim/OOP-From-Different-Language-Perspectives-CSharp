using System;

namespace Car
{
    public class CarTest
    {
        public static void Main(string[] args)
        {
            var car1 = new Car
            {
                Make = "Mercedes",
                Model = "C200",
                Year = "2017",
                Distance = 0,
                Speed = 0
            };
            Console.WriteLine(car1.ToString());

            car1.Accelerate(125);
            car1.Go(100);
            car1.Go(50);
            Console.WriteLine(car1.ToString());

            Console.WriteLine();

            var car2 = new Car
            {
                Make = "BMW",
                Model = "i8",
                Year = "2016",
                Distance = 10000,
                Speed = 0
            };
            Console.WriteLine(car2.ToString());

            car2.Accelerate(220);
            car2.Go(150);
            Console.WriteLine(car2.ToString());

            Console.WriteLine();

            //car1.Speed = Util.topSpeed;
            //Util.washCar (car1);
        }
    }
}