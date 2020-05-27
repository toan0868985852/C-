using System;
using System.Collections.Generic;
using System.Text;

namespace lab8
{
    class Animal4
    {
        public Animal4()
        {
            Console.WriteLine("Animal4 constructor without parameters");
        }
        public Animal4(String name)
        {
            Console.WriteLine("Animal4 constructor with a string parameter");
        }
    }

    class Canine : Animal4
    {
        //base() takes a string value called “Lion”
        public Canine() : base("Lion")
        {
            Console.WriteLine("Derived Canine");
        }

    }
    class Details
    {
        static void Main1(String[] args)
        {
            Canine objCanine = new Canine();
        }
    }
}
