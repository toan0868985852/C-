using System;
using System.Collections.Generic;
using System.Text;

namespace lab7
{
    class Multiplication
    {
        static int _valueOne = 10;
        static int _product;
        static Multiplication()
        {
            Console.WriteLine("Static Constructor initialized");
            _product = _valueOne * _valueOne;
        }
        public static void Method()
        {
            Console.WriteLine("Value of product = " +_product);
        }
        static void Main1(string[] args)
        {
            Multiplication.Method();
        }
    }
}
