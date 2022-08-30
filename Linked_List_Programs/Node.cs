using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Linked_List_Programs
{
    public class Node
    {
        public int data;
        //Next is the pointer to the next node in the list
        public Node next;
        public Node(int data)
        {
            this.data = data;
        }
    }
}
