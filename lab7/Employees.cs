using System;
using System.Collections.Generic;
using System.Text;

namespace lab7
{
    class Employees
    {
        string _empName;
        int _empAge;
        string _deptName;
        Employees(string name, int num)
        {
            _empName = name;
            _empAge = num;
            _deptName = "Research & Development";
        }
        static void Main1(string[] args)
        {
            Employees objEmp = new Employees("John", 10);
            Console.WriteLine(objEmp._deptName);
        }
    }
}
