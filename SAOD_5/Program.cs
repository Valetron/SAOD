using System;
using System.Collections.Generic;
using System.Text;

namespace SAOD_5
{
    class Program
    {
        static void Main(string[] args)
        {
            MyQueue<int> queue = new MyQueue<int>();

            queue.Enqueue(1);
            queue.Enqueue(2);
            queue.Enqueue(3);
            queue.Enqueue(4);
            queue.Enqueue(5);
            
            queue.Print();
            
            if (queue.Empty()) { Console.WriteLine("EMPTY"); }
            else { Console.WriteLine("Not empty"); }

            Console.WriteLine("Delete element");
            queue.Dequeue();
            queue.Print();
            Console.WriteLine(queue.Count + " elements");
            Console.WriteLine("clear queue");
            queue.Clear();
            queue.Print();
        }
    }
}
