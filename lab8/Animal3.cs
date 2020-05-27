using System;
using System.Buffers.Text;
using System.Collections.Generic;
using System.Text;

namespace lab8
{
    class Animal3
    {
        public void Eat() 
        {
         
        }
    }
    class Dog : Animal3
    {
        public void Eat() { }
        public void Main2(string[] args)
        {
            Dog objDog = new Dog();
            objDog.Eat();
            base.Eat();
        }
    }
}
