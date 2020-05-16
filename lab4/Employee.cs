using System;
using System.Collections.Generic;
using System.Text;

namespace people
{
    public class Employee : Person
    {
        private string department;
        private double salary;
    
        public Employee(string department, double salary)
        {
            this.department = department;
            this.salary = salary;
        }

        public Employee(string department, double salary, string name, string address, string email) : 
            base(name, address, email)
        {
            this.department = department;
            this.salary = salary;
        }

        public string getDepartment
        {
            get { return department; }
 
        }

        public double getSalary
        {
            get { return salary; }
       
        }

        public override string ToString()
        {
            return "Student has: Business is" + department + ", Computer Science" + salary + ", name is " + name + ", address is " + address + ", email is " + email;
        }

        public override double Faculty()
        {
            return 1000 + 0.05 * salary;
        }

        public override double Staff()
        {
            return 0.06 * salary;
        }

    }
}
