using System;
using System.Collections.Generic;
using System.Text;

namespace lab8
{
    class ITSystem
    {
        public virtual void Print()
        {
            Console.WriteLine("The system should be handled carefully");
        }
    }
    class CompanySystem : ITSystem
    {
        public override sealed void Print()
        {
            Console.WriteLine("The system information is confidential");
            Console.WriteLine("This information should not be overridden");
        }
    }
    class SealedSystem : CompanySystem
    {
        public override void Print()
        {
            Console.WriteLine("This statement won’t get executed");
        }
        static void Main1(string[] args)
        {
            SealedSystem objSealed = new SealedSystem();
            objSealed.Print();
        }
    }
}
