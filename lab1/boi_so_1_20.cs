using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace boi_so_1_20
{
    class boi_so_1_20
    {
        static void Main(string[] args)
        {
            long number = 1;
            for(int i = 1; i <= 20; i++)
            {
                number = number * i;
                Console.WriteLine(i + " = " + number);
            }
        }
    }
}
