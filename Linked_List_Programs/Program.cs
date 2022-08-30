using System;
using System.Collections.Generic;
using System.Xml.Linq;

namespace Linked_List_Programs
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, Welcome to Linked List!");
            Sorted_Linked_List list = new Sorted_Linked_List();
            //adds items to list
            list.Add(70);
            list.Add(30);
            list.Add(56);
            list.Add(40);
            Console.WriteLine("List size is: ", list.Size());
            ///linkedlist sequence = 30->40->56->70
            list.Display();
        }
    }
}
