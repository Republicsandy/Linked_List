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
            //creating a list
            Linked_List list = new Linked_List();
            //appending the items to list
            list.Append(56);
            list.Append(30);
            list.Append(40);
            list.Append(70);
            list.Delete(40);
            //displays size of list
            Console.WriteLine("Size of list is: " + list.Size());
            //linkedlist sequence = 56->30->70
            list.Display();
        }
    }
}
