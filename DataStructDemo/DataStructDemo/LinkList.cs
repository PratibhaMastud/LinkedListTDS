using System;
using System.Collections.Generic;
using System.Text;


namespace DataStructDemo
{
    class LinkList
    {
         internal Node head;
         internal void Add(int data)
         {
            Node newnode = new Node(data);
            if (this.head == null)
            {
                this.head = newnode;
            }
            else
            {
                newnode.next = head;
                this.head = newnode;
            }
            Console.WriteLine("{0} this value is added", newnode.data);
         }

        internal void Display()
        {
            Node temp = this.head;
            if (temp == null)
            {
                Console.WriteLine("Empty Linked list");
                return;
            }
            while (temp != null)
            {
                Console.Write(temp.data + " ");
                temp = temp.next;
            }
        }

        /// <summary>
        /// Insert 30 between 56 and 70
        /// </summary>
        /// <param name="position"></param>
        /// <param name="data"></param>
        internal void insertBetweenPosition(int position, int data)
        {
            if (position < 1)
            {
                Console.WriteLine("Invalid Position");
            }

            if (position == 1)
            {
                var newNode = new Node(data);
                newNode = this.head;
                head = newNode;
            }
            else
            {
                while (position-- != 0)
                {
                    if (position == 1)
                    {
                        Node node = new Node(data);
                        node.next = this.head.next;
                        head.next = node;
                        break;
                    }
                    head = head.next;
                }
            }
            Console.WriteLine("\nHead is value  " + head.data );
        }

        /// <summary>
        /// Remove first element from linkedlist
        /// </summary>
        /// <returns></returns>
        internal Node removeFirstNode()
        {
            if (head == null)
            {
                return null;
            }
            this.head = this.head.next;
            return this.head;
        }

    }
}
