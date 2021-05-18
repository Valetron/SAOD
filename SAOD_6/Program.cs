using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SAOD_6
{
    class Program
    {
        static void Main(string[] args)
        {
            var rnd = new System.Random(1);
            var init = Enumerable.Range(0, 100000).OrderBy(x => rnd.Next()).ToArray();
            var avltree = new AVLTree();
            foreach(var i in init)
                avltree.Add(i);
            Console.WriteLine(avltree.GetHeight());
        }
    }
}
