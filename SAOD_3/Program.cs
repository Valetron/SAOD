using System;

namespace SAOD_3
{
    class Program
    {
        static void Main(string[] args)
        {
            Random num = new Random();
            MyList<int> list = new MyList<int>();
            int tmp;

            // добавить в начало
            list.AddFirst(num.Next(-10, 10));

            // первый элемент
            Console.WriteLine($"First = {list.First}");

            // добавить в конец
            list.AddLast(num.Next(-10, 10));

            // последний элемент
            Console.WriteLine($"Last = {list.Last}");

            // добавить по индексу
            tmp = num.Next(-100, 100);
            //Console.WriteLine(tmp);
            list.Insert(tmp, 1);
            list.Print();

            // удалить по индексу
            list.Remove(num.Next(0, list.Count));
            list.Print();

            // количество элементов
            Console.WriteLine($"Count elements = {list.Count}");

            // первый узел с указанным значением
           //tmp = num.Next(-10, 10);
            Console.Write($"Index of {tmp} is ");
            Console.Write(list.IndexOf(tmp) + "\n");

            // перечисление
            Console.WriteLine("Elements: ");
            foreach (int elem in list)
            {
                Console.WriteLine(elem);
            }

            // очситка списка
            list.Clear();
            list.Print();
        }
    }
}
