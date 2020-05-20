using System;
using System.Collections.Generic;
using System.Text;

namespace Abstract
{
    class BusinessEmployee : Employee
    {
        public double bonusBudget = 1000;

        // Calls upon base-class (Employee Class) constructor from within derived class (BusinessEmployee Class)
        // Sets baseSalary to 50000 for all BusinessEmployee objects
        public BusinessEmployee(String name) : base(name, 50000)
        {
        }
        public override String employeeStatus()
        {
            return toString() + " with a budget of " + this.bonusBudget;
        }
    }
}
