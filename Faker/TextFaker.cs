using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Faker
{
	public static class TextFaker
	{
		public static string Sentence()
		{
			return Sentences(1);
		}

		public static string Sentences(int numSentences)
		{
			return String.Join(". ", ArrayFaker.SelectFrom(numSentences,
					"Lorem ipsum dolor sit amet  consectetur adipisicing elit sed do eiusmod tempor incididunt ut labore et dolore magna aliqua",
					"Ut enim ad minim veniam quis nostrud exercitation ullamco laboris nisi ut aliquip ex ea commodo consequat",
					"Duis aute irure dolor in reprehenderit in voluptate velit esse cillum dolore eu fugiat nulla pariatur",
					"Excepteur sint occaecat cupidatat non proident sunt in culpa qui officia deserunt mollit anim id est laborum"
				));
		}
	}
}