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
    }
}
