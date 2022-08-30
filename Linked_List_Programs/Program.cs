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
            //adding items to the list
            list.Add(56);
            //appending items to the list
            list.Append(30);
            list.Append(70);
            //linkedlist sequence = 56->30->70
            list.Display();
        }
    }
}
