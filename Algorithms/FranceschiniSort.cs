using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Algorithms
{
   public  class FranceschiniSort: IAlgorithm
    {
        public List<long> Sort(List<long> list)
        {
            var max = list.Max();
            for (int exp = 1; max / exp > 0; exp *= 10)
            {
                CountingSort(list, list.Count, exp);
            }

            return list;
        }
        public void CountingSort(List<long> list, int length, int exponent)
        {
            long[] output = new long[length];
            int i;

            int[] count = new int[10];
            for (i = 0; i < 10; i++)
            {
                count[i] = 0;
            }
            for (i = 0; i < length; i++)
            {
                count[(list[i] / exponent) % 10]++;
            }

            for (i = 1; i < 10; i++)
            {
                count[i] += count[i - 1];
            }

            for (i = length - 1; i >= 0; i--)
            {
                output[count[(list[i] / exponent) % 10] - 1] = list[i];
                count[(list[i] / exponent) % 10]--;
            }

            for (i = 0; i < length; i++)
            {
                list[i] = output[i];
            }
        }
    }
}
