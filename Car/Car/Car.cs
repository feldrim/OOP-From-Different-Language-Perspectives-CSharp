using System;

namespace Car
{
	public class Car
	{
        public string Make { get; set; }

	    public string Model { get; set; }

	    public string Year { get; set; }

	    public int Speed { get; set; }

	    public int Distance { get; set; }

        public void Go (int newDistance)
		{
			Distance += newDistance;
		}

		public void Accelerate (int newSpeed)
		{
			Speed = newSpeed;
		}

		public void Stop ()
		{
			Speed = 0;
		}

		public override string ToString ()
		{
			return $"Car Info: {Year} {Make} {Model}. Distance: {Distance} km. and traveling at {Speed} kmph.";
		}


	}
}