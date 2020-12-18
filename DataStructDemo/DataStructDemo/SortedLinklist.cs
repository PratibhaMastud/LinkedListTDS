using System;
using System.Collections.Generic;
using System.Text;

namespace DataStructDemo
{
    class SortedLinklist
    {
        internal Node head;

        /// <summary>
        /// Method to add node in sorted order
        /// </summary>
        public void sortedInsert(int newnode)
        {
            Node node = new Node(newnode);
            if (head == null || head.data >= node.data)
            {
                node.next = head;
                head = node;
            }
            else
            {
                Node temp = head;

                while (temp.next != null && temp.next.data < temp.data)
                    temp = temp.next;

                node.next = temp.next;
                temp.next = node;
            }
        }

        /// <summary>
        /// Method to create node
        /// </summary>
        internal Node newNode(int data)
        {
            Node x = new Node(data);
            return x;
        }

        /// <summary>
        /// Method to display linked list 
        /// </summary>
        internal void Display()
        {
            Node temp = this.head;
            if (temp == null)
            {
                Console.WriteLine("This Linked list is empty");
                return;
            }
            while (temp != null)
            {
                Console.WriteLine(temp.data + " ");
                temp = temp.next;
            }
        }
    }
}
