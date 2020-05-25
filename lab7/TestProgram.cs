using System;

namespace lab7
{
    class TestProgram
    {
        void Count(int boys, int girls)
        {
            Console.WriteLine(boys + girls);
        }
        static void Main1(string[] args)
        {
            TestProgram objTest = new TestProgram();
            objTest.Count(boys: 16, girls: 24);
        }
    }
   
}
