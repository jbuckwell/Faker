using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Faker
{
	public static class BooleanFaker
	{
		public static bool Boolean()
		{
			return NumberFaker.Number(2) == 1;
		}
	}
}
