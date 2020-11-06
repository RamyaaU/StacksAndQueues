using System;
using System.Collections.Generic;
using System.Text;

namespace StacksAndQueues
{
    public class LinkedList
    {
        private Node top;
        /// <summary>
        /// Initializes a new instance of the <see cref="LinkedList"/> class.
        /// </summary>
        public LinkedList()
        {
            this.top = null;
        }
        /// <summary>
        /// Pushes the specified value.
        /// </summary>
        /// <param name="value">The value.</param>
        public void Push(int value)
        {
            Node node = new Node(value);
            if (this.top == null)
                node.next = null;
            else
                node.next = this.top;
            this.top = node;
            Console.WriteLine("{0} pushed to stack ", value);
        }

        /// <summary>
        /// Peeks this instance.
        /// </summary>
        public void Peek()
        {
            if (this.top == null)
            {
                Console.WriteLine("Stack is empty");
                return;
            }
            Console.WriteLine("{0} is in the top of the stack ", this.top.data);
        }

        /// UC 1
        /// <summary>
        /// Pops this instance.
        /// </summary>
        public void Pop()
        {
            if (this.top == null)
            {
                Console.WriteLine("Stack is empty, Deletion is not possible");
                return;
            }
            Console.WriteLine("Value popped is {0} ", this.top.data);
            this.top = this.top.next;
        }

        /// UC 2
        /// <summary>
        /// Determines whether this instance is empty.
        /// </summary>
        internal void IsEmpty()
        {
            while (this.top != null)
            {
                Peek();
                Pop();
            }
            Console.WriteLine("Stack is empty now.");
        }
        /// <summary>
        /// Displays this instance.
        /// </summary>
        public void Display()
        {
            if (top == null)
            {
                Console.WriteLine("Stack is Empty");
            }
            else
            {
                Node n = top;
                while (n.next != null)
                {
                    Console.Write(n.data + " ");
                    n = n.next;
                }
                Console.Write(n.data + "\n");
            }
        }
    }
}
 