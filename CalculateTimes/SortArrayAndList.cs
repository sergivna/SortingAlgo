using Algo;
using Algorithms;
using RandomData;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Text;

namespace CalculateTimes
{
    public static class SortArrayAndList
    {
        public static List<Result> CalculateTimes()
        {
            Rand rand = new Rand();
            List<Result> keyValues = new List<Result>();

            StableSort stableSort = new StableSort();
            StableSortWithArray stableSortWithArray = new StableSortWithArray();
            List<List<List<long>>> data = rand.GetData();  
            List<List<long[]>> dataArray = rand.GetArrayData();
            Stopwatch clock = new Stopwatch();

            int i = 0;
            TimeSpan time = new TimeSpan(0);


            Console.WriteLine("\nStableSortList");
            foreach (var listsByCount in data)
            {
                for (int j = 0; j < listsByCount.Count; j++)
                {
                    clock.Start();
                    var res = stableSort.Sort(listsByCount[j]);
                    clock.Stop();

                    time = clock.Elapsed;
                    Console.WriteLine("Length " + listsByCount[0].Count + " Time " + time);
                    clock.Reset();
                }


                keyValues.Add(new Result(stableSort.Name, listsByCount[0].Count, (i++) % 4 + 1, time));
                time = TimeSpan.Zero;
            }


            Console.WriteLine("StableSortArray");
            foreach (var listsByCount in dataArray)
            {
                for (int j = 0; j < listsByCount.Count; j++)
                {
                    clock.Start();
                    var res = stableSortWithArray.Sort(listsByCount[j]);
                    clock.Stop();

                    time = clock.Elapsed;
                    Console.WriteLine("Length " + listsByCount[0].Length + " Time " + time);
                    clock.Reset();
                }

                
                keyValues.Add(new Result(stableSortWithArray.Name, listsByCount[0].Length, (i++) % 4 + 1, time));
                time = TimeSpan.Zero;
            }



            return keyValues;
        }
    }
}
