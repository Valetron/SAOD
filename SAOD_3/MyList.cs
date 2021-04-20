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

            if (index == 0)
            {
                AddFirst(elem);
            }
            else
            {
                for (int i = 0; i < index - 1 & curr.next != null; i++)
                {
                    curr = curr.next;
                }
                node.next = curr.next;
                curr.next = node;
                count++;
            }
        }

        public void Remove(int index)
        {
            var curr = head;

            if (index == 0)
            {
                head = head.next;
                /*for (int i = 0; i < count - 1 & curr.next != null; i++)
                {
                    curr = curr.next;
                }
                tail = curr;*/
                count--;
            }
            else
            {
                for (int i = 0; i < index - 1 & curr.next != null; i++)
                {
                    curr = curr.next;
                }
                curr.next = curr.next.next;
                count--;
            }
        }

        public void Clear()
        {
            head = null;
            tail = null;
            count = 0;
        }

        public void Print()
        {
            var curr = head;

            Console.Write("List = [ ");
            while (curr != null)
            {
                Console.Write(curr.data + " ");
                curr = curr.next;
            }
            Console.Write("]\n");
        }

        public int IndexOf(T elem)
        {
            var curr = head;
            int index = 0;

            while (curr != null)
            {
                if (object.Equals(elem, curr.data))
                {
                    return index;
                }
                index++;
                curr = curr.next;
            }
            return -1;
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

        public IEnumerator<T> GetEnumerator()
        {
            var current = head;
            while (current != null)
            {
                yield return current.data;
                current = current.next;
            }
        }
    }
}
