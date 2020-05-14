using System;

namespace Atom
{
    class Atom
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Atomic Information ");
            Console.WriteLine("=====================");
            Console.Write("Nhap vào so lương: ");
            int n = Int32.Parse(Console.ReadLine());
            int[] number = new int[n];
            string[] Symbol = new string[n];
            string[] fullname = new string[n];
            double[] weight = new double[n];

            for (int i = 0; i < n; i++)
            {
                Console.Write("Enter atomic number: ");
                number[i] = Int32.Parse(Console.ReadLine());
                if(number[i] <= 0)
                {
                    Console.WriteLine("Không có phần tử này");
                }else if(number[i] > 0){
                    Console.Write("Enter symbol: ");
                    Symbol[i] = Console.ReadLine();
                    Console.Write("Enter full name: ");
                    fullname[i] = Console.ReadLine();
                    Console.Write("Enter atomic weight: ");
                    weight[i] = Double.Parse(Console.ReadLine());
                }
            }
            Console.WriteLine("----------------------");
            for(int j = 0; j < n; j++)
            {
                
                Console.WriteLine("{0} {1} {2} {3}", number[j], Symbol[j], fullname[j], weight[j]);
            }
            Console.ReadKey();





            /**
            int number = 0, n;
            string Symbol = null;
            string fullname = null;
            double weight = 0;
            Console.WriteLine("Atomic Information ");
            Console.WriteLine("=====================");
            Console.Write("Nhập vào số lượng: ");
            n = Int32.Parse(Console.ReadLine());
            for (int i = 0; i < n; i++)
            {
                Console.WriteLine("Enter atomic number: ");
                number = Int32.Parse(Console.ReadLine());
                if(number <= 0)
                {
                    Console.WriteLine("Không có phần tử này");
                }else if(number > 0){
                    Console.Write("Enter symbol: ");
                    Symbol = Console.ReadLine();
                    Console.Write("Enter full name: ");
                    fullname = Console.ReadLine();
                    Console.Write("Enter atomic weight: ");
                    weight = Double.Parse(Console.ReadLine());
                }
            }
        }**/
        }
    }
 }
