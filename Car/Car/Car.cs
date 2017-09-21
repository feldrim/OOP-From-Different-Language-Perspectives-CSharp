using System;

namespace car
{
	public class Car
	{
		string make;
		string model;
		string year;
		int speed;
		int distance;

		public void go (int newDistance)
		{
			distance += newDistance;
		}

		public void accelerate (int newSpeed)
		{
			speed = newSpeed;
		}

		public void stop ()
		{
			speed = 0;
		}

		public string getInfo ()
		{
			return "Car Info: " + year + " " + make + " " + model + ". Distance: " + distance + " km. and traveling at " + speed + " kmph.";
		}

		public string Make {
			get { return make; }
			set { make = value; }
		}

		public string Model {
			get { return model; }
			set { model = value; }
		}

		public string Year {
			get { return year; }
			set { year = value; }
		}

		public int Speed {
			get { return speed; }
			set { speed = value; }
		}

		public int Distance {
			get { return distance; }
			set { distance = value; }
		}

	}
}