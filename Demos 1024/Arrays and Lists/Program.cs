using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arrays_and_Lists
{
    class Program
    {
        static void Main(string[] args)
        {
            // arrays
            // declaration

            int[] a1 = new int[5];

            // initialization and traversal

            for (int i=0; i < a1.Length; i++)
            {
                a1[i] = (i * 10) + 1;
            }

            int[] a2 = { 1, 2, 3, 4, 5 };  //set values for elements within the array this way

            //traversal
            foreach(int element in a1)
            {
                Console.WriteLine(element);
            }
            Console.WriteLine();

            // lists declaration
            // <> = t value
            List<int> l = new List<int>();

            // initialize - add to list "l"
            //add adds it on to the end of the list
            l.Add(1);
            l.Add(2);
            l.Add(3);

            //accessing and changing elements within the list
            l[1] = 22;

            //some other methods
            l.Insert(2, 99); //first number index second number what to replace it with
            l.Remove(1); //removes element 
            l.Sort();

            //traversal
            // for loop
            for(int i = 0; 1 < l.Count; i++)
            {
                Console.WriteLine(l[i]);
            }
            Console.WriteLine();
            //foreach loop
            foreach(int element in l)
            {
                Console.WriteLine(element);
            }

        }
    }
}
