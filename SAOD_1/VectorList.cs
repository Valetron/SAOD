using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SAOD_1
{
    class VectorList<T>
    {
        private int size = 0;
        private T[] array;

        /*public VectorList(int new_size)
        {
            array = new T[new_size];
        }*/

        public VectorList()
        {
            array = new T[size];
        }

        public void Add(T element)
        {
            if (array.Length == size)
            {
                Array.Resize(ref array, size + 1);
            }
            array[size++] = element;
        }

        public void Insert(T element, int index)
        {
            if (index >= array.Length || index < 0)
            {
                Console.WriteLine("Wrong index");
                return;
            }
            else
            {
                if (array.Length == size)
                {
                    Array.Resize(ref array, size + 1);
                    for (int i = index; i < array.Length - 1; i++)
                    {
                        T tmp = array[i + 1];
                        array[i] = tmp;
                    }
                }
            }
        }

        public void RemoveAt(T element, int index)
        {

        }

        public void Clear() 
        {
            Array.Clear(array, 0, size - 1);
        }

        public void ShowList()
        {
            for (int i = 0; i < array.Length; i++)
            {
                Console.Write(array[i]);
                Console.Write(" ");
            }
        }

        public T Last { get { return array[size - 1]; } }

        public T First { get { return array[0]; } }

        public int Size { get { return size; } }
    }
}