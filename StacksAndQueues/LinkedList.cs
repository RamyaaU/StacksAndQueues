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
        internal void Push(int value)
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
        /// Displays this instance.
        /// </summary>
        public void Display()
        {
            Node temp = this.top;
            while (temp != null)
            {
                Console.Write(temp.data + " ");
                temp = temp.next;
            }
        }
    }
}