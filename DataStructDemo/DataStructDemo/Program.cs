using System;

namespace DataStructDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            LinkList linkList = new LinkList();
            linkList.Add(56);
            linkList.Add(30);
            linkList.Add(70);
            linkList.Display();
            Console.WriteLine("\nAdd after 30 : 40");
            linkList.AddAfterAtPerticulatPosition(30);
            linkList.Display();
        }
    }
}

