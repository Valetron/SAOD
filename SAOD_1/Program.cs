using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SAOD_1
{
    class Program //сделать список векторный, перезагрузить get set, попробовать сделать foreach, метод IndexOF
    {
        static void Main(string[] args)
        {

            VectorList<int> my_list = new VectorList<int>();
            Random num = new Random();
            int list_lenght;

            Console.Write("List size = ");
            list_lenght = Convert.ToInt32(Console.ReadLine());

            // работа метода Add
            for (int i = 0; i < list_lenght; i++)
            {
                my_list.Add(num.Next(0, 100));
            }
            Console.WriteLine("Method Add");
            my_list.ShowList();
            Console.WriteLine("\nLenght = " + Convert.ToString(my_list.Size));
            // работа метода Insert
            my_list.Insert(num.Next(10, 100), 0);
            my_list.Insert(num.Next(10, 100), my_list.Size / 2);
            my_list.Insert(num.Next(10, 100), my_list.Size - 1);
            Console.WriteLine("\nMethod Insert");
            my_list.ShowList();

            Console.Read();

        }
    }
}
