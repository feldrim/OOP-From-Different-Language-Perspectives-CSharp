using System;

namespace Interfaces
{
    public class Barber : ICutter
    {
        public void Cut()
        {
            Console.WriteLine("I'm gonna cut your hair very stylish!");
        }
    }
}