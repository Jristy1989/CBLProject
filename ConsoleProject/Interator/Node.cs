using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleProject.Interator
{
    //堆栈，先进后出http://blog.jobbole.com/79267/
    class Node
    {
        public Node Item { get; set; }
        public Node Next { get; set; }
        private Node first = null;
        private int number = 0;

        void Push(Node node)
        {
            Node oldFirst = first;
            first = new Node();
            first.Item = node;
            first.Next = oldFirst;
            number++;
        }

        Node Pop()
        {
            Node item = first.Item;
            first = first.Next;
            number--;
            return item;
        }
    }
}
