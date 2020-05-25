using System;
using System.Collections.Generic;
using System.Text;

namespace lab7
{
    class OptionalParameterExample
    {
        void printMessage(String message = "Hello user!")
        {
            Console.WriteLine("{0}", message);
        }
        static void Main1(string[] args)
        {
            OptionalParameterExample opExample = new OptionalParameterExample();
            opExample.printMessage("Welcome User!");
            opExample.printMessage();
        }
    }
}
