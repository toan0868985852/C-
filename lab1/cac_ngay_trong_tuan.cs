using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Part4
{
    class cac_ngay_trong_tuan
    {
        static void Main1(string[] args)
        {
            Console.WriteLine("nhap vao mot thu trong tuan");
            int date = Int32.Parse(Console.ReadLine());
            switch (date)
            {
                case 2: 
                    Console.WriteLine("day la thu hai");
                    break;
                case 3: 
                    Console.WriteLine("day la thu ba");
                    break;
                case 4:
                    Console.WriteLine("day la thu tu");
                    break;
                case 5:
                    Console.WriteLine("day la thu nam");
                    break;
                case 6:
                    Console.WriteLine("day la thu sau");
                    break;
                case 7:
                    Console.WriteLine("day la thu bay");
                    break;
                case 8:
                    Console.WriteLine("day la chu nhat");
                    break;
                default:
                    Console.WriteLine("khong co ngay nay trong tuan");
                    break;
            }
        }
    }
}
