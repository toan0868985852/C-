using System;

namespace lab8
{
    class Animal
    {

        public void Eat()
        {
            Console.WriteLine("Every animal eats something.");
        }
    }
    class Mammil : Animal
    {
        public void Feature() 
        {
            Console.WriteLine("Mammals give birth to young ones.");
        }
    }
    class Dog1 : Mammil
    {
        public void Noise()
        {
            Console.WriteLine("Dog Barks.");
        }
        static void Main1(string[] args)
        {
            Dog1 objDog = new Dog1();
            objDog.Eat();
            objDog.Feature();
            objDog.Noise();
        }
    }
}
