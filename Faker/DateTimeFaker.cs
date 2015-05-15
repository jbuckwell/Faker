using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Faker
{
	public static class DateTimeFaker
	{
		public static DateTime DateTime(DateTime from, DateTime to)
		{
			var timeSpan = to - from;
			return from.AddDays((double) NumberFaker.Number(1, (int)timeSpan.TotalDays - 1)).AddSeconds(NumberFaker.Number(1, 86400));
		}

		public static DateTime DateTime()
		{
			return DateTimeBetweenDays(5);
		}

		public static DateTime DateTimeBetweenDays(double fromDays, double toDays)
		{
			return DateTime(System.DateTime.Now.AddDays(-1 * fromDays), System.DateTime.Now.AddDays(toDays)); 
		}

		public static DateTime DateTimeBetweenDays(double days)
		{
			return DateTime(System.DateTime.Now.AddDays(-1 * days), System.DateTime.Now.AddDays(days));
		}

		public static DateTime DateTimeBetweenMonths(int fromMonths, int toMonths)
		{
			return DateTime(System.DateTime.Now.AddMonths(-1 * fromMonths), System.DateTime.Now.AddMonths(toMonths));
		}

		public static DateTime DateTimeBetweenMonths(int months)
		{
			return DateTime(System.DateTime.Now.AddMonths(-1 * months), System.DateTime.Now.AddMonths(months));
		}

		public static DateTime DateTimeBetweenYears(int fromYears, int toYears)
		{
			return DateTime(System.DateTime.Now.AddYears(-1 * fromYears), System.DateTime.Now.AddYears(toYears));
		}

		public static DateTime DateTimeBetweenYears(int years)
		{
			return DateTime(System.DateTime.Now.AddYears(-1 * years), System.DateTime.Now.AddDays(years));
		}

		public static DateTime BirthDay(int minAge, int maxAge)
		{
			return DateTimeBetweenYears(maxAge, minAge);
		}

		public static DateTime BirthDay(int minAge)
		{
			return DateTimeBetweenYears(100, minAge);
		}

		public static DateTime BirthDay()
		{
			return BirthDay(18);
		}
	}
}
