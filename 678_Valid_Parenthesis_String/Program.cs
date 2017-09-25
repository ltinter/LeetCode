using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _678_Valid_Parenthesis_String
{
    class Program
    {
        static void Main(string[] args)
        {
            var stringToCheck = "(*)";
            Console.WriteLine(CheckValidString(stringToCheck).ToString());
            Console.ReadLine();
        }

        static public bool CheckValidString(string InputString)
        {
            if (InputString.Trim().Equals("")) return true;
            if (InputString[0] == ')' || InputString[InputString.Length - 1] == '(') return false;
            char[] s = InputString.ToArray<char>();

            bool returnValue = true;
            if (s.Length == 0) return returnValue;

            int index = 0;
            int step = 1;
            int BaseIndex = 0;
            char BaseChar = '*';
            List<string> DebugList = new List<string>();
            bool ChangedOrRedired = false;

            while (index < s.Length && index > -1)
            {
                if (index == 0) ChangedOrRedired = false;
                switch (s[index])
                {
                    case ' ':
                    case '*':
                        if (index == 0 && BaseChar == ')')
                        {
                            int tempStarIndex = (new string(s.Take<char>(BaseIndex + 1).ToArray<char>())).IndexOf('*');
                            if (tempStarIndex > -1)
                            {
                                s[BaseIndex] = s[tempStarIndex] = ' ';
                                BaseChar = '*';
                                step = 1;
                                ChangedOrRedired = true;
                            }
                            else
                            {
                                returnValue = false;
                                index = s.Length + 2;
                            }
                        }
                        else if (index == s.Length - 1 && BaseChar == '(')
                        {
                            int tempStarIndex = (new string(s.Skip<char>(BaseIndex).ToArray<char>())).IndexOf('*');
                            if (tempStarIndex > -1)
                            {
                                s[BaseIndex] = s[tempStarIndex + BaseIndex] = ' ';
                                BaseChar = '*';
                                step = -1;
                                ChangedOrRedired = true;
                            }
                            else
                            {
                                returnValue = false;
                                index = s.Length + 2;
                            }
                        }
                        break;
                    case '(':
                        if (index == s.Length - 1)
                        {
                            returnValue = false;
                            index = s.Length + 2;
                            break;
                        }
                        if (BaseChar == '*' || BaseChar == ' ')
                        {
                            BaseChar = '(';
                            BaseIndex = index;
                            step = 1;
                            ChangedOrRedired = true;
                        }
                        else if (BaseChar == '(')
                        {
                            BaseIndex = index;
                            step = 1;
                            ChangedOrRedired = true;
                        }
                        else if (BaseChar == ')')
                        {
                            s[BaseIndex] = s[index] = ' ';
                            BaseChar = '*';
                            ChangedOrRedired = true;
                        }
                        break;
                    case ')':
                        if (index == 0)
                        {
                            returnValue = false;
                            index = s.Length + 2;
                            break;
                        }
                        if (BaseChar == '*' || BaseChar == ' ')
                        {
                            BaseChar = ')';
                            BaseIndex = index;
                            step = -1;
                            ChangedOrRedired = true;
                        }
                        else if (BaseChar == ')')
                        {

                        }
                        else if (BaseChar == '(')
                        {
                            s[BaseIndex] = s[index] = ' ';
                            BaseChar = '*';
                            ChangedOrRedired = true;
                        }
                        break;
                }

                if (index == 0) step = 1;
                if (index == s.Length - 1)
                {
                    if (ChangedOrRedired)
                    {
                        step = -1;
                    }
                    else
                    {
                        break;
                    }
                }
                index = index + step;

                DebugList.Add(new string(s) + " + " + index.ToString() + " + " + step.ToString());
            }

            return returnValue;
        }
    }
}