using System;

namespace DataStructDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            LinkList linkList = new LinkList();
            linkList.Add(56);
            linkList.Add(70);
            linkList.Display();
            Console.WriteLine("\nInsert 30 between 56 and 70");
            linkList.insertBetweenPosition(2,30);
            linkList.Display();
            Console.WriteLine("\nRemove First Node");
            linkList.removeFirstNode();
            linkList.Display();
            Console.WriteLine("\nRemove Last Node");
            linkList.removeLastNode();
            linkList.Display();

        }
    }
}

