using System;

namespace StacksAndQueues
{
    class Program
    {
        /// <summary>
        /// Defines the entry point of the application.
        /// </summary>
        /// <param name="args">The arguments.</param>
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, Welcome to Stacks and Queues!");
            LinkedList list = new LinkedList();
            list.Enqueue(56);
            list.Enqueue(30);
            list.Enqueue(70);
            list.Display();
        }
    }
}
