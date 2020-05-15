using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Algorithms
{
    public class BucketSort : IAlgorithm
    {
        public string Name { get; } = "BucketSort";

        public List<long> Sort(List<long> list)
        {
            long min = list.OrderBy(i => i).FirstOrDefault();
            long max = list.OrderByDescending(i => i).FirstOrDefault();
            long divider = max - min + 1;
            float fraction;
            int bi;
            // 1) Create n empty buckets 
            //vector<float> b[n];
            var buckets = new List<List<long>>();
            for (int i = 0; i < list.Count; i++)
            {
                buckets.Add(new List<long>());
            }

            // 2) Put array elements in different buckets 
            for (int i = 0; i < list.Count; i++)
            {
                fraction = (float)((float)(list[i] - min) / divider);
                bi = (int)((fraction * list.Count) / (list.Count - 1)); // Index in bucket 
                buckets[bi].Add(list[i]);
            }

            // 3) Sort individual buckets 
            for (int i = 0; i < list.Count; i++)
                buckets[i].Sort();

            // 4) Concatenate all buckets into arr[] 
            int index = 0;
            for (int i = 0; i < list.Count; i++)
                for (int j = 0; j < buckets[i].Count; j++)
                    list[index++] = buckets[i][j];

            Console.WriteLine("BucketSort");
            return list;
        }
    }
}
