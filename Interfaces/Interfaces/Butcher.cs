using System;

namespace Interfaces
{
    public class Butcher : ICutter
    {
        public void Cut()
        {
            Console.WriteLine("I've just started cutting the meat!");
        }
    }
}