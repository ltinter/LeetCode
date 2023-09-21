using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Numerics;

namespace _000_TestProject
{
    class Program
    {
        static void Main(string[] args)
        {
            BigInteger BigNumber = 1;
            for (int i = 0; i < 365; i++)
            {
                BigNumber *= 2;
            }
            Console.WriteLine(BigNumber.ToString());
            Console.ReadLine();
        }
    }
}
