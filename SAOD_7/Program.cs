using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SAOD_7
{
    class Program
    {
        static void Main(string[] args)
        {
            // var text = "aa bb c aa cc bb a aa bb aa";
            string text = System.IO.File.ReadAllText(@"big.txt");
            string[] input_check = System.IO.File.ReadAllLines(@"check.txt");
            System.Diagnostics.Stopwatch watch = System.Diagnostics.Stopwatch.StartNew(); 
            long elapsedMs;
            
            var cont = new SortedDictionary<string, int>();
            var str = new  StringBuilder();
            
            foreach (var i in text)
            {
                if ( (i >= 'a' && i <= 'z') || (i >= 'A' && i <= 'Z') )
                {
                    str.Append(i);
                }
                else if (str.Length > 0)
                {
                    var s = str.ToString();

                    // if ( cont.ContainsKey(s))
                    // {
                    //     ++cont[s];
                    // }
                    // else
                    // {
                    //     cont[s] = 1;
                    // }

                    if (cont.TryGetValue(s, out var v))
                    {
                        v++;
                    }
                    else
                    {
                        cont.Add(s, 1);
                    }

                    str.Clear();
                }
            }
            // StringBuilder word = new StringBuilder();
            // var dict = new List<Tuple<string, int>>();
            // foreach (var c in my_str)
            // {
            //     if ( (c >= 'a' && c <= 'z') || (c >= 'A' && c <= 'Z') )
            //     {
            //         word.Append(c);
            //     }
            //     else
            //     {
            //         //var index = dict.For(x => x.Item1 == word.ToString());
            //         for (int i = 0; i < dict.Count; i++)
            //         {
            //             if (dict[i].Item1 == words)
            //             {
            //                 dict[i] = new Tuple<string, int>(words, dict[i].Item2 + 1);
            //             }
            //             else
            //             {
            //                 dict[i] = new Tuple<string, int>(words, 1);
            //             }
            //         }
            //         word.Clear();
            //     }
            // }

            // foreach (var item in cont)
            // {
            //     Console.WriteLine(item);
            // }
            watch.Stop();
            elapsedMs = watch.ElapsedMilliseconds;
            System.Console.WriteLine("time:  " + elapsedMs);
            Console.WriteLine("Count = " + cont.Count);
        }
    }
}
