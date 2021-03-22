using System;

namespace SAOD_3
{
    class Program
    {
        static void Main(string[] args)
        {
            Random num = new Random();
            MyList<int> list = new MyList<int>();
            int size;
            int tmp;

            // добавить в начало
            list.AddFirst(num.Next(-10, 10));

            // добавить в конец
            list.AddLast(num.Next(-10, 10));

            /*// добавить по индексу
            tmp = num.Next(-100, 100);
            Console.WriteLine(tmp);
            list.Insert(tmp, 1);*/

            // удалить по индексу

            // первый элемент
            Console.WriteLine($"First = {list.First}");

            // последний элемент
            Console.WriteLine($"Last = {list.Last}");

            // количество элементов
            Console.WriteLine($"Count elements = {list.Count}");

            // первый узел с указанным значением
            /*tmp = num.Next(-10, 10);
            Console.WriteLine($"Element {list.GetValue(tmp)}, index {tmp}");*/

            // вывод списка
            Console.Write("List = [ ");
            for (int i = 0; i < list.Count; i++)
            {
                Console.Write(list[i] + " ");
            }
            Console.Write("]\n");

            // очситка списка
            list.Clear();
            Console.Write("List = [ ");
            for (int i = 0; i < list.Count; i++)
            {
                Console.Write(list[i] + " ");
            }
            Console.Write("]");
        }
    }
}
