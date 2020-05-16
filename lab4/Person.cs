using System;

namespace people
{
     public abstract class Person
    {
        protected String name;
        protected string address;
        protected string email;

        protected Person() { 
        
        }

        protected Person(string name, string address, string email)
        {
            this.name = name;
            this.address = address;
            this.email = email;
        }

        public string getName 
        {
            get { return name; }
        }

        public string getsetAddress
        {
            get { return address; }
            set { address = value; }
        }

        public string getsetEmail
        {
            get { return email; }
            set { email = value; }
        }

        public abstract double Faculty();
        public abstract double Staff();



    }

    
}
