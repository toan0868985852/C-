using System;
using System.Collections.Generic;
using System.Text;

namespace lab7
{
    class OutParameters
    {
        static void Depreciation(out int val)
        {
            val = 20000;
            int dep = val * 5 / 100;
            int amt = val - dep;
            Console.WriteLine("Depreciation Amount: " + dep);
            Console.WriteLine("Reduced value after depreciation: " + amt);
        }

        static void Main1(string[] args)
        {
            int value;
            Depreciation(out value);
        }
    }
}
