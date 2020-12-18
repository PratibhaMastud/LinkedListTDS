using System;

namespace DataStructDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            LinkList linkList = new LinkList();
            /*linkList.Add(56);
            linkList.Add(30);
            linkList.Add(70);
            linkList.Display();
            Console.WriteLine("\nAdd after 30 : 40");
            linkList.AddAfterAtPerticulatPosition(30);
            linkList.Display();
            int position = linkList.deletePerticulatElement(30);
            Console.WriteLine("\nthe size of linkedlist is {0} ",position);
            linkList.Display();*/
             SortedLinklist sortedList = new SortedLinklist();
            sortedList.sortedInsert(50);
            sortedList.sortedInsert(20);
            sortedList.sortedInsert(30);
            sortedList.sortedInsert(10);

            Console.WriteLine("Sorted Linked List");
            sortedList.Display();
        }
    }
}

