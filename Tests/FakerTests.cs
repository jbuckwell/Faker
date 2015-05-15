using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using NUnit.Framework;
using System.Linq.Expressions;
using Faker;

namespace FakerTests
{
	[TestFixture]
	public class FakerTests
	{
		[Test]
		public void ArrayFakerTest()
		{
			DisplayAndExecute(new Expression<Func<string>>[] {
				() => ArrayFaker.SelectFrom("one", "two", "three"),
			});
		}

		[Test]
		public void BooleanFakerTest()
		{
			DisplayAndExecute(new Expression<Func<bool>>[] {
				() => BooleanFaker.Boolean()
			});
		}

		[Test]
		public void CompanyFakerTest()
		{
			DisplayAndExecute(new Expression<Func<string>>[] {
				() => CompanyFaker.Name(),
				() => CompanyFaker.BS(),
			});
		}

		[Test]
		public void DateTimeFakerTest()
		{
			DisplayAndExecute(new Expression<Func<DateTime>>[] {
				() => DateTimeFaker.DateTime(),
				() => DateTimeFaker.DateTime(DateTime.Parse("1980-5-13"), DateTime.Parse("2060-7-13")),
				() => DateTimeFaker.DateTimeBetweenDays(0, 30), 
				() => DateTimeFaker.DateTimeBetweenDays(20),
				() => DateTimeFaker.DateTimeBetweenMonths(6, 0), 
				() => DateTimeFaker.DateTimeBetweenMonths(9),
				() => DateTimeFaker.DateTimeBetweenYears(0, 1), 
				() => DateTimeFaker.DateTimeBetweenYears(5),
				() => DateTimeFaker.BirthDay(33),
				() => DateTimeFaker.BirthDay()
			});
		}

		public enum TestEnum
		{
			Christmas,
			Hanuka,
			Kwanza
		}

		[Test]
		public void EnumFakerTest()
		{
			DisplayAndExecute(new Expression<Func<TestEnum>>[] {
				() => EnumFaker.SelectFrom<TestEnum>()
			});
		}

		[Test]
		public void InternetFakerTest()
		{
			DisplayAndExecute(new Expression<Func<string>>[] {
				() => InternetFaker.Domain(),
				() => InternetFaker.Email(),
				() => InternetFaker.Url()
			});
		}

		[Test]
		public void LocationFakerTest()
		{
			DisplayAndExecute(new Expression<Func<string>>[] {
				() => LocationFaker.City(),
				() => LocationFaker.Country(),
				() => LocationFaker.PostCode(),
				() => LocationFaker.Street(),
				() => LocationFaker.StreetName(),
				() => LocationFaker.ZipCode(),
			});
			DisplayAndExecute(new Expression<Func<int>>[] {
				() => LocationFaker.StreetNumber(),
			});
		}

		[Test]
		public void NameFakerTest()
		{
			DisplayAndExecute(new Expression<Func<string>>[] {
				() => NameFaker.FemaleFirstName(),
				() => NameFaker.FemaleName(),
				() => NameFaker.FirstName(),
				() => NameFaker.LastName(),
				() => NameFaker.MaleFirstName(),
				() => NameFaker.MaleName(),
				() => NameFaker.Name(),
			});
		}

		[Test]
		public void NumberFakerTest()
		{
			DisplayAndExecute(new Expression<Func<int>>[] {
				() => NumberFaker.Number(),
				() => NumberFaker.Number(10),
				() => NumberFaker.Number(10,100),
			});
		}

		[Test]
		public void PhoneFakerTest()
		{
			DisplayAndExecute(new Expression<Func<string>>[] {
				() => PhoneFaker.Phone(),
				() => PhoneFaker.InternationalPhone(),
			});
		}
		
		[Test]
		public void StringFakerTest()
		{
			DisplayAndExecute(new Expression<Func<string>>[] {
				() => StringFaker.Alpha(5),
				() => StringFaker.AlphaNumeric(5),
				() => StringFaker.Numeric(5),
				() => StringFaker.Randomize("### ??"),
			});
		}

		[Test]
		public void TextFakerTest()
		{
			DisplayAndExecute(new Expression<Func<string>>[] {
				() => TextFaker.Sentence(),
				() => TextFaker.Sentences(4),
			});
		}

		protected void DisplayAndExecute<T>(params Expression<Func<T>>[] expressions)
		{
			foreach (var expression in expressions)
			{
				if (expression.Body is MethodCallExpression)
				{
					Console.WriteLine("{0}.{1} => '{2}'",
						(expression.Body as MethodCallExpression).Method.DeclaringType.Name,
						expression.Body.ToString(),
						expression.Compile().Invoke().ToString()
						);
				}
			}
		}
	}
}
