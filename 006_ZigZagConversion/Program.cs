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
            if (numRows == 0) return "";
            int sLen = s.Length;
            char[] charS = s.ToCharArray();
            char[] charset = new char[sLen];

            for (int i = 0; i < sLen; i++)
            {
                charset[Procss(i, numRows)] = charS[i];
            }

            return (new string(charset));
        }
        public int Procss(int InputIndex, int numRows)
        {
            int returnvalue = 0;



            return returnvalue;
        }
    }
}
//A G  M
//B FH LN
//CE IK O
//D  J P
//index / (RowNum* 2 - 2)