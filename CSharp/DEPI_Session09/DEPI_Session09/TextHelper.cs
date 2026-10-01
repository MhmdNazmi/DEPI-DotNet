using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;

namespace DEPI_Session09
{
    internal static class TextHelper
    {
        public static bool IsShorterThan(this string value, int length)
            => value.Length < length;

        public static string Repeat(this string value, int times)
        {
            string result = "";
            for (int i = 0; i < times; i++)
            {
                result += value;
            }
            return result;
        }
    }
}
