using System;
namespace Interfaces
{
	public class CutterTest
	{
		public static void Main (string [] args)
		{
			for (var i = 0; i < 5; i++) {
				var cutter = CutterFactory.CreateCutter ();
				cutter.Cut ();
			}
		}
	}
}

