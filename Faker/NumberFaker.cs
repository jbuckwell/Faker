using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;

namespace Faker
{
    public static class NumberFaker
    {
        private static readonly RNGCryptoServiceProvider Global = new RNGCryptoServiceProvider();

        [ThreadStatic]
        private static Random _local;

        private static Random Local
        {
            get
            {
                Random inst = _local;
                if (inst == null)
                {
                    byte[] buffer = new byte[4];
                    Global.GetBytes(buffer);
                    _local = inst = new Random(
                        BitConverter.ToInt32(buffer, 0));
                }

                return inst;
            }
        }

        public static int Number()
        {
            return Local.Next();
        }

        public static int Number(int maxValue)
        {
            return Local.Next(maxValue);
        }

        public static int Number(int minValue, int maxValue)
        {
            return Local.Next(minValue, maxValue);
        }
    }
}