using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleProject.MyTest
{
    public static class QueueArrayTest
    {
        public static void Test()
        {
            QueueArray array = new QueueArray();
            array.QueusImplementByArray(8);
            ArrayModel item1 = new ArrayModel()
            {
                id=1,
                name="A"
            };
            array.Enqueue(item1);
            ArrayModel item2 = new ArrayModel()
            {
                id = 2,
                name = "D"
            };
            array.Enqueue(item2); 
            ArrayModel item3 = new ArrayModel()
            {
                id = 3,
                name = "W"
            };
            array.Enqueue(item2);
            var temp1 = array.Dequeue();
            var temp2 = array.Dequeue();
            var temp3 = array.Dequeue();
        }
    }

    class QueueArray
    {
        ArrayModel[] array;
        private int head, tail;

        public void QueusImplementByArray(int capacity)
        {
            array = new ArrayModel[capacity];
        }

        public void Enqueue(ArrayModel item)
        {
            if ((head - tail + 1) == array.Length) Resize(2 * array.Length);
            array[tail++] = item;
        }


        public ArrayModel Dequeue()
        {
            ArrayModel temp = array[head];
            array[head] = default(ArrayModel);
            if (head > 0 && (tail - head + 1) == array.Length / 4) Resize(array.Length / 2);
            return temp;
        }

        private void Resize(int capacity)
        {
            ArrayModel[] temp = new ArrayModel[capacity];
            int index = 0;
            for (int i = head; i < tail; i++)
            {
                temp[++index] = array[i];
            }
            array = temp;
        }
    }
}
