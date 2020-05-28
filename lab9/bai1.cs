using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;

namespace session13
{
    class bai1
    {
        static void Main(string[] args)
        {
            List<string> objList = new List<string>();
            objList.Add("Francis");
            objList.Add("James");
            objList.Add("Baptisa");
            objList.Add("Micheal");

            ReadOnlyCollection<string> objReaOnly = new ReadOnlyCollection<string>(objList);
            Console.WriteLine("Values stored in the read only collection");
            foreach(string str in objReaOnly)
            {
                Console.WriteLine(str);
            }
            Console.WriteLine();
            Console.WriteLine("Total number of elements in the read only collection:" + objReaOnly.Count);
            if (objList.Contains("Francis"))
            {
                objList.Insert(2, "Peter");
            }
            Console.WriteLine("\nValues stored in the list after modification");
            foreach (string str in objReaOnly)
            {
                Console.WriteLine(str);
            }
            string[] array = new string[objReaOnly.Count * 2];
            objReaOnly.CopyTo(array, 5);
            Console.WriteLine("\nTotal number of values that can be stored in the new array: " +array.Length);
            Console.WriteLine("Values in the new array");

            foreach(string str in array)
            {
                if(str == null)
                {
                    Console.WriteLine("null");
                }
                else
                {
                    Console.WriteLine(str);
                }
            }
        }
    }
}
