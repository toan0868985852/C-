using System;
using System.Collections.Generic;
using System.Text;

namespace people
{
    public class Class1
    {
        static void Main(string[] args)
        {
            Employee e1 = new Employee("E1", 400000, "Tran van a", "thanh hoa", "tran@gmail.com");
            Console.WriteLine("Employee: " + e1.ToString());
            e1.getsetEmail = "tran123@gmail.com";
            e1.getsetAddress = "Ha Noi";
            Console.WriteLine("Employee after: " + e1.ToString());
            Console.WriteLine("Name: " + e1.getName);
            Console.WriteLine("Address: " + e1.getsetAddress);
            Console.WriteLine("Email: " + e1.getsetEmail);
            Console.WriteLine("department: " + e1.getDepartment);
            Console.WriteLine("salary: " + e1.getSalary);
            Console.ReadKey();
        }
    }
}
