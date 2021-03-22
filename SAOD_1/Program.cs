using System;

namespace SAOD_1
{
    class Program
    {
        static void Main(string[] args)
        {
            MyVectorList<int> list = new MyVectorList<int>();
            Random num = new Random();
            int list_size;
            int tmp;

            Console.Write("List size = ");
            list_size = Convert.ToInt32(Console.ReadLine());
            
            // Заполнение числами
            for (int i = 0; i < list_size; i++)
            {
                list.Add(num.Next(-10, 10));
            }
                
            // Вывод первого и последнего значения, и количетсво элементов
            Console.WriteLine($"First element - {list.First}, last element - {list.Last}, count of elements = {list.Count}");
            
            // Вставка в начало, середину и конец списка
            list.Insert(num.Next(-10, 10), 0);
            Console.WriteLine($"Insert in head First element - {list.First}, last element - {list.Last}, count of elements = {list.Count}");
            list.Insert(num.Next(-10, 10), (int)(list.Count / 2));
            Console.WriteLine($"Insert in middle First element - {list.First}, last element - {list.Last}, count of elements = {list.Count}");
            list.Insert(num.Next(-10, 10), list.Count);
            Console.WriteLine($"Insert in a tail First element - {list.First}, last element - {list.Last}, count of elements = {list.Count}");

            // Удаление из начала, середины и конца
            list.RemoveAt(0);
            Console.WriteLine($"Remove head First element - {list.First}, last element - {list.Last}, count of elements = {list.Count}");
            list.RemoveAt((int)(list.Count / 2));
            Console.WriteLine($"Remove middle First element - {list.First}, last element - {list.Last}, count of elements = {list.Count}");
            list.RemoveAt(list.Count);
            Console.WriteLine($"Remove tail First element - {list.First}, last element - {list.Last}, count of elements = {list.Count}");

            // Вхождение элемента в коллекцию
            tmp = num.Next(-10, 10);
            if (list.Contains(tmp))
            {
                Console.WriteLine($"Element {tmp} is in list");
            }
            else
            {
                Console.WriteLine($"Element {tmp} is not in list");
            }

            // Вывод индекса первого вхождения элемента
            tmp = num.Next(-10, 10);
            if (list.IndexOf(tmp) >= 0)
            {
                Console.WriteLine($"Element {list[list.IndexOf(tmp)]} is in list, index = {list.IndexOf(tmp)}");
            }
            else
            {
                Console.WriteLine($"Element {tmp} is not in list");
            }

            // Перегрузка []
            Console.Write("List = [");
            for (int i = 0; i < list.Count; i++)
            {
                Console.Write(list[i] + " ");
            }
            Console.Write("]");
        }
    }
}
