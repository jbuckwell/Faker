using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Faker
{
	public static class NumberFaker
	{
		private static Random _random = new Random();

		public static int Number()
		{
			return _random.Next();
		}

		public static int Number(int maxValue)
		{
			return _random.Next(maxValue);
		}

		public static int Number(int minValue, int maxValue)
		{
			return _random.Next(minValue, maxValue);
		}
	}
}
