using System;
using System.Collections.Generic;
using System.Text;

namespace lab8
{
    class Snippet_8
    {
        interface IAnimal
        {
            void Drink();
        }
        interface ICarnivorous
        {
            void Eat();
        }
        interface IReptile : IAnimal, ICarnivorous
        {
            void Habitat();
        }
        class Crocodile : IReptile
        {
            public void Drink()
            {
                Console.WriteLine("Drinks fresh water");
            }
            public void Habitat()
            {
                Console.WriteLine("Can stay in water and land");
            }
            public void Eat()
            {
                Console.WriteLine("Eats Flesh");
            }
            static void Main1(string[] args)
            {
                Crocodile c1 = new Crocodile();
                Console.WriteLine(c1.GetType().Name);
                c1.Habitat();
                c1.Eat();
                c1.Drink();
            }
        }
    }
}
