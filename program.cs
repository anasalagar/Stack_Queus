using System;

namespace StackLinkedList
{
    class Program
    {
        static void Main(string[] args)
        {
            //creating object stack class
            StackLinkedList list = new StackLinkedList();
            //calling push method
            list.Push(70);
            list.Push(30);
            list.Push(56);
            //calling display method
            list.Display();
 UC2_stack_Empty
            //calling IsEmpty method
            list.IsEmpty();
            list.Display();
            

 main
            Console.ReadLine();

        }
    }
}
