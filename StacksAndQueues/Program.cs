using System;

namespace StacksAndQueues
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, Welcome to Stacks and Queues!");
            //creating a list
            LinkedList list = new LinkedList();
            list.Push(70);
            list.Push(30);
            list.Push(56);
            list.IsEmpty();
            list.Display();
        }
    }
}
