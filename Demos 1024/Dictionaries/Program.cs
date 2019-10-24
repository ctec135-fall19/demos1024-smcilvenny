﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dictionaries
{
    class Program
    {
        static void Main(string[] args)
        {
            // declaration
            Dictionary<string, Student> studentDictionary = new
                Dictionary<string, Student>();

            // initialize
            studentDictionary.Add("Bill", new Student("Bill1"));
            studentDictionary["Jill"] = new Student("Jill2");
            studentDictionary["Jack"] = new Student("Jack3");

            // traversal - dictionaries have two parts - keys and values

            //loop to traverse through keys
            foreach(string key in studentDictionary.Keys)
            {
                Console.WriteLine(key);
            }
            Console.WriteLine();

            //loop to traverse through value
            foreach(Student s in studentDictionary.Values)
            {
                Console.WriteLine(s.Name);
            }
            Console.WriteLine();

        }
    }
}
