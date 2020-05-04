using Algorithms;
using System;
using System.Collections.Generic;

namespace SortingAlgo
{
    class Program
    {
        static void Main(string[] args)
        {
            List<long> ls = new List<long>(new long[] {  2, 3, 4, 4, 2, 8, 10, 0 });
    

            SortContext sortContext = new SortContext();
            List<IAlgorithm> algorithms = new List<IAlgorithm>() 
                                                {new StableSort(),
                                                 new BucketSort() };

            StableSort stableSort = new StableSort();
            BucketSort bucketSort = new BucketSort();
            TournamentSort tournamentSort = new TournamentSort();
            var res = tournamentSort.Sort(ls);

            foreach (var item in res)
            {
                Console.WriteLine(item);
            }

            Console.WriteLine("Hello World!");
            Console.ReadKey();
        }
    }
}
