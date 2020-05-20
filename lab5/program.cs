﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Abstract
{
    class program
    {
        static void Main(string[] args)
        {
            // Instantiates TechnicalEmployee Object with name Libby called employee1
            var employee1 = new TechnicalEmployee("Libby");
            // Instantiates TechnicalEmployee Object with name Zaynah called employee2
            var employee2 = new TechnicalEmployee("Zaynah");
            // Instantiates BusinessEmployee Object with name Winter called employee3
            var employee3 = new BusinessEmployee("Winter");

            Console.WriteLine(employee1.employeeStatus() + "..." + employee2.employeeStatus() + "..." + employee3.employeeStatus());
        }
    }
}
