using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _005_LongestPalindromicSubstring
{
    class Program
    {
        static void Main(string[] args)
        {
            string strTest = "acba";
            Console.WriteLine((new Solution()).LongestPalindrome(strTest));
            Console.ReadLine();
        }
    }
    public class Solution
    {
        public string LongestPalindrome(string s)
        {
            int sLen = s.Length;
            if (sLen <= 1) return s;
            char[] tempCharset = new char[sLen * 2 + 1];
            char[] orgStrCharset = s.ToCharArray();
            orgStrCharset[0] = 'x';
            tempCharset[0] = '#';
            for (int i = 0; i < sLen; i++)
            {
                tempCharset[i * 2 + 1] = orgStrCharset[i];
                tempCharset[i * 2 + 2] = '#';
            }
            //string returnvalue = "";
            //StringBuilder sb = new StringBuilder("#");
            //foreach (char tempChar in s)
            //{
            //    sb.Append(tempChar.ToString() + "#");
            //}
            string ss = new string(tempCharset);
            int strLen = ss.Length;
            int tempStrLen = 0;

            int MaxLen = 0, MaxLeft = 0, MaxPalinLen = 0;

            for (int i = 1; i < strLen; i++)
            {
                for (int j = 1; j <= i && j < strLen - i; j++)
                {
                    if (ss[i + j] == ss[i - j])
                    {
                        tempStrLen = j * 2 + 1;
                        if (tempStrLen > MaxLen)
                        {
                            MaxLen = tempStrLen;
                            MaxLeft = i - j;
                            MaxPalinLen = tempStrLen;
                            //returnvalue = ss.Substring(i - j, tempStrLen).Replace("#", "");
                        }
                    }
                    else
                    {
                        //if (!ss[i + j].Equals('#'))
                        {
                            break;
                        }
                    }
                }
            }

            return ss.Substring(MaxLeft, MaxPalinLen).Replace("#", "");
        }
    }
}