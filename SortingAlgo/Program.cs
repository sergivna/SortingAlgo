using Algorithms;
using RandomData;
using System;
using System.Collections.Generic;
using System.Linq;

namespace SortingAlgo
{
    class Program
    {
        static void Main(string[] args)
        {
           // List<long> ls = new List<long>(new long[] {  2, 3, 4, 4, 2, 8, 10, 0 });
            Rand rand = new Rand();
            List<List<List<long>>> data = rand.GetData();
            List<List<long>> times  = new List<List<long>>(4);

            SortContext sortContext = new SortContext();

            List<IAlgorithm> algorithms = new List<IAlgorithm>() 
                                                {
                                                 new FranceschiniSort(),
                                                 new StableSort(),
                                                 new BucketSort(),
                                                 new TournamentSort(),
                                                 new IntroSort(),
                                                 new QuickSort()};


            //StableSort stableSort = new StableSort();
            //BucketSort bucketSort = new BucketSort();
            //TournamentSort tournamentSort = new TournamentSort();
            //IntroSort introSorting = new IntroSort();
            //QuickSort sorting = new QuickSort();
            //FranceschiniSort franceschiniSort = new FranceschiniSort();

            foreach (var algo in algorithms)
            {
                foreach (var listsByCount in data)
                {
                    foreach (var list in listsByCount)
                    {
                        var res = algo.Sort(list);

                    }
                    //var result = res.GroupBy(s => s).Select(g => new { Count = g.Count(), Str = g.Key }).OrderByDescending(a => a.Count).ToList();
                }
            }

            // var res = franceschiniSort.Sort(ls);

            //foreach (var item in res)
            //{
            //    Console.WriteLine(item);
            //}

            Console.ReadKey();
        }
    }
}
