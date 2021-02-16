using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SAOD_0
{
    class Program
    {

        static void fill(int x, int y, int color, int d, int[,] array, int recursion_deepth)
        {
            if (x >= 0 && y >= 0 && x < array.GetLength(0) && y < array.GetLength(1) && array[x, y] == d)
            {
                array[x, y] = color;
                recursion_deepth++;
                fill(x + 1, y, color, d, array, recursion_deepth);
                fill(x, y + 1, color, d, array, recursion_deepth);
                fill(x - 1, y, color, d, array, recursion_deepth);
                fill(x, y - 1, color, d, array, recursion_deepth);
                //Console.WriteLine("Deepth " + recursion_deepth);
            }
        }

        static void Main(string[] args)
        {
            int x;
            int y;
            int count_0 = 0;
            int count_1 = 0;
            Random p = new Random(); // if p<0.25 == 1 else 0
            Console.Write("X >> ");
            x = Convert.ToInt32(Console.ReadLine());
            Console.Write("Y >> ");
            y = Convert.ToInt32(Console.ReadLine());
            int[,] matrix = new int[x, y];
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
            for (int i = 0; i < x; i++)
            {
                for (int j = 0; j < y; j++)
                {
                    fill(i, j, 2, 0, matrix, 0);
                    Console.Write(matrix[i, j]);
                }
                Console.WriteLine();
            }
            //Console.ReadKey();
        }
    }
}
