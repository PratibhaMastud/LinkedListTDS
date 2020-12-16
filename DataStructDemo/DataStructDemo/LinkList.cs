using System;
using System.Collections.Generic;
using System.Text;


namespace DataStructDemo
{
    public class LinkList
    {
         internal Node head;
         public void Add(int data)
         {
            Node newnode = new Node(data);
            Node temp = head;
            if (this.head == null)
            {
                this.head = newnode;
            }
            else
            {
                while (temp.next != null)
                {
                    temp = temp.next;
                }
                temp.next = newnode;
               
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
            Console.WriteLine("\nHead is value" + head.data );
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
        /// <summary>
        /// Remove Last Element or Node
        /// </summary>
        internal Node removeLastNode()
        {
            Node temp = head;
            Node prev = temp;
            if (head == null)
            {
                return head;
            }
            else
            {
                if (temp.next.next == null) 
                {
                    temp.next = null;
                }
                temp = temp.next;
                return this.head;

            }
        }
        /// <summary>
        /// Search Node from Linkedlist
        /// </summary>
        /// <param name="value"></param>
        public int findNodeWithValue(int value)
        {
            bool flag = true;
            int count = 1;
            Node temp = head;
            while (flag)
            {
                if (temp.data == value)
                {
                    flag = false;
                }
                else
                {
                    temp = temp.next;
                    count++;
                }
            }
            return count;
        }
    }
}
