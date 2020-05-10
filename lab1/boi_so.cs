using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Part4
{
    class boi_so
    {
        static void Main(string[] args)
        {
            Console.Write("nhap vao mot so: ");
            int number = Int32.Parse(Console.ReadLine());
            for(int i = 1; i <= 9; i++)
            {
                Console.WriteLine(number + " * " + i + " = " + number * i);
            }
        }
    }
}
