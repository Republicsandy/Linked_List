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
            list.Add(70);
            list.Add(30);
            list.Add(56);
            //linkedlist sequence = 56->30->70
            list.Display();
        }
    }
}
