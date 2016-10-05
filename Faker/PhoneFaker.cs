using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Faker
{
    static public class PhoneFaker
    {
        public static string Phone()
        {
            return StringFaker.Randomize("###-###-#####");
        }

        public static string Phone(string pattern)
        {
            return StringFaker.Randomize(pattern);
        }

        public static string InternationalPhone()
        {
            return StringFaker.Randomize("+##-(0)####-####-####");
        }
    }
}
