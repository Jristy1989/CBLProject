using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleProject.MyTest
{
    class ArrayModel
    {
        public int id { get; set; }
        public string name { get; set; }
    }
    class StackArray
    {
        ArrayModel[] array;
        int number = 0;

        public void StackImplementByArray(int capacity)
        {
            array = new ArrayModel[capacity];
        }

        public void Push(ArrayModel item)
        {
            if (array.Length == number) Resize(2 * array.Length);
            array[number++] = item;   
        }

        public ArrayModel Pop()
        {
            ArrayModel temp = array[--number];
            array[number] = default(ArrayModel);
            if (number > 0 && number == array.Length / 4) Resize(array.Length / 2);
            return temp;
        }

        private void Resize(int capacity)
        {
            ArrayModel[] temp = new ArrayModel[capacity];
            for (var i = 0; i < array.Length;i++ )
            {
                temp[i] = array[i];
            }
            array = temp;
        }
    }
}
