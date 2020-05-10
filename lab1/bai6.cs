using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LAB1_1
{
    class bai6
    {
        static void Main1(string[] args)
        {
            var i = 5;
            var s = "hello";
            var d = 1.0;
            //i is an integer
            Console.WriteLine("i*i: " + i * i);
            //s is a string
            Console.WriteLine("s in upper case:" + s.ToUpper());
            //d is a double
            Console.WriteLine("type of d:" + d.GetType());
            Console.ReadLine();
        }
    }
}
