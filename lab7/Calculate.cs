using System;
using System.Collections.Generic;
using System.Text;

namespace lab7
{
    class Calculate
    {
        public static void Addition(int val1, int val2)
        {
            Console.WriteLine(val1 + val2);
        }
        public void Multiply(int val1, int val2)
        {
            Console.WriteLine(val1 * val2);
        }
    }

    class StaticMethods
    {
        static void Main1(string[] args)
        {
            Calculate.Addition(10, 50);
            Calculate objCal = new Calculate();
            objCal.Multiply(10, 20);
        }
    }
}
