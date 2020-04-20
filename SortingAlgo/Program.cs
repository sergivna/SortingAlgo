using Algorithms;
using System;
using System.Collections.Generic;

namespace SortingAlgo
{
    class Program
    {
        static void Main(string[] args)
        {
            List<long> ls = new List<long>(new long[] { 1, 2, 3, 4, 4, 2 });
    

            SortContext sortContext = new SortContext();
            List<IAlgorithm> algorithms = new List<IAlgorithm>() 
                                                {new StableSort(),
                                                 new BucketSort() };

            StableSort stableSort = new StableSort();
            var res = stableSort.Sort(ls);

            foreach (var item in res)
            {
                Console.WriteLine(item);
            }

            Console.WriteLine("Hello World!");
            Console.ReadKey();
        }
    }
}
