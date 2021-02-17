using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SAOD_0
{
    class MyStack<T> // pop peek count
    {

        int[] array;

        MyStack(int array_size)
        {
            array = new int[array_size];
        }

        public void Pop()
        {
            
        }

        public int Peek()
        {
            return array[0];
        }

        public int Count()
        {
            return array.Length;
        }

    }
}
