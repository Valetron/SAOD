using System;

namespace SAOD_4
{
    class Program
    {
        static void Main(string[] args)
        {
            BinaryTree tree = new BinaryTree();

            // добавление элементов
            tree.Add(11);
            tree.Add(5);
            tree.Add(3);
            tree.Add(7);
            tree.Add(2);
            tree.Add(22);
            tree.Add(4);
            Console.WriteLine("Count of elements = " + tree.Count);

            Console.WriteLine("\nTree");
            Console.WriteLine(tree.Print());

            // высота дерева
            Console.WriteLine("Height = " + tree.getHeight(tree.root));

            // кол-во листьев
            Console.WriteLine("Leaves: " + tree.LeafCount(tree.root));

            // нахождение элемента в дереве
            Console.Write("Element to find: ");
            int element = Convert.ToInt32(Console.ReadLine());
            if (tree.Contains(element))
            {
                Console.WriteLine("Contains!");
            }
            else
            {
                Console.WriteLine("No such element");
            }

            // максимальное значение
            Console.WriteLine("Maximum = " + tree.MaxItr());

            //минимальное значение
            Console.WriteLine("Minimum = " + tree.MinItr());

            /*Console.WriteLine(tree.Print());
            tree.root = tree.r_rotation(tree.root);
            Console.WriteLine(tree.Print());
            tree.root = tree.l_rotation(tree.root);
            Console.WriteLine(tree.Print());*/

            // удалить все элементы
            tree.Clear();
            Console.WriteLine("tree is empty, elements = " + tree.Count);
        }
    }
}
