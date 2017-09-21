using System;

namespace car
{
	public class Car
	{
        public string Make { get; set; }

	    public string Model { get; set; }

	    public string Year { get; set; }

	    public int Speed { get; set; }

	    public int Distance { get; set; }

        public void go (int newDistance)
		{
			Distance += newDistance;
		}

		public void accelerate (int newSpeed)
		{
			Speed = newSpeed;
		}

		public void stop ()
		{
			Speed = 0;
		}

		public string getInfo ()
		{
			return "Car Info: " + Year + " " + Make + " " + Model + ". Distance: " + Distance + " km. and traveling at " + Speed + " kmph.";
		}


	}
}