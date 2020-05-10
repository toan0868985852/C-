using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LAB1_1
{
    class bai3
    {
        static void Main1(string[] args)
        {

            int valueVal = 5;
            Console.WriteLine("The value of the variable is {0}", valueVal);
            Test(valueVal);
            Console.ReadLine();

        }
        static void Test(int valueVal)
        {
            int team = 5;
            valueVal = team * 2;
            Console.WriteLine(valueVal);
        }
    }
}
