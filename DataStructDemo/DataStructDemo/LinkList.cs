using System;
using System.Collections.Generic;
using System.Text;


namespace DataStructDemo
{
    class LinkList
    {
        internal Node head;

        internal void insertData(int data)
        {
            Node newnode = new Node(data);
            if (head == null)
            {
                head = newnode;
            }
            else
            {
                Node temp = head;
                while (temp.next != null)
                {
                    temp = temp.next;
                }
                temp.next = newnode;
            }
            Console.WriteLine("{0} - Added in linklist",newnode.data);
        }

        internal void Display() 
        {
            Node temp = head;
            if (temp == null)
            {
                Console.WriteLine("LinkedList is Empty");
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
