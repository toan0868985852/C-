﻿using System;
using System.Collections.Generic;
using System.Text;

namespace lab8
{
    class Snippet_10
    {
        interface ICalculate
        {
            double Area();
        }
        class Rectangle : ICalculate
        {
            float _length;
            float _breadth;
            public Rectangle(float valOne, float valTwo)
            {
                _length = valOne;
                _breadth = valTwo;
            }
            public double Area()
            {
                return _length * _breadth;
            }
            static void Main1(string[] args)
            {
                Rectangle objRectangle = new Rectangle(10.2F, 20.3F);
                if (objRectangle is ICalculate)
                {
                    Console.WriteLine("Area of rectangle: {0:F2}" , objRectangle.Area());
                }
                else
                {
                    Console.WriteLine("Interface method not implemented");
                }
            }
        }
    }

}