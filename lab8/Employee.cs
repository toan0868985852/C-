using System;
using System.Collections.Generic;
using System.Text;

namespace lab8
{
    class Employee
    {
        int empld = 1;
        string empName = "JamesAderson";
        int age = 25;
        public void Display()
        {
            Console.WriteLine("EMployeeID: " + empld);
            Console.WriteLine("EMployeeName: " + empName);
        }
    }
    class Depatment : Employee
    {
        int deptld = 501;
        string depName = "Sales";
        new void Display()
        {
            base.Display();
            Console.WriteLine("DepartmenID: " + deptld);
            Console.WriteLine("DepartmenName: " + depName);
        }
        static void Main1(string[] args)
        {
            Depatment objDepatment = new Depatment();
            objDepatment.Display();
        }
    }
}
