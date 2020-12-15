using System;

namespace DataStructDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            LinkList linkList = new LinkList();

            bool loop = true;
            while (loop)
            {
                Console.WriteLine("Enter the choice: \n1.Add Data \n2.Display list of data \n3.Exit");
                int choice = Convert.ToInt32(Console.ReadLine());

                switch (choice)
                {
                    case 1:
                        Console.WriteLine("\nEnter the Number of Data you want to enter");
                        int size = Convert.ToInt32(Console.ReadLine());
                        for (int i = 1; i <= size; i++)
                        {
                            Console.WriteLine("\nEnter data");
                            int data = Convert.ToInt32(Console.ReadLine());
                            linkList.insertData(data);
                        }
                        break;
                    case 2:
                        linkList.Display();
                        break;
                    case 3:
                        loop = false;
                        break;
                }
            }
        }
    }
}


