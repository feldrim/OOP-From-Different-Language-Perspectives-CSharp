using System;

namespace car
{
	public class Car
	{
	    private string _make;
	    private string _model;
	    private string _year;
	    private int _speed;
	    private int _distance;

		public void go (int newDistance)
		{
			_distance += newDistance;
		}

		public void accelerate (int newSpeed)
		{
			_speed = newSpeed;
		}

		public void stop ()
		{
			_speed = 0;
		}

		public string getInfo ()
		{
			return "Car Info: " + _year + " " + _make + " " + _model + ". Distance: " + _distance + " km. and traveling at " + _speed + " kmph.";
		}

		public string Make {
			get { return _make; }
			set { _make = value; }
		}

		public string Model {
			get { return _model; }
			set { _model = value; }
		}

		public string Year {
			get { return _year; }
			set { _year = value; }
		}

		public int Speed {
			get { return _speed; }
			set { _speed = value; }
		}

		public int Distance {
			get { return _distance; }
			set { _distance = value; }
		}

	}
}