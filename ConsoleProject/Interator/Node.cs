using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleProject.Interator
{
    public static class StackTest
    {
        public static void Test()
        {
            Node node = new Node();
            MyNode mystack1 = new MyNode()
            {
                ID = 1,
                StackName = "CBL"
            };
            node.Push(mystack1);
            MyNode mystack2 = new MyNode()
            {
                ID = 2,
                StackName = "ZK"
            };
            node.Push(mystack2);
            MyNode mystack3 = new MyNode()
            {
                ID = 3,
                StackName = "秋天"
            };
            node.Push(mystack3);
            var item1 = node.Pop();
            var item2 = node.Pop();
            var item3 = node.Pop();

    }

        public static void Reverse(int[] array,int begin,int end)
        {
            if (end > begin)
            {
                int temp = array[begin];
                array[begin] = array[end];
                array[end] = temp;
                begin++;
                end--;
            }
        }
    }

    public class StackArray
    {
        MyNode[] item;
        int number = 0;

        public void StackImplementByArray(int capacity)
        {
            item = new MyNode[capacity];
        }

        public void Push(MyNode _item)
        {
            if(number==item.Length) Resize(2 * item.Length);
            item[number++] = _item;
        }

        public MyNode Pop()
        {
            MyNode temp = item[--number];
            item[number] = default(MyNode);
            if (number > 0 && number == item.Length / 4) Resize(item.Length / 2);
            return temp;
        }

        private void Resize(int capacity)
        {
            MyNode[] temp = new MyNode[capacity];
            for (int i = 0; i < item.Length; i++)
            {
                temp[i] = item[i];
            }
            item = temp;
        }
    }

    public class QueueArray
    {
        MyNode[] item = null;
        private int head, tail;
        public void QueueImplementByArray(int capacity)
        {
            item = new MyNode[capacity];
        }

        public void Enqueue(MyNode _item)
        {
            if ((head - tail + 1) == item.Length) Resize(2 * item.Length);
            item[tail++] = _item;
        }

        public MyNode Dequeue()
        {
            MyNode temp = item[head];
            item[head] = default(MyNode);
            if (head > 0 && (tail - head + 1) == item.Length / 4) Resize(item.Length / 2);
            head++;
            return temp;
        }

        private void Resize(int capacity)
        {
            MyNode[] temp = new MyNode[capacity];
            int index = 0;
            for (int i = head; i < tail; i++)
            {
                temp[++index] = item[i];
            }
            item = temp;
        }
    }

    //堆栈，先进后出http://blog.jobbole.com/79267/,队列，先进先出
    public class MyNode
    {
        public int ID { get; set; }
        public string StackName { get; set; }
    }

    public class Node
    {
        public MyNode Item { get; set; }
        public Node Next { get; set; }
        private Node first = null;
        private Node last = null;
        private int number = 0;

        public void Push(MyNode node)
        {
            Node oldFirst = first;
            first = new Node();
            first.Item = node;
            first.Next = oldFirst;
            number++;
        }

        public MyNode Pop()
        {
            MyNode item = first.Item;
            first = first.Next;
            number--;
            return item;
        }

        public MyNode Dequeue()
        {
            MyNode temp = first.Item;
            first = first.Next;
            number--;
            if (IsEmpety())
                last = null;
            return temp;
        }

        public void Enqueue(MyNode item)
        {
            Node oldLast = last;
            last = new Node();
            last.Item = item;
            if (IsEmpety())
            {
                first = last;
            }
            else
            {
                oldLast.Next = last;
            }
            number++;
        }


        private bool IsEmpety()
        {
            if (number == 0)
            {
                return true;
            }
            return false;
        }
    }
}
