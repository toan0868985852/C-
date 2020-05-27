using System;
using System.Collections.Generic;
using System.Text;

namespace lab8
{
    class Snippet_7
    {
        interface ITerrestrialAnimal
        {
            string Eat();
        }
        interface IMarineAnimal
        {
            string Eat();
        }
        class Crocodile : ITerrestrialAnimal, IMarineAnimal
        {
            public string Eat()
            {
                throw new NotImplementedException();
            }

            string ITerrestrialAnimal.Eat()
            {
                string terCroc = "Crocodile eats other animals";
                return terCroc;
            }
            string IMarineAnimal.Eat()
            {
                string marCroc = "Crocodile eats fish and marine animals";
                return marCroc;
            }
            public string EatTerrestrial()
            {
                ITerrestrialAnimal objTerAnimal;
                objTerAnimal = this;
                return objTerAnimal.Eat();
            }
            public string EatMarine()
            {
                IMarineAnimal objMarAnimal;
                objMarAnimal = this;
                return objMarAnimal.Eat();
            }
            public static void Main1(string[] args)
            {
                Crocodile objCrocodile = new Crocodile();
                string terCroc = objCrocodile.EatTerrestrial();
                Console.WriteLine(terCroc);
                string marCroc = objCrocodile.EatMarine();
                Console.WriteLine(marCroc);
            }
        }
    }
}
