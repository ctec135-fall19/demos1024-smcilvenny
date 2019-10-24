using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace list_and_ques
{
    class Program
    {
        static void Main(string[] args)
        {
            //stacks
            //declaration

            Stack<STudent> stackOfStudents = new StackOfStudents();

            StackOfStudents.Push(new STudent("Bill"));
            StackOfStudents.Push(new STudent("Jack"));

            foreach(STudent s in StackOfStudents)
            {
                Console.WriteLine(s.Name);
            }
            Console.WriteLine(StackOfStudents.Count);
            Console.WriteLine();

            // pops
            int cnt = StackOfStudents.Count;
            for (int i =0; i<cnt; i++)
            {
                Console.WriteLine(StackOfStudents.Pop().Name);
            }
            Console.WriteLine(StackOfStudents.Count);
            Console.WriteLine();

            // ques
            Queue<STudent> studentQueue = new Queue<STudent>();

            //put into queue
            studentQueue.Enqueue(new STudent("Bill"));
            studentQueue.Enqueue(new STudent("Jill"));
            studentQueue.Enqueue(new STudent("Jack"));

            foreach(STudent s in studentQueue)
            {
                Console.WriteLine(s.Name);
            }
            Console.WriteLine(studentQueue.Count);
            Console.WriteLine();

            cnt = studentQueue.Count;
            for (int i =0; i<cnt; i++)
            {
                Console.WriteLine(studentQueue.Dequeue().Name);
            }
            Console.WriteLine(studentQueue.Count);
            Console.WriteLine();


        }
    }
}
