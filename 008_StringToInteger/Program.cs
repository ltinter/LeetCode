using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _008_StringToInteger
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string input = "42";
            Console.WriteLine((new Solution()).MyAtoi(input));
            Console.ReadLine();
        }

        public class Solution
        {
            public int MyAtoi(string s)
            {
                s=s.TrimStart();
                if (s == "") return 0;
                char[] chars = s.TrimStart().ToCharArray();
                int result = 0;
                int sign = chars[0] == '-' ? -1 : 1;

                for (int i = (chars[0] == '-' || chars[0] == '+' ? 1 : 0); i < chars.Length; i++)
                {
                    int currentInt = (int)char.GetNumericValue(chars[i]);
                    if (currentInt >= (int)char.GetNumericValue('0') && currentInt <= (int)char.GetNumericValue('9'))
                    {
                        if (result != 0)
                        {
                            int tempInt = result;
                            result *= 10;
                            if (result / 10 != tempInt) return sign == 1 ? int.MaxValue : int.MinValue;
                        }
                        result += currentInt;
                        if (result < 0)
                        {
                            return sign == 1 ? int.MaxValue : int.MinValue;
                        }
                    }
                    else
                    {
                        break;
                    }
                }

                return result * sign;
            }
        }
    }
}
