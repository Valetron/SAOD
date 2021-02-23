using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SAOD_0
{
    class MyStack<T> // pop peek count
    {

        private T[] array;
        private int size = 100;

        public MyStack()
        {
            array = new T[size];
        }

        public void Push(T element)
        {
            Array.Resize(ref array, size + 1);
            array[size] = element;
            //++size;
        }

        public T Pop()
        {
            T element = array[--size];

            return element;
        }

        public T Peek()
        {
            return array[size - 1];
        }

        public bool is_empty { get { return size == 0; } }

        public int count { get { return size; } }

    }
}
