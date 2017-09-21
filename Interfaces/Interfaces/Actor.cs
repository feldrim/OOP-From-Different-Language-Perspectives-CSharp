using System;

namespace Interfaces
{
    public class Actor : ICutter
    {
        public void Cut()
        {
            Console.WriteLine("I've just stop acting!");
        }
    }
}