using System;

namespace StacksAndQueues
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, Welcome to Stacks and Queues!");
            //creation of a list
            LinkedList list = new LinkedList();
            //pushing elements to list
            list.Push(70);
            list.Push(30);
            list.Push(56);
            list.Display();
        }
    }
}
