using System;

namespace Workshop1
{
    class StartUp
    {
        static void Main(string[] args)
        {
            DoublyLinkedList<string> test1 = new DoublyLinkedList<string>();

            test1.AddFirst("1");
            test1.AddFirst("2");
            test1.AddFirst("3");

            test1.ForEach(Console.WriteLine);
        }
    }
}
