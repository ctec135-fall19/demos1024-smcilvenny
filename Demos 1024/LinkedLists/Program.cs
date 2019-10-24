using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinkedLists
{
    class Program
    {
        static void Main(string[] args)
        {
            //create a new linked list node of type string and display its 
            //properties
            LinkedListNode<string> lln = new LinkedListNode<string>("Orange");
            Console.WriteLine("display properties");
            DisplayProperties(lln);
            Console.WriteLine();

            // create a linked list
            LinkedList<string> ll = new LinkedList<string>();
            ll.AddLast(lln);
            Console.WriteLine("after adding node to list");
            DisplayProperties(lln);
            Console.WriteLine();

            // add
            ll.AddFirst("red");
            ll.AddLast("yellow");
            Console.WriteLine("after adding other nodes");
            DisplayProperties(lln);
            Console.WriteLine();

            // traversal of linked list
            Console.WriteLine("traversal");
            LinkedListNode<string> node = ll.First;

            while(node != null)
            {
                Console.WriteLine("      {0}", node.Value);
                node = node.Next;
            }
            Console.WriteLine();

        }

        public static void DisplayProperties(LinkedListNode<string> lln)
        {
            if (lln.List == null)
                Console.WriteLine("      Node is not linked");
            else
                Console.WriteLine("      Node belongs to linked list with {0} elements", lln.List.Count);

            if (lln.Previous == null)
                Console.WriteLine("      Previous node is null");
            else
                Console.WriteLine("      Value of previous node is {0}", lln.Previous.Value);

            if (lln.Next == null)
                Console.WriteLine("      Next node is null");
            else
                Console.WriteLine("      Value of next node is {0}", lln.Next.Value);
        }
    }
}
