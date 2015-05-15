using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Faker
{
	public static class EnumFaker
	{
		public static EnumT SelectFrom<EnumT>()
		{
			var enumValues = System.Enum.GetValues(typeof(EnumT));
			return (EnumT)enumValues.GetValue(NumberFaker.Number(enumValues.Length));
		}		
	}
}
