using System;
using System.Collections.Generic;
using System.Text;

namespace SAOD_1
{
    class MyVectorList<T>
    {
        static private int size = 0;
        public T[] data = new T[size];

        public void Add(T elem)
        {
            size++;
            Array.Resize(ref data, size);
            data[size-1] = elem;
        }

        public void Insert(T elem, int pos)
        {
            size++;
            Array.Resize(ref data, size);
            for (int i = data.Length - 1; i > pos; i--)
            {
                data[i] = data[i - 1];
            }
            data[pos] = elem;
        }

        public void RemoveAt(int pos)
        {
            for (int i = pos; i < size - 1; i++)
            {
                data[i] = data[i + 1];
            }
            size--;
            Array.Resize(ref data, size);
        }

        public bool Contains(T item)
        {
            foreach (T element in data)
            {
                if (Object.Equals(element, item))
                {
                    return true;
                }
            }
            return false;
        }

        public int IndexOf(T item)
        {
            int index = 0;
            foreach (T element in data)
            {
                if (Object.Equals(element, item))
                {
                    return index;
                }
                else
                {
                    index++;
                }
            }
            return -1;
        }

        public T First
        {
            get 
            { 
                if (size > 0)
                { 
                    return data[0]; 
                }
                else 
                { 
                    return default(T); 
                } 
            }
        }

        public T Last
        {
            get
            {
                if (size > 0)
                {
                    return data[size - 1];
                }
                else
                {
                    return default(T);
                }
            }
        }

        public T this[int index]
        {
            get 
            { 
                return data[index]; 
            }
        }

        public void Clear()
        {
            data = new T[0];
        }

        public int Count 
        { 
            get 
            { 
                return size; 
            } 
        }
    }
}
