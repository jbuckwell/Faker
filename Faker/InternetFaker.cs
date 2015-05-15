using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Faker
{
	public static class InternetFaker
	{
		public static string Domain()
		{
			return ArrayFaker.SelectFrom("yahoo.com", "gmail.com", "privacy.net", "webmail.com", "msn.com", "hotmail.com", "example.com");
		}

		public static string Email()
		{
			if (NumberFaker.Number(5) == 2)
			{
				return NameFaker.FirstName().ToLower() + StringFaker.Numeric(2) + "@" + Domain();
			}
			else
			{
				return NameFaker.FirstName().ToLower() + "@" + Domain();
			}
		}

		public static string Url()
		{
			return "http://www." + Domain();
		}
	}
}
