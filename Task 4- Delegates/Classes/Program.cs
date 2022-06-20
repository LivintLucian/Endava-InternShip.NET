using System;
using System.Collections.Generic;
using System.Linq;

namespace Delegates
{
    class Program
    {
        static void Filter<T>(List<T> strings, Func<T, bool> condition)
        {
            var returnList = strings.Where(condition);

            foreach (var entry in returnList)
            {
                Console.WriteLine(entry);
            }
        }
        static void PrintOddNumbers(int n)
        {
            for (int i = 0; i < n; ++i)
            {
                Console.Write((i * 2) + 3);
            }

        }

        static void Main(string[] args)
        {
            long average = 0;
            Action<int> printAction = PrintOddNumbers;
            
            for (int index = 0; index < 100; index++)
            {
                var watch = System.Diagnostics.Stopwatch.StartNew();
                //printAction(10);
                watch.Stop();
                var elapsedMS = watch.ElapsedMilliseconds;
                average += elapsedMS;
                //Console.WriteLine("\nTime- " + index + ": " + elapsedMS);
            }

            //Console.WriteLine(average / 100);
            /*
             * Ex 2.
             */
            List<string> list=new List<string>(){"aaa","bb","c","d","eee"};
            Filter(list, s => s.Length == 2);
        }
    }
}
