﻿using System;
namespace Interfaces
{
	public class CutterTest
	{
		public static void Main (string [] args)
		{
			for (int i = 0; i < 5; i++) {
				Cutter cutter = CutterFactory.createCutter ();
				cutter.cut ();
			}
		}
	}
}

