using System;
using System.Collections.Generic;
using System.Text;

namespace bai4
{
    class testemploye
    {
        static object Main(string[] args)
        {
            string fistname;
            string lastname;
            string address;
            string sin;
            double salary;

            
            Console.Write("Enter fist name: ");
            fistname = Console.ReadLine();
            Console.Write("Enter lastname: ");
            lastname = Console.ReadLine();
            Console.Write("Enter address: ");
            address = Console.ReadLine();
            Console.Write("Enter sin: ");
            sin = Console.ReadLine();
            Console.Write("Enter salary: ");
            salary = double.Parse(Console.ReadLine());

            emloyee e = new emloyee(fistname, lastname, address, sin, salary);
            double discount;
            Console.Write("Enter discount: ");
            discount = double.Parse(Console.ReadLine());

           
            e.Salary(discount);
        }
    }
}
