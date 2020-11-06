using System;

namespace StacksAndQueues
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, Welcome to Stacks and Queues!");
            LinkedList list = new LinkedList();
            list.Enqueue(56);
            list.Enqueue(30);
            list.Enqueue(70);
            list.Dequeue();
            list.Display();
        }
    }
}
