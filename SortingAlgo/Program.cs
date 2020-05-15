using Algorithms;
using RandomData;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;

namespace SortingAlgo
{
    class Program
    {
        static void Main(string[] args)
        {
           // List<long> ls = new List<long>(new long[] {  2, 3, 4, 4, 2, 8, 10, 0 });
            Rand rand = new Rand();
          //  List<List<List<long>>> data = rand.GetData();
            List<List<long>> times  = new List<List<long>>(4);

            SortContext sortContext = new SortContext();
            Dictionary<string, TimeSpan> keyValues = new Dictionary<string, TimeSpan>();

            List<IAlgorithm> algorithms = new List<IAlgorithm>()
                                                {
                                                 new TournamentSort(),
                                                 new BucketSort(),
                                                 new FranceschiniSort()};
                                                 //new StableSort(),
                                                 //new IntroSort(),
                                                 //new QuickSort()};

            Stopwatch clock = new Stopwatch();
            //StableSort stableSort = new StableSort();
            //BucketSort bucketSort = new BucketSort();
            //TournamentSort tournamentSort = new TournamentSort();
            //IntroSort introSorting = new IntroSort();
            //QuickSort sorting = new QuickSort();
            //FranceschiniSort franceschiniSort = new FranceschiniSort();
            int i = 0;
            TimeSpan time = new TimeSpan(0);
            foreach (var algo in algorithms)
            {
                List<List<List<long>>> data = rand.GetData();

                foreach (var listsByCount in data)
                {
                    for (int j = 0; j < listsByCount.Count; j++)
                    {
                        clock.Start();
                        var res = algo.Sort(listsByCount[j]);
                        clock.Stop();

                        time += clock.Elapsed;
                        Console.WriteLine(  " hh" + clock.Elapsed);
                        clock.Reset();
                    }
                    //var result = res.GroupBy(s => s).Select(g => new { Count = g.Count(), Str = g.Key }).OrderByDescending(a => a.Count).ToList();
                    Console.WriteLine("hdfh" + time);
                    keyValues.Add(algo.Name + listsByCount.Count.ToString() + (++i).ToString() , time / 5);
                    time = TimeSpan.Zero;
                }
            }

            // var res = franceschiniSort.Sort(ls);

            foreach (var item in keyValues)
            {
                Console.WriteLine(item.Key + " " + item.Value);
            }

            Console.ReadKey();
        }
    }
}
