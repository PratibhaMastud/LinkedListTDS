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
            Console.WriteLine("\nSearch Node");
            int output = linkList.findNodeWithValue(56);
            Console.WriteLine(output);
            linkList.Display();

        }
    }
}

