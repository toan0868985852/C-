using System;

namespace bai9
{
    using System.Collections;
    using System.Collections.Generic;
    class GeneralList<V>
    {
        protected V ItemOne;
        public GeneralList(V valOne)
        {
            ItemOne = valOne;
        }
        public virtual V GetValue()
        {
            return ItemOne;
        }
    }
    class Student<T> : GeneralList<T>
    {
        public T Value;
        public Student(T valOne, T valTwo) : base(valOne)
        {
            Value = valTwo;
        }
        public override T GetValue()
        {
            Console.Write(base.GetValue() + "\t\t");
            return Value;
        }
    }
    class StudentList
    {
        public static void Main()
        {
            Student<string> objStudent = new Student<string>("Patrick", "Male");
            Console.WriteLine("Name\t\tSex");
            Console.WriteLine(objStudent.GetValue());
        }
    }
}
