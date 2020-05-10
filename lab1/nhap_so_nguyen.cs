using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Part4
{
    class nhap_so_nguyen
    {
        static void Main1(string[] args)
        {
            int a, b, c;
            Console.WriteLine("nhap vao 3 so.");
            Console.Write("a = ");
            a = Int32.Parse(Console.ReadLine());
            Console.Write("b = ");
            b = Int32.Parse(Console.ReadLine());
            Console.Write("c = ");
            c = Int32.Parse(Console.ReadLine());
            if(a > b && a > c)
            {
                Console.WriteLine("{0} la so lon nhat", a);
            }else if(b > c && b > a)
            {
                Console.WriteLine("{0} la so lon nhat", b);
            }else if (c > a && c > b)
            {
                Console.WriteLine("{0} la so lon nhat", c);
            }

        }
    }
}
