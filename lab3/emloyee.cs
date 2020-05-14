using System;

namespace bai4
{
    class emloyee
    {

        private string fistname;
        private string lastname;
        private string address;
        private string sin;
        private double salary;

        public emloyee(string fistname, string lastname, string address, string sin, double salary)
        {
            this.fistname = fistname;
            this.lastname = lastname;
            this.address = address;
            this.sin = sin;
            this.salary = salary;
        }

        public virtual void Salary(double discount)
        {
            Console.Write("You slary is: ");
            Console.WriteLine(salary * discount / 100);
        }

        public override string ToString()
        {
            
            return base.ToString();
        }
        
    }
}
