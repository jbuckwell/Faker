using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Faker
{
	public static class ArrayFaker
	{	
		public static T SelectFrom<T>(params T[] array)
		{
			var index = NumberFaker.Number(0, array.Length);
			return (T)array.GetValue(index);
		}

		public static T[] SelectFrom<T>(int numElements, params T[] array)
		{
			var returned = new T[numElements];
			while (numElements > 0)
			{
				returned[numElements - 1] = SelectFrom(array);
				numElements--;
			}

			return returned;
		}
	}
}
