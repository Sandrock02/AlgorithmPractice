using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgorithmPractice.ResumeQuestions
{
    public static class Q507ConvertStringToInt
    {
        public static int ConvertString(string str, IFormatProvider formatProvider = null)
        {
            if (string.IsNullOrWhiteSpace(str))
            {
                throw new ArgumentNullException(nameof(str));
            }

            var formatInfo = NumberFormatInfo.GetInstance(formatProvider ?? CultureInfo.CurrentCulture);

            int cur = 0;
            int sign = 1;
            int num = 0;
            int c = 0;
            while (cur < str.Length)
            {
                char ch = str[cur];

                if (IsMatching(str, ref cur, formatInfo.PositiveSign)) sign = 1;
                else if (IsMatching(str, ref cur, formatInfo.NegativeSign)) sign = -1;
                else if (IsMatching(str, ref cur, formatInfo.NumberDecimalSeparator)) break;
                else if (IsMatching(str, ref cur, formatInfo.NumberGroupSeparator)) { }
                else if (IsDigital(ch))
                {
                    c = ch - '0';

                    if (sign > 0 && num >= int.MaxValue / 10 && c > int.MaxValue % 10)
                    {
                        throw new Exception("The input number is greater than 2147483647.");
                    }

                    if (sign < 0 && num >= (int.MaxValue / 10) && c > (int.MaxValue - 9) % 10)
                    {
                        throw new Exception("The input number is smaller than -2147483648.");
                    }

                    num = num * 10 + c;
                }
                else
                {
                    throw new Exception($"There is unsupported character in {nameof(str)}.");
                }

                cur++;
            }

            return num * sign;
        }

        private static bool IsDigital(char c)
        {
            return c >= '0' && c <= '9';
        }

        private static bool IsMatching(string str, ref int startIndex, string pattern)
        {
            if (string.IsNullOrEmpty(str) && string.IsNullOrEmpty(pattern)) return true;
            if (string.IsNullOrEmpty(str)) return false;
            if (string.IsNullOrEmpty(pattern)) return true;

            var result = str.Substring(startIndex).StartsWith(pattern);
            if (result) startIndex += pattern.Length - 1;
            return result;
        }
    }
}
