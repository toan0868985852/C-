using System;
using System.Collections.Generic;
using System.Text;

namespace lab8
{
    class Animal2
    {
        protected string Food;
        protected string Activity;
    }
    class Cat : Animal2
    {
        static void Main1(string[] args)
        {
            Cat objcat = new Cat();
            objcat.Food = "Mouse";
            objcat.Activity = "Lazearound";
            Console.WriteLine("the cat loves to eat " + objcat.Food);
            Console.WriteLine("the catloves to " + objcat.Activity);
        }
    }
}
