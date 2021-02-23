using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SAOD_0 // передаем в стек пару координат x, y; получаем координаты и заполняем
{
    class Program
    {

        public static MyStack<ValueTuple<int, int>> stack = new MyStack<ValueTuple<int, int>>();
        public static int x;
        public static int y;
        public static int[,] matrix;

        static void fill(ValueTuple<int, int> coords)
        {
            stack.Push(coords);

            while (! stack.is_empty)
            {
                ValueTuple<int, int> last = stack.Peek();
                
                stack.Pop();
                /*if (matrix[last.Item1, last.Item2] == 0)
                {
                    matrix[last.Item1, last.Item2] = 2;
                }*/
                matrix[last.Item1, last.Item2] = 2;

                if (last.Item1 + 1 < x && matrix[last.Item1 + 1, last.Item2] == 0)
                {
                    coords = new ValueTuple<int, int>(last.Item1 + 1, last.Item2);
                    stack.Push(coords);
                }
                if (last.Item1 - 1 >= 0 && matrix[last.Item1 - 1, last.Item2] == 0)
                {
                    coords = new ValueTuple<int, int>(last.Item1 - 1, last.Item2);
                    stack.Push(coords);
                }
                if (last.Item2 + 1 < y && matrix[last.Item1, last.Item2 + 1] == 0)
                {
                    coords = new ValueTuple<int, int>(last.Item1, last.Item2 + 1);
                    stack.Push(coords);
                }
                if (last.Item2 - 1 >= 0 && matrix[last.Item1, last.Item2 - 1] == 0)
                {
                    coords = new ValueTuple<int, int>(last.Item1, last.Item2 - 1);
                    stack.Push(coords);
                }
            }
            /*if (x >= 0 && y >= 0 && x < array.GetLength(0) && y < array.GetLength(1) && array[x, y] == d)
            {
                array[x, y] = color;
                recursion_deepth++;
                fill(x + 1, y, color, d, array, recursion_deepth);
                fill(x, y + 1, color, d, array, recursion_deepth);
                fill(x - 1, y, color, d, array, recursion_deepth);
                fill(x, y - 1, color, d, array, recursion_deepth);
            }*/
        }

        static void Main(string[] args)
        {
            int count_0 = 0;
            int count_1 = 0;
            Random p = new Random(); // if p<0.25 == 1 else 0
            
            Console.Write("X >> ");
            x = Convert.ToInt32(Console.ReadLine());
            Console.Write("Y >> ");
            y = Convert.ToInt32(Console.ReadLine());
            matrix = new int[x, y];

            for (int i = 0; i < x; i++)
            {
                for (int j = 0; j < y; j++)
                {
                    if (p.Next(1, 5) == 1)
                    {
                        matrix[i, j] = 1;
                        Console.Write(matrix[i, j]);
                        count_1++;
                    }
                    else
                    {
                        matrix[i, j] = 0;
                        Console.Write(matrix[i, j]);
                        count_0++;
                    }
                }
                Console.WriteLine();
            }
            
            Console.WriteLine("One - " + count_1);
            Console.WriteLine("Zero - " + count_0);
            Console.WriteLine("\nFilled");

            fill( (0, 0) );

            for (int i = 0; i < x; i++)
            {
                for (int j = 0; j < y; j++)
                {
                    Console.Write(matrix[i, j]);
                }
                Console.WriteLine();
            }
            Console.ReadLine();
        }
    }
}
