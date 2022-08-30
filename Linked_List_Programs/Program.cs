using System;
using System.Xml.Linq;

namespace Linked_List_Programs
{
    public class Program
    {
        static void Main(string[] args)
        {
            Node head = new Node(56);
            ////new node will have reference of head's next reference
            head.next = new Node(30);
            //and now head will refer to new node
            head.next.next = new Node(70);
        }
    }
}
