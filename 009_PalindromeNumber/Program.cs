using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _009_PalindromeNumber
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int input = 1211;
            Console.WriteLine((new Solution()).IsPalindrome(input));
            Console.ReadLine();
        }

        public class Solution
        {
            public bool IsPalindrome(int x)
            {
                if (x < 0) return false;
                int result = 0;
                int input = x;

                while (x > 0)
                {
                    if (result != 0) result *= 10;
                    result += x % 10;
                    x /= 10;
                }

                return result == input;
            }
        }
    }
}
