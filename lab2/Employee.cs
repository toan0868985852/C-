﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bai2
{
    class Employee
    {
        private int empID;

        public Employee(int empID)
        {
            this.empID = empID;
        }

        public override string ToString()
        {
            return base.ToString();
        }
        
    }

    class ObjectArray
    {
        public void Run()
        {
            int[] intArrray;
            Employee[] empArray;
            intArrray = new int[5];
            empArray = new Employee[3];

            for(int i = 0; i < empArray.Length; i++)
            {
                empArray[i] = new Employee(i + 5);
            }
            Console.WriteLine("the int array...");
            for(int i = 0; i < intArrray.Length; i++)
            {
                Console.WriteLine(intArrray[i].ToString());
            }
            Console.WriteLine("\nthe employye array...");
            for(int i = 0; i < empArray.Length; i++)
            {
                Console.WriteLine(empArray[i].ToString());
            }
        }
        static void Main(string[] args)
        {
            ObjectArray arr = new ObjectArray();
            arr.Run();
            Console.ReadLine();

        }
    }


     
}
