using System;
using System.Collections.Generic;
namespace bai6
{
    interface IDetails
    {
        void GetDetails();
    }
    class Program : IDetails
    {
        string _studName;
        int _studID;
        public Program(string name, int num)
        {
            _studName = name;
            _studID = num;
        }
        public void GetDetails()
        {
            Console.WriteLine(_studID + "\t" +_studName);
        }
    }
    class GenericList<T> where T : IDetails
    {
        T[] _values = new T[3];
        int _counter = 0;
        public void Add(T val)
        {
            _values[_counter] = val;
            _counter++;
        }
        public void Display()
        {
            for (int i = 0; i < 3; i++)
            {
                _values[i].GetDetails();
            }
        }
    }
    class InterfaceConstraintDemo
    {
        static void Main(string[] args)
        {
            GenericList<Program> objList = new GenericList<Program>();
            objList.Add(new Program("Wilson", 120));
            objList.Add(new Program("Jack", 130));
            objList.Add(new Program("Peter", 140));
            objList.Display();
        }
    }
}
