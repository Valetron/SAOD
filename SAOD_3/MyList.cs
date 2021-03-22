using System;
using System.Collections.Generic;
using System.Text;

namespace SAOD_3
{
    class MyList<T>
    {
        private Node<T> head;
        private Node<T> tail;
        private int count;

        public MyList()
        {
            head = null;
            tail = head;
            count = 0;
        }

        public void AddFirst(T elem)
        {
            var node = new Node<T>(elem);
            if (head == null)
            {
                head = node;
                tail = head;
            }
            else
            {
                node.next = head;
                head = node;
            }
            count++;
        }

        public void AddLast(T elem)
        {
            var node = new Node<T>(elem);
            if (head == null)
            {
                head = node;
                tail = head;
            }
            else
            {
                tail.next = node;
                tail = node;
            }
            count++;
        }

        public void Insert(T elem, int index)
        {
            var node = new Node<T>(elem);
            var curr = head;

            for (int i = 0; i <= index & curr.next != null; i++)
            {
                if (i == index - 1)
                {
                    Console.WriteLine(Convert.ToString(curr.next) + " " + node);
                    curr.next = node;
                    curr = curr.next;
                    //curr = node;
                    //curr.data = node.data;
                }
                else if (i == index)
                {
                    node.next = curr.next;
                    count++;
                }
                else
                {
                    curr = curr.next;
                }

            }
        }

        public void Remove(int index)
        {

        }

        public void Clear()
        {
            head = null;
            tail = null;
            count = 0;
        }

        private T GetValue(int position)
        {
            var curr = head;
            for (int i = 0; i < position & curr.next != null; i++)
            {
                curr = curr.next;
            }
            return curr.data;
        }

        private void SetValue(int position, T elem)
        {
            var curr = head;
            for (int i = 0; i < position & curr.next != null; i++)
            {
                curr = curr.next;
            }
            curr.data = elem;
        }

        public T this[int index]
        {
            get
            {
                return GetValue(index);
            }
            set
            {
                SetValue(index, value);
            }
        }

        public int Count
        {
            get { return count; }
        }

        public T First
        {
            get { return GetValue(0); }
        }

        public T Last
        {
            get { return GetValue(count); }
        }
    }
}
