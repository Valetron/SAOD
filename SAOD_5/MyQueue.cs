using System;

namespace SAOD_5
{
    class MyQueue<T> : MyList<T>
    {
        public MyQueue()
        {
            head = null;
            tail = head;
            count = 0;
        }

        public void Enqueue(T elem)
        {
            AddLast(elem);
        }

        public T Dequeue()
        {
            var t = First;
            Remove(0);
            return t;
        }

        public bool Empty()
        {
            return Count == 0;
        }
    }
}
