using System;
using System.Collections.Generic;
using System.Text;

namespace C_PragrammingPractise
{
    public class DataStructures
    {
        public static void DataStructure()
        {
            //Stack - LIFO
            Stack<int> stack = new Stack<int>();
            stack.Push(1);
            stack.Push(2);
            Console.WriteLine("stack pop: "+stack.Pop()); //// Output: 2

            //Queue - FIFO
            Queue<int> queue = new Queue<int>();
            queue.Enqueue(1);
            queue.Enqueue(2);
            Console.WriteLine("Dequeue method in Queues: "+ queue.Dequeue()); // Output: 1

        }
    }
}
