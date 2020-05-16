using System;
using System.Collections.Generic;
using System.Text;

namespace people
{
    public class Student : Person
    {
        private string Business;
        private string Computer_Science;

        public Student(string Business, string Computer_Science)
        {
            this.Business = Business;
            this.Computer_Science = Computer_Science;
        }

        public Student(string Business, string Computer_Science, string name, string address, string email) : base(name, address, email)
        {
            this.Business = Business;
            this.Computer_Science = Computer_Science;
        }

        public override string ToString()
        {
            return "Student has: Business is" + Business + ", Computer Science" + Computer_Science + ", name is " + name + ", address is " + address + ", email is " + email;
        }


    }


}
