using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _006_ZigZagConversion
{
    class Program
    {
        static void Main(string[] args)
        {
            string test = "PAYPALISHIRING";
            int rowsnum = 3;
            Console.WriteLine((new Solution()).Convert(test, rowsnum));
            Console.ReadLine();
        }
    }
    public class Solution
    {
        public string Convert(string s, int numRows)
        {
            string returnvalue = "";
            int sLen = s.Length;
            char[] charS = s.ToCharArray();
            char[][] charset = new char[numRows][];
            charset = new char[sLen / numRows + 1];
            int ptrS = 0, CurColom = 0;

            while (true)
            {
                for (int i = 0; i < numRows; i++)
                {
                    charset[CurColom, i] = charS[ptrS];
                    ptrS++;
                    if (ptrS >= sLen) return PostProcss(charset, numRows);
                }
                CurColom++;

            }

            return returnvalue;
        }
        public string PostProcss(char[,] charset, int numRows)
        {
            StringBuilder sb = new StringBuilder();
            for (int i = 0; i < numRows; i++)
            {
                sb.Append(new String(charset[i,]));
            }

            return returnvalue;
        }
    }
}
