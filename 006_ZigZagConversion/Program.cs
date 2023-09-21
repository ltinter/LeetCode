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
            string test = "ABC";
            int rowsnum = 2;
            Console.WriteLine((new Solution()).Convert(test, rowsnum));
            Console.ReadLine();
        }
    }
    public class Solution
    {
        public string Convert(string s, int numRows)
        {
            string returnValue = "";
            if (numRows == 1)
                return s;
            if (numRows == 2)
            {
                int index = 0;
                List<char> a = new List<char>();
                List<char> b = new List<char>();
                foreach (char c in s)
                {
                    if (index % 2 == 0)
                    {
                        a.Add(c);
                    }
                    else
                    {
                        b.Add(c);
                    }
                    index++;
                }
                return string.Join("", a) + string.Join("", b);
            }
            List<List<char>> result = new List<List<char>>();
            for (int i = 0; i < numRows; i++) result.Add(new List<char>());
            for (int i = 0; i < s.Length; i++)
            {
                int index = i % (numRows * 2 - 2);
                int resultIndex = 0;
                if (index < numRows)
                {
                    resultIndex = index;
                }
                else
                {
                    resultIndex = numRows - (index - numRows + 2);
                }
                result[resultIndex].Add(s[i]);
            }
            foreach (var temp in result)
            {
                returnValue += string.Join("", temp);
            }
            return returnValue;
        }
    }
}
//A G  M
//B FH LN
//CE IK O
//D  J P
//index / (RowNum* 2 - 2)