using Algorithms;
using System;
using System.Collections.Generic;

namespace SortingAlgo
{
    class Program
    {
        static void Main(string[] args)
        {
            List<long> ls = new List<long>();
            for (int i = 0; i < 1000000; i++)
            {
                ls.Add(3000000000);
            }

            SortContext sortContext = new SortContext();
            List<IAlgorithm> algorithms = new List<IAlgorithm>() 
                                                {new StableSort(),
                                                 new BucketSort() };

            foreach (var algo in algorithms)
            {
                algo.Sort();
            }


            Console.WriteLine("Hello World!");
            Console.ReadKey();
        }
    }
}
