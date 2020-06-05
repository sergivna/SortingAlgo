using Algorithms;
using RandomData;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Text;

namespace CalculateTimes
{
    public static class Sort
    {
        public static List<Result> CalculateRealData()
        {

            Rand rand = new Rand();

            List<Result> keyValues = new List<Result>();

            List<IAlgorithm> algorithms = new List<IAlgorithm>()
                                                {
                                                 new TournamentSort(),
                                                 new BucketSort(),
                                                 new FranceschiniSort()};
            //new StableSort(),
            //new IntroSort(),
            //new QuickSort()};

            Stopwatch clock = new Stopwatch();
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
                        clock.Reset();
                    }
                    //var result = res.GroupBy(s => s).Select(g => new { Count = g.Count(), Str = g.Key }).OrderByDescending(a => a.Count).ToList();
                    Console.WriteLine("Time" + time);
                    keyValues.Add(new Result(algo.Name, listsByCount[0].Count, (i++) % 4 + 1, time));
                    time = TimeSpan.Zero;
                }
            }

            return keyValues;
        }
    }

    public class Result
    {
        public Result(string name, int count, int type, TimeSpan timeSpan)
        {
            this.Algo = name;
            this.Count = count;
            this.Type = type;
            this.AverageTime = timeSpan;
        }

        public string Algo { get; set; }

        public int Count { get; set; }
        public int Type { get; set; }

        public TimeSpan AverageTime { get; set; }
    }

}
