using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _007_ReverseInteger
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int Reverse = 12345;
            Console.WriteLine((new Solution()).Reverse(Reverse));
            Console.ReadLine();
        }
        public class Solution
        {
            public int Reverse(int x)
            {
                if (x == int.MinValue || x == int.MaxValue) return 0;
                if (x > 1000000000 && x % 10 > 2) return 0;

                int sign = x >= 0 ? 1 : -1;
                x = x * sign;
                int result = 0;

                while (x > 0)
                {
                    if (result > 0) {
                        if (result * 10 / 10 != result) return 0;
                        result *= 10; 
                    }
                    int currentLastDigit = x % 10;
                    x /= 10;
                    result += currentLastDigit;
                    if (result < 0) return 0;
                }

                return result * sign;
            }
        }
    }
}
